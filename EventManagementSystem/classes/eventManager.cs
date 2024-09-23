using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using Mysqlx.Crud;

namespace EventManagementSystem.classes
{
    internal static  class eventManager
    {
        public static List<Event> getAllEventsList()
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
              int Tprice;
            

            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT * FROM `event` ORDER BY date ASC, time ASC;";
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
                    MaxParticipants = Convert.ToInt32( reader["maxParticipants"].ToString());
                    CurrentParticipants = Convert.ToInt32(reader["currentParticipants"].ToString());
                    Organizer = reader["organizer"].ToString();
                    Tprice = Convert.ToInt32(reader["price"].ToString());


                    eventList.Add(new Event(EventId,Name,Venue,Time,Date,MaxParticipants,CurrentParticipants,Organizer,Tprice));
                    
                    












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

        public static void createEvent(string name, string venue, string time, string date, string maxparticipant,person organizer,string price)
        {
            
            if (validateInput(name))
            {

                DbConnections dbConnection = new DbConnections();
                try
                {
                    dbConnection.OpenConnection();



                    string query2 = $"INSERT INTO `event`(`name`, `venue`, `time`, `date`, `maxParticipants`, `organizer`,`price`) VALUES ('{name}','{venue}','{time}','{date}','{maxparticipant}','{organizer.getUsername()}','{price}')";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Event successfully created..");
                    
                    
                    

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

        public static void deleteEvent(Event ev)
        {
            
            

                DbConnections dbConnection = new DbConnections();
                try
                {
                    dbConnection.OpenConnection();



                    string query2 = $"DELETE FROM event WHERE eventid = {ev.getEventId()}";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Event successfully deleted..");
                    


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

        public static void editEvent(Event ev,string name,string venue,string time,string date,string maxParticipants,string price)
        {
            string evId = ev.getEventId();
            string evName = name;
            string evVenue = venue;
            string evTime = time;
            string evdate = date;
            string evMaxP = maxParticipants;
            string evPrice = price;
            

            if (name == "")
            {
                evName = ev.getName();
            }
            if (venue== "")
            {
                evVenue = ev.getVenue();
            }
            if (time == "0:0")
            {
                evTime = ev.getTime();
            }
            if (date == "0-0-0")
            {
                
                evdate = ev.getDate();
                
            }
            if (maxParticipants == "0")
            {
                evMaxP = $"{ev.getMaxParticipants()}";
            }
            if(price == "")
            {
                evPrice = $"{ev.getTicketPrice()}";
            }
            
            
            


            DbConnections dbConnection = new DbConnections();
            try
            {
                dbConnection.OpenConnection();


                string query2 = $"UPDATE event SET name='{evName}', venue='{evVenue}', time='{evTime}', date='{evdate}', maxParticipants='{evMaxP}',price={evPrice} WHERE eventID = '{evId}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Event successfully Updated..");

               



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

        public static List<string> getAllEventNamesList()
        {
            List<Event> allEvents = eventManager.getAllEventsList();
            List<string> allEventsNames = new List<string>();

            foreach (Event e in allEvents)
            {
                allEventsNames.Add(e.getName());
            }
            return allEventsNames;  
        }

        private static bool validateInput(string name) 
        {
            bool nameValid = false;

            DbConnections dbConnections5 = new DbConnections();
            string query5 = $"SELECT * FROM `event` where name='{name}'";
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
                    MessageBox.Show("Event name already Exists..");
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

        public static void updateCurrentParticipants(Event ev)
        {
            int participantCount = 0;

            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT * FROM `booking` WHERE event='{ev.getName()}';";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    participantCount += 1;
                    

                }
                
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





            DbConnections dbConnection = new DbConnections();
            try
            {
                dbConnection.OpenConnection();


                string query2 = $"UPDATE event SET currentParticipants={participantCount} WHERE eventId = '{ev.getEventId()}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                





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
}

