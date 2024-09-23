using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    internal static class InputValidator
    {
        public static bool Validate(params string[]fields) 
        {
            bool emptyFields = false;
            foreach (string field in fields) 
            {
                if (field == "")
                {
                    emptyFields = true;
                    
                }
            
            }
            if (emptyFields)
            {
                MessageBox.Show("Please fill all fields");
            }
            return emptyFields;

        }
    }
}
