using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_Management_System.UI
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form SignIn = new SignIn();
            SignIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form SignUp = new SignUp();
            SignUp.Show();

        }
    }
}
