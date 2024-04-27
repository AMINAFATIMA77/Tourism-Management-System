using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.BL;
using TMS_LIbrary.Utilities;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox3.Text;
            string code = textBox2.Text;
            Validations validations = new Validations();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please provide valid credentials.");
                return;
            }

            // Check if the user is an admin
            if (validations.IsAdmin(userName, password, code))
            {
                MessageBox.Show("You have successfully signed in as an Admin");
                Form adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            // Check if the user is a package manager
            else if (validations.IsManager(code) && ObjectHandler.GetPersonDL().ManagerSignIn(userName, password))
            {
                MessageBox.Show("You have signed in as a Package Manager");
                Form packageManager = new PackageManager();
                packageManager.Show();
            }
            // Check if the user is a resource manager
            else if (!validations.IsManager(code) && ObjectHandler.GetPersonDL().ManagerSignIn(userName, password))
            {
                MessageBox.Show("You have signed in as a Resource Manager");
                Form resourceManager = new ResourceManager();
                resourceManager.Show();
            }
          
            // Check if the user is a customer
            else if (validations.IsCustomer(code) && ObjectHandler.GetPersonDL().ManagerSignIn(userName, password))
            {
                MessageBox.Show("You have signed in as a Customer");
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }

        }
    }
}