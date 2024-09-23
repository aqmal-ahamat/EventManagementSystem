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
    public partial class addAdmin : Form
    {
        List<person> allUsers = loginManager.getAllUsersList();
        List<string> allUsersName = new List<string>();
        person logedUser;
        public addAdmin(person user)
        {
            logedUser = user;
            InitializeComponent();
        }

        private void addAdmin_Load(object sender, EventArgs e)
        {
            
            foreach(person user in allUsers)
            {
                if ( user.getRole()!="admin")
                {
                    alluserinput.Items.Add(user.getUsername());
                }
            }

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            foreach (person User in allUsers)
            {
                allUsersName.Add(User.getUsername());
            }

            string user = alluserinput.Text;
            
            string role = "";

            if (organizerbtn.Checked)
            {
                role = "organizer";
            }
            else if (adminbtn.Checked)
            {
                role = "admin";
            }

            

            if (allUsersName.Contains(user))
            {
                if (role != "")
                {


                    DialogResult result = MessageBox.Show("Click YES to change the user's Role ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        loginManager.changeRole(user,role);



                    }
                }else
                {
                    MessageBox.Show("Select a Role");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid User.");
            }
        }
    }
}
