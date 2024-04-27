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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tourism_Management_System.UI
{
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name =  guna2TextBox2.Text;
            string quantity= guna2TextBox1.Text;
            string category= guna2TextBox3.Text;
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

            if (!food.SetName(name))
            {
                MessageBox.Show("Invalid Name");
                return;
            }

            if(!food.SetQuantity(quantity)) {

                MessageBox.Show("Invalid Quantity");
                return;

            }

            if(!food.SetCategory(category))
            {
                MessageBox.Show("Invalid Category");
                return;
            }

            if(!food.SetorgOrInOrg(booleanValueOfType))
            {
                MessageBox.Show("Invalid Type of Food");
                return;
            }

            if(!food.SetvegOrNonveg(booleanValueOfPreference)) {

                MessageBox.Show("Invalid Preference of Food");
                return;
            }
            if(ObjectHandler.GetFoodDL().AddFood(food))
            {
                MessageBox.Show("Food added successfully");
            }
            else
            {
                MessageBox.Show("Food couldn't be added");
            }
        }
    }
}
