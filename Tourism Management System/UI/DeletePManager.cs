using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.Utilities;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class DeletePManager : Form
    {
        public DeletePManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updatedId = textBox2.Text;
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
                MessageBox.Show("Manager exists.Please carry on with your updation");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (ObjectHandler.GetPersonDL().DeletePerson(id))
            {
                MessageBox.Show("Manager deleted successfully");
            }
            else
            {
                MessageBox.Show("Manager could not be deleted");
            }
        }
    }
}
