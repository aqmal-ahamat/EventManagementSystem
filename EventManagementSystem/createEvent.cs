using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class createEvent : Form
    {
        classes.person Organizer;
        public createEvent(classes.person organizer)
        {
            Organizer = organizer;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string venue = venuetxt.Text;
            string time = $"{hourinput.Value}:{minutesinput.Value}";
            string date = $"{yearinput.Value}-{monthinput.Value}-{dayinput.Value}";
            string maxparticipant = maxparticipantinput.Value.ToString();
            string price =  eventPrice.Value.ToString();
            
           

            
            bool emptyFields = InputValidator.Validate(name, venue);

            if (!emptyFields)
            {
                classes.eventManager.createEvent(name, venue, time, date, maxparticipant, Organizer,price);
            }

        }

        private void createEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
