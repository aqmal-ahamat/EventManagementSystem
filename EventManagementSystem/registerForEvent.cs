using EventManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem
{
    public partial class registerForEvent : Form
    {
        List<classes.Event> events = classes.eventManager.getAllEventsList();
        List<string> eventNames = classes.eventManager.getAllEventNamesList();
        classes.person participant;
        public registerForEvent(classes.person participant)
        {
            this.participant = participant; 
            InitializeComponent();
            foreach (string eventName in eventNames)
            {
                alleventsinput.Items.Add(eventName);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!InputValidator.Validate(alleventsinput.Text))
            {

                if (eventNames.Contains(alleventsinput.Text))
                {

                    DialogResult result = MessageBox.Show("Do you comfirm the booking ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        classes.Event selectedEvent = events[eventNames.IndexOf(alleventsinput.Text)];

                        classes.bookingManager.registerEvent(selectedEvent, participant);
                        
                    }

                }
                else
                {
                    MessageBox.Show("Enter a Valid Event");
                }
            }
        }

        private void registerForEvent_Load(object sender, EventArgs e)
        {

        }
    }
}


   

    
