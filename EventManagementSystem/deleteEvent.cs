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
    public partial class deleteEvent : Form
    {
        List<classes.Event> events = classes.eventManager.getAllEventsList();
        List<string> eventNames = classes.eventManager.getAllEventNamesList();


        public deleteEvent()
        {
            InitializeComponent();

            

            foreach(string eventName in eventNames)
            {
                alleventsinput.Items.Add(eventName);

            }
            

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           
            if (!InputValidator.Validate(alleventsinput.Text))
            {

                if (eventNames.Contains(alleventsinput.Text))
                {

                    DialogResult result = MessageBox.Show("Do you want to Delete this event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        classes.Event selectedEvent = events[eventNames.IndexOf(alleventsinput.Text)];

                        classes.eventManager.deleteEvent(selectedEvent);
                    }

                }
                else
                {
                    MessageBox.Show("Enter a Valid Event");
                }

                

            }

            


        }

        private void deleteEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
