using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem.classes
{
    internal static class loginManager
    {
        public static person authenticateUser(string username, string password)
        {
            string Username = "";
            string Password = "";
            string PersonId = "";
            string MobileNumber = "";
            string Email = "";
            string Role = "";

            // get username and password from the database and save the respond
            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT * FROM `person` where username='{username}'";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    Username = reader["username"].ToString();
                    Password = reader["password"].ToString();
                    PersonId = reader["personid"].ToString();
                    MobileNumber = reader["mobilenumber"].ToString();
                    Role = reader["role"].ToString();
                    Email = reader["email"].ToString();





                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }



            if (Username == "")
            {
                MessageBox.Show("Invalid Username");
            }
            else
            {
                if (Password != password)
                {
                    MessageBox.Show("Invalid Password");

                }
                else
                {
                    MessageBox.Show("Login in Success !!");

                    if (Role == "admin")
                    {
                        person user = new admin(PersonId, Username, Password, MobileNumber, Email);
                        return user;
                    }
                    else if (Role == "organizer")
                    {
                        person user = new organizer(PersonId, Username, Password, MobileNumber, Email);
                        return user;
                    }
                    else
                    {
                        person user = new participant(PersonId, Username, Password, MobileNumber, Email);
                        return user;
                    }


                }
            }

            return null;
        }

        public static void registerUser(string username, string password, string confpassword, string email, string number, string role)
        {
            if (validateInput(password, confpassword, role, username))
            {

                DbConnections dbConnection = new DbConnections();


                try
                {
                    dbConnection.OpenConnection();



                    string query2 = $"INSERT INTO `person`(`username`, `password`, `role`, `mobilenumber`, `email`) VALUES ('{username}','{password}','{role}','{number}','{email}')";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Regististration success!! \nLogin to use the application.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }

            }



        }


        private static bool validateInput(string password, string confpassword, string role, string username)
        {
            bool usernameValid = false;

            DbConnections dbConnections5 = new DbConnections();
            string query5 = $"SELECT * FROM `person` where username='{username}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    usernameValid = true;




                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }




            if (usernameValid)
            {
                if (password == confpassword)
                {
                    if (role == "")
                    {
                        MessageBox.Show("Select a role");
                        return false;
                    }
                    else
                    {
                        return true;

                    }

                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username already exists..\nPlease Login..");
                return false;
            }



        }


        public static List<person> getAllUsersList()
        {
            List<person> personList = new List<person>();


            


            DbConnections dbConnections = new DbConnections();
            string query = $"SELECT * FROM `person`";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    string personName = reader["username"].ToString();
                    string personID = reader["personId"].ToString();
                    string personPass = reader["password"].ToString();
                    string personRole = reader["role"].ToString();
                    string personMN = reader["mobilenumber"].ToString();
                    string personEmail = reader["email"].ToString();

                    if (personRole == "admin")
                    {
                        personList.Add(new admin(personID, personName, personPass, personMN, personEmail));
                    }
                    else if (personRole == "organizer")
                    {
                        personList.Add(new organizer(personID, personName, personPass, personMN, personEmail));
                    }
                    else 
                    {
                        personList.Add(new participant(personID, personName, personPass, personMN, personEmail));
                    }

                    





                    
                    













                }
                return personList;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }
            return null;
        }

        public static void changeRole(string user,string role)
        {
            DbConnections dbConnection = new DbConnections();

            try
            {
                dbConnection.OpenConnection();



                string query2 = $"UPDATE person SET role = '{role}' WHERE username = '{user}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                MessageBox.Show($"User : {user} is now an {role}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}
