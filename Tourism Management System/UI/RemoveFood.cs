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
    public partial class RemoveFood : Form
    {
        public RemoveFood()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string updatedName = guna2TextBox4.Text;
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            Validations v1 = new Validations();
            bool ans = v1.FoodExists(updatedName);
            if (!ans)
            {
                MessageBox.Show("Food with this name do no exist.Please ReEnter the name of food");
            }
            else
            {
                MessageBox.Show("Food exists.Please carry on with your Deletion");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string foodName = guna2TextBox4.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Invalid Name of Food.Please ReEnter");
                return;
            }
            if (ObjectHandler.GetFoodDL().DeleteFood(foodName))
            {
                MessageBox.Show("Food Deleted successfully");
            }
            else
            {
                MessageBox.Show("Food could not be deleted");
            }

        }
    }
}
