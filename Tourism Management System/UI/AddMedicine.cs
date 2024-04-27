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
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = guna2TextBox2.Text;
            string quantity = guna2TextBox1.Text;
            string category = guna2TextBox3.Text;
            string description = guna2TextBox4.Text;

            Medicine medicine = new Medicine();

            if (!medicine.SetName(name))
            {
                MessageBox.Show("Invalid name");
                return;
            }

            if (!medicine.SetQuantity(quantity))
            {
                MessageBox.Show("Invalid quantity");
                return;
            }

            if (!medicine.SetCategory(category))
            {
                MessageBox.Show("Invalid category");
                return;
            }

            if (!medicine.SetDescription(description))
            {
                MessageBox.Show("Invalid description");
                return;
            }

            if (ObjectHandler.GetMedicineDL().AddMedicine(medicine))
            {
                MessageBox.Show("Medicine added successfully");
            }
            else
            {
                MessageBox.Show("Failed to add medicine");
            }

        }
    }
}
