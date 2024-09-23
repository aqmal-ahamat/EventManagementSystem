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
    public partial class editEvents : Form
    {
        List<classes.Event> events = classes.eventManager.getAllEventsList();
        List<string> eventNames = classes.eventManager.getAllEventNamesList();
        public editEvents()
        {
            InitializeComponent();

            foreach (string eventName in eventNames)
            {
                alleventsinput.Items.Add(eventName);

            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = eventnametxt.Text;
            string venue = eventvenuetxt.Text;
            string time = $"{hourinput.Value}:{minutesinput.Value}";
            string date = $"{yearinput.Value}-{monthinput.Value}-{dayinput.Value}";
            string maxParticipants = $"{maxparticipantsinput.Value}";
            string price = eventPrice.Text;
            


            if (!InputValidator.Validate(alleventsinput.Text))
            {

                if (eventNames.Contains(alleventsinput.Text))
                {

                    DialogResult result = MessageBox.Show("Do you want to save Changes ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        classes.Event selectedEvent = events[eventNames.IndexOf(alleventsinput.Text)];

                        classes.eventManager.editEvent(selectedEvent, name, venue, time, date, maxParticipants,price);
                    }

                }
                else
                {
                    MessageBox.Show("Enter a Valid Event");
                }
            }
        }

        private void editEvents_Load(object sender, EventArgs e)
        {

        }

        private void alleventsinput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}