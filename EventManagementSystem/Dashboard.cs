using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Dashboard : Form
    {
        classes.person User;
        public Dashboard(classes.person user)
        {
            
            InitializeComponent();
            User = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            showDashboard();    


        }

        private void viewEventsbtn_Click(object sender, EventArgs e)
        {
            viewAvailableEvents vE = new viewAvailableEvents(User);
            vE.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you confirm to logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void createEventbtn_Click(object sender, EventArgs e)
        {
            createEvent CE = new createEvent(User);
            CE.ShowDialog();
        }

        private void editEventbtn_Click(object sender, EventArgs e)
        {
            editEvents eE = new editEvents();
            eE.ShowDialog();
        }

        private void deleteEventbtn_Click(object sender, EventArgs e)
        {
            deleteEvent dE = new deleteEvent();
            dE.ShowDialog();
        }

        private void RegisterEventsbtn_Click(object sender, EventArgs e)
        {
            registerForEvent rE = new registerForEvent(User);
            rE.ShowDialog();
        }

        private void unregisterbtn_Click(object sender, EventArgs e)
        {
            unregisterfromEvent uE = new unregisterfromEvent(User);
            uE.ShowDialog();
        }

        private void addParticipantsbtn_Click(object sender, EventArgs e)
        {
            addBooking ab = new addBooking();
            ab.ShowDialog();
        }

        private void viewBookingsbtn_Click(object sender, EventArgs e)
        {
            viewBookings vB = new viewBookings();
            vB.ShowDialog();
        }

        private void removeParticipantsbtn_Click(object sender, EventArgs e)
        {
            deleteBooking dB = new deleteBooking();
            dB.ShowDialog();    
        }
        private void showDashboard()
        {
            usernametxt.Text = User.getUsername();
            string role = User.getRole();
            roletxt.Text = role;

            if (role == "organizer") // hide admin buttons from the organizer user
            { 
                
                viewBookingsbtn.Visible = false;
                addAdminbtn.Visible = false;

            
            }
            else if(role =="participant") // hide organizer and admin buttons from the participant user
            {
                viewBookingsbtn.Visible = false;
                addAdminbtn.Visible = false;

                createEventbtn.Visible = false;
                editEventbtn.Visible = false;
                deleteEventbtn.Visible = false;

            }
            showMyevents();

            

        }
        private void showMyevents()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Venue", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Participants", typeof(string));
            table.Columns.Add("Organizer", typeof(string));



            List<classes.Event> allMyEvents = classes.bookingManager.getAllMyEventsList(User);
            foreach (classes.Event ev in allMyEvents)
            {
                string id = ev.getEventId();
                string name = ev.getName();
                string date = ev.getDate();
                string time = ev.getTime();
                string venue = ev.getVenue();
                string participants = $"{ev.getCurrentParticipants()}/ {ev.getMaxParticipants()}";
                string organizer = ev.getOrganizer();
                string price =ev.getTicketPrice().ToString();
                if (price == "0")
                {
                    price = "-";
                }
                

                table.Rows.Add(id, name, date, time, venue,price, participants, organizer);


            }

            myeventsview.RowHeadersVisible = false;
            myeventsview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            

            
            myeventsview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            myeventsview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            myeventsview.DataSource = table;

            myeventsview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            showMyevents();
        }

        private void addAdminbtn_Click(object sender, EventArgs e)
        {
            addAdmin aD = new addAdmin(User);
            aD.ShowDialog();
        }
    }
}


