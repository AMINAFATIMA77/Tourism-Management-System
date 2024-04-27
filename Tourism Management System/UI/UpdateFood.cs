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
    public partial class UpdateFood : Form
    {
        public UpdateFood()
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
                MessageBox.Show("Food exists.Please carry on with your updation");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string oldName=guna2TextBox4.Text;
            string newname = guna2TextBox2.Text;
            string quantity = guna2TextBox1.Text;
            string category = guna2TextBox3.Text;
            string selectedValue1 = guna2ComboBox1.SelectedItem.ToString();
            bool booleanValueOfType;
            if (selectedValue1 == "Organic")
            {
                booleanValueOfType = true;
            }
            else
            {
                booleanValueOfType = false;
            }
            string selectedValue2 = guna2ComboBox3.SelectedItem.ToString();
            bool booleanValueOfPreference;
            if (selectedValue2 == "Vegetarian")
            {
                booleanValueOfPreference = true;
            }
            else
            {
                booleanValueOfPreference = false;
            }
            Food food = new Food();

            if (!food.SetName(newname))
            {
                MessageBox.Show("Invalid Name");
                return;
            }

            if (!food.SetQuantity(quantity))
            {

                MessageBox.Show("Invalid Quantity");
                return;

            }

            if (!food.SetCategory(category))
            {
                MessageBox.Show("Invalid Category");
                return;
            }

            if (!food.SetorgOrInOrg(booleanValueOfType))
            {
                MessageBox.Show("Invalid Type of Food");
                return;
            }

            if (!food.SetvegOrNonveg(booleanValueOfPreference))
            {

                MessageBox.Show("Invalid Preference of Food");
                return;
            }
            if (ObjectHandler.GetFoodDL().UpdateFood(oldName,food))
            {
                MessageBox.Show("Food updated successfully");
            }
            else
            {
                MessageBox.Show("Food couldn't be updated");
            }
        }
    }
}
    
