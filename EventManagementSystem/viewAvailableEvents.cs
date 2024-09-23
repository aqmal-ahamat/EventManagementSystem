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
    public partial class viewAvailableEvents : Form
    {
        classes.person User;
        public viewAvailableEvents(classes.person user)
        {
            User = user;
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewAvailableEvents_Load(object sender, EventArgs e)
        {
            showDataGrid();
            
        }
        private void showDataGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Venue", typeof(string));
            table.Columns.Add("Participants", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Organizer", typeof(string));



            List<classes.Event> allEvents = classes.eventManager.getAllEventsList();
            foreach (classes.Event ev in allEvents)
            {
                string id = ev.getEventId();
                string name = ev.getName();
                string date = ev.getDate();
                string time = ev.getTime();
                string venue = ev.getVenue();
                string participants = $"{ev.getCurrentParticipants()}/ {ev.getMaxParticipants()}";
                string organizer = ev.getOrganizer();
                string price = ev.getTicketPrice().ToString();
                if (price == "0")
                {
                    price = "-";
                }

                table.Rows.Add(id, name, date, time, venue, participants,price, organizer);


            }

            alleventsgrid.RowHeadersVisible = false;
            alleventsgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            alleventsgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            alleventsgrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            


            alleventsgrid.DataSource = table;

            
            alleventsgrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void RegisterEventsbtn_Click(object sender, EventArgs e)
        {
            registerForEvent rE = new registerForEvent(User);
            rE.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            showDataGrid();
        }
    }
}
