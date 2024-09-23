using EventManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem.classes
{
    internal static class bookingManager
    {
        public static void registerEvent(Event ev, person participant)
        {
            string eventName = ev.getName();
            string participantName = participant.getUsername();

            if (validateInput(participantName, eventName))
            {
                if (ev.getCurrentParticipants() < ev.getMaxParticipants())
                {
                    if (checkBookingDoesNotExist(participantName, eventName))
                    {




                        DbConnections dbConnection = new DbConnections();
                        try
                        {
                            dbConnection.OpenConnection();



                            string query2 = $"INSERT INTO `booking`( `participant`, `event`) VALUES ('{participantName}','{eventName}')";
                            MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                            cmd2.ExecuteNonQuery();

                            eventManager.updateCurrentParticipants(ev);

                            MessageBox.Show("Booking added succesfully..!");



                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                        finally
                        {
                            dbConnection.CloseConnection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cannot register : Event Overbooked! ");
                }
            }



        }


        public static void unregisterEvent(Event ev, person participant)
        {
            string eventName = ev.getName();
            string participantName = participant.getUsername();

            if (checkBookingExist(participantName, eventName))
            {


                DbConnections dbConnection = new DbConnections();
                try
                {
                    dbConnection.OpenConnection();



                    string query2 = $"DELETE FROM `booking` WHERE participant='{participantName}' and event='{eventName}';";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    eventManager.updateCurrentParticipants(ev);

                    MessageBox.Show("Booking removed succesfully..!");



                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }



        }

        public static List<Event> getAllMyEventsList(person user)
        {
            List<Event> eventList = new List<Event>();


            string EventId;
            string Name;
            string Venue;
            string Time;
            string Date;
            int MaxParticipants;
            int CurrentParticipants;
            string Organizer;
            int Price;


            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT event.* FROM event JOIN booking ON event.name = booking.event WHERE booking.participant = '{user.getUsername()}' ORDER BY event.date ASC, event.time ASC;";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    EventId = reader["eventId"].ToString();
                    Name = reader["name"].ToString();
                    Venue = reader["venue"].ToString();
                    Time = reader["time"].ToString();
                    Date = reader["date"].ToString();
                    MaxParticipants = Convert.ToInt32(reader["maxParticipants"].ToString());
                    CurrentParticipants = Convert.ToInt32(reader["currentParticipants"].ToString());
                    Organizer = reader["organizer"].ToString();
                    Price = Convert.ToInt32(reader["price"].ToString());


                    eventList.Add(new Event(EventId, Name, Venue, Time, Date, MaxParticipants, CurrentParticipants, Organizer,Price));














                }
                return eventList;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }
            return null;
        }



        private static bool validateInput(string participant , string ev)
        {
            bool nameValid = false;

            DbConnections dbConnections5 = new DbConnections();
            string query5 = $"SELECT * FROM `booking` where participant='{participant}' and event='{ev}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    nameValid = true;




                }
                else
                {
                    MessageBox.Show("Booking  already Exists..");
                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return nameValid;

        }

        private static bool checkBookingExist(string participant, string ev)
        {
            bool hasRows = false;

            DbConnections dbConnections5 = new DbConnections();
            string query5 = $"SELECT * FROM `booking` where participant='{participant}' and event='{ev}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (reader5.HasRows)
                {

                    hasRows = true;




                }
                else
                {
                    
                    MessageBox.Show("Cannot delete a booking which does not exists.");
                    
                    
                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return hasRows;

        }

        private static bool checkBookingDoesNotExist(string participant, string ev)
        {
            bool hasRows = false;

            DbConnections dbConnections5 = new DbConnections();
            string query5 = $"SELECT * FROM `booking` where participant='{participant}' and event='{ev}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    hasRows = true;




                }
                else
                {

                    MessageBox.Show("Booking already exists.");


                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return hasRows;

        }
        public static List<Booking> getAllBookingList()
        {
            List<Booking> bookingList = new List<Booking>();
            List<Event> allEventList = eventManager.getAllEventsList();
            List<person> allUsersList = loginManager.getAllUsersList();

            List<string> allEventNames = new List<string>();
            foreach(Event ev in allEventList)
            {
                allEventNames.Add(ev.getName());
            }
            List<string> allUserNames = new List<string>();
            foreach (person p in allUsersList)
            {
                allUserNames.Add(p.getUsername());
            }
            

            string BookingID;
            string PARTICIPANT;
            string EVENT;
            


            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT * FROM `booking`";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {



                    BookingID = reader["bookingID"].ToString();
                    PARTICIPANT = reader["participant"].ToString();
                    EVENT = reader["event"].ToString();
                    
                   Event bookedEvent = allEventList[allEventNames.IndexOf(EVENT)];
                   person bookedUser = allUsersList[allUserNames.IndexOf(PARTICIPANT)];


                   //MessageBox.Show(allUserNames.IndexOf(PARTICIPANT).ToString());
                   bookingList.Add(new Booking(BookingID,bookedEvent,bookedUser));














                }

                return bookingList;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }
            return null;
        }



    }

    


}




