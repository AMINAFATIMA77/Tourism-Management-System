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
    public partial class UpdateMedicine : Form
    {
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string updatedName = guna2TextBox1.Text;
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
            }
            else
            {
                MessageBox.Show("Medicine exists.Please carry on with your updation");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string updatedName = guna2TextBox5.Text;
            string newname = guna2TextBox2.Text;
            string quantity = guna2TextBox1.Text;
            string category = guna2TextBox3.Text;
            string description = guna2TextBox4.Text;

            Medicine medicine = new Medicine();

            if (!medicine.SetName(newname))
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

            if (ObjectHandler.GetMedicineDL().UpdateMedicine(updatedName,medicine))
            {
                MessageBox.Show("Medicine updated successfully");
            }
            else
            {
                MessageBox.Show("Failed to update medicine");
            }

        }
    }
    }

