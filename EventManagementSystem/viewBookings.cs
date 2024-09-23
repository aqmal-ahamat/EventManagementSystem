using EventManagementSystem.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class viewBookings : Form
    {
        List<person> allUsers = loginManager.getAllUsersList();
        List<Event> allEvents = eventManager.getAllEventsList();

        public viewBookings()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBookings_Load(object sender, EventArgs e)
        {
            foreach (person user in allUsers)
            {
                userinput.Items.Add(user.getUsername());
            }
            foreach (Event ev in allEvents)
            {
                eventinput.Items.Add(ev.getName());
            }

            showBookings("", "");


        }

        private void filterbtn_Click(object sender, EventArgs e)
        {
            string evenT = eventinput.Text;
            string useR = userinput.Text;

            showBookings(evenT, useR);

        }

        private void showBookings(string eventName, string eventParticpant)
        {
            DataTable table = new DataTable();

            table.Columns.Add("bookingID", typeof(string));
            table.Columns.Add("Participant", typeof(string));
            table.Columns.Add("Event", typeof(string));

            List<Booking> allBookings = bookingManager.getAllBookingList();

            if (eventName == "" && eventParticpant == "")
            {


                foreach (classes.Booking booking in allBookings)
                {
                    string bookingID = booking.getBookingId();
                    string bookingParticipant = booking.getParticipant().getUsername();
                    string bookingEvent = booking.getBookingEvent().getName();




                    table.Rows.Add(bookingID, bookingParticipant, bookingEvent);


                }

            }
            else if (eventName == "" && eventParticpant != "")
            {
                foreach (classes.Booking booking in allBookings)
                {
                    string bookingID = booking.getBookingId();
                    string bookingParticipant = booking.getParticipant().getUsername();
                    string bookingEvent = booking.getBookingEvent().getName();



                    if (eventParticpant == bookingParticipant)
                    {
                        table.Rows.Add(bookingID, bookingParticipant, bookingEvent);
                    }



                }
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show($"User: '{eventParticpant}' does not exist or has not made any bookings yet.");
                }

            }
            else if (eventName != "" && eventParticpant == "")
            {
                foreach (classes.Booking booking in allBookings)
                {
                    string bookingID = booking.getBookingId();
                    string bookingParticipant = booking.getParticipant().getUsername();
                    string bookingEvent = booking.getBookingEvent().getName();



                    if (eventName == bookingEvent)
                    {
                        table.Rows.Add(bookingID, bookingParticipant, bookingEvent);
                    }


                }
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show($"Event: '{eventName}' does not exist or does not contain any participants ");
                }

            }
            else
            {
                foreach (classes.Booking booking in allBookings)
                {
                    string bookingID = booking.getBookingId();
                    string bookingParticipant = booking.getParticipant().getUsername();
                    string bookingEvent = booking.getBookingEvent().getName();



                    if (eventName == bookingEvent && eventParticpant == bookingParticipant)
                    {
                        table.Rows.Add(bookingID, bookingParticipant, bookingEvent);
                    }


                }
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show($"user: '{eventParticpant}' has not registered for event: '{eventName}' ");
                }
            }





            allbookingsview.RowHeadersVisible = false;
            allbookingsview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);



            allbookingsview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            allbookingsview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            allbookingsview.DataSource = table;

            allbookingsview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allbookingsview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            showBookings("", "");
        }

        private void addParticipantsbtn_Click(object sender, EventArgs e)
        {
            addBooking aB = new addBooking();
            aB.ShowDialog();

        }

        private void removeParticipantsbtn_Click(object sender, EventArgs e)
        {
            deleteBooking dB = new deleteBooking();
            dB.ShowDialog();
        }

        private void eventinput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
