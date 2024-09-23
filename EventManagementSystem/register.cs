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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernametxt.Text;
            string password = passwordText.Text;
            string confpassword = confirmpasswordtxt.Text;
            string email = emailtxt.Text;
            string mNumber = numbertxt.Text;
            string role = "participant";

            
            

            bool emptyFields = InputValidator.Validate(username, password, confpassword, email, mNumber, role);

            if (!emptyFields)
            {
                classes.loginManager.registerUser(username, password, confpassword, email, mNumber, role);
            }


        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
