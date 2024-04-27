using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.BL;
using Tourism_Management_System.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tourism_Management_System.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            string password=textBox3.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please provide valid credentials.");
                return;
            }
            Person person = new Person(name,password);
            if(ObjectHandler.GetPersonDL().SignUpValidate(person))
            {
                MessageBox.Show("User with these credentials already present");
                return;
            }
            else
            {
               if( ObjectHandler.GetPersonDL().SignUp(person))
                {
                    MessageBox.Show("You have signed in successfully");
                    Form form = new CustomerMenu();
                }
            }

        }
    }
}
