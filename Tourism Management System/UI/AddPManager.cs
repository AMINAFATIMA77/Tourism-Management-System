using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Tourism_Management_System.Utilities;
using TMS_LIbrary.BL;

namespace Tourism_Management_System.UI
{
    public partial class AddPManager : Form
    {
        public AddPManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox3.Text;
            string id = textBox2.Text;
            Generic.CheckForEmptyTextBoxex(username, password, id);
            Person person = new Person();
            if(!person.SetUserName(username))
            {
                MessageBox.Show("Invalid UserName");
                return;
            }
            if(!person.SetPassword(password)) {

                MessageBox.Show("Invalid Password");
                return;
            }
            if(!person.SETManagersId(id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }
            if(ObjectHandler.GetPersonDL().SignUpValidate(person))
            {
                MessageBox.Show("User Already Present.");
                return;
            }

            else if(ObjectHandler.GetPersonDL().SignUp(person))
            {
                MessageBox.Show("Manager Added Successfully.");
            }
           
                
        }
    }
}
