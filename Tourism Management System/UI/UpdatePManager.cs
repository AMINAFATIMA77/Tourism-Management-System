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
    public partial class UpdatePManager : Form
    {
        public UpdatePManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatedId = textBox4.Text;
            string username=textBox1.Text;
            string password=textBox2.Text; 
            string newId=textBox3.Text;
           
            
                Generic.CheckForEmptyTextBoxex(username, password, updatedId);
                Person person = new Person();
                if (!person.SetUserName(username))
                {
                    MessageBox.Show("Invalid UserName");
                    return;
                }
                if (!person.SetPassword(password))
                {

                    MessageBox.Show("Invalid Password");
                    return;
                }
                if (!person.SETManagersId(newId))
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }
                if(ObjectHandler.GetPersonDL().UpdatePerson(updatedId,person))
                {
                    MessageBox.Show("Manager Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Manager could not be updated");
                }

            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string updatedId = textBox4.Text;
            if (string.IsNullOrEmpty(updatedId))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            Validations v1 = new Validations();
            bool ans = v1.PersonExists(updatedId);
            if (!ans)
            {
                MessageBox.Show("Manager with this Id do no exist.Please ReEnter the Id of Manager");
            }
            else
            {
                MessageBox.Show("Package exists.Please carry on with your updation");
                return;
            }

        }
    }
}
