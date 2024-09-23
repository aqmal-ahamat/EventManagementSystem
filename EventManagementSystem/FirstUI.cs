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
    public partial class FirstUI : Form
    {
        public FirstUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register rg = new register();
            rg.ShowDialog();
        }

        private void FirstUI_Load(object sender, EventArgs e)
        {

        }
    }
}
