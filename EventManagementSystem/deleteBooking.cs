using EventManagementSystem.classes;
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
    public partial class deleteBooking : Form
    {
        List<string> allUsersNames = new List<string>();
        List<string> alleventsNames = new List<string>();
        List<classes.Event> allevents = classes.eventManager.getAllEventsList();
        List<classes.person> allusers = classes.loginManager.getAllUsersList();
        public deleteBooking()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBooking_Load(object sender, EventArgs e)
        {
            foreach (classes.person user in allusers)
            {
                participantinput.Items.Add(user.getUsername());
                allUsersNames.Add(user.getUsername());
            }

            foreach (classes.Event name in allevents)
            {
                eventinput.Items.Add(name.getName());
                alleventsNames.Add(name.getName());

            }

        }

        private void RegisterEventsbtn_Click(object sender, EventArgs e)
        {
            string participant = participantinput.Text;
            string evenT = eventinput.Text;
            if (participant == "")
            {
                MessageBox.Show("Select a user");
            }
            else if (allUsersNames.Contains(participant))
            {
                if (evenT == "")
                {
                    MessageBox.Show("Select an event");
                }
                else if (alleventsNames.Contains(evenT))
                {
                    person selectedPerson = allusers[allUsersNames.IndexOf(participant)];
                    Event selectedEvent = allevents[alleventsNames.IndexOf(evenT)];
                    bookingManager.unregisterEvent(selectedEvent,selectedPerson);

                }
                else
                {
                    
                    MessageBox.Show($"Event: {evenT} does not exist");
                }

            }
            else
            {
                MessageBox.Show($"User: {participant} does not exist");
            }

        }
    }
}
