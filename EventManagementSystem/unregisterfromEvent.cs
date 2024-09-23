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
    public partial class unregisterfromEvent : Form
    {
        List<classes.Event> events = classes.eventManager.getAllEventsList();
        List<string> eventNames = classes.eventManager.getAllEventNamesList();
        classes.person participant;
        public unregisterfromEvent(classes.person participant)
        {
            this.participant = participant;
            InitializeComponent();
            foreach (string eventName in eventNames)
            {
                alleventsinput.Items.Add(eventName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!InputValidator.Validate(alleventsinput.Text))
            {

                if (eventNames.Contains(alleventsinput.Text))
                {

                    DialogResult result = MessageBox.Show("Do you confirm to remove the  booking ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        classes.Event selectedEvent = events[eventNames.IndexOf(alleventsinput.Text)];

                        classes.bookingManager.unregisterEvent(selectedEvent, participant);
                    }

                }
                else
                {
                    MessageBox.Show("Enter a Valid Event");
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unregisterfromEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
