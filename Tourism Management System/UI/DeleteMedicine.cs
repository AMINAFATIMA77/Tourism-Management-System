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
    public partial class DeleteMedicine : Form
    {
        public DeleteMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string updatedName = guna2TextBox2.Text;
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            Validations v1 = new Validations();
            bool ans = v1.MedicineExists(updatedName);
            if (!ans)
            {
                MessageBox.Show("Medicine with this name do no exist.Please ReEnter the name of medicine");
                return;
            }
            else
            {
                MessageBox.Show("Medicine exists.Please carry on with your Deletion");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = guna2TextBox2.Text;
            if (!Validations.IsAlphaNumericWithSpace(name))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (ObjectHandler.GetMedicineDL().DeleteMedicine(name))
            {
                MessageBox.Show("Medicine deleted successfully");
            }
            else
            {
                MessageBox.Show("Medicine could not be deleted");
            }

        }
    }
}
