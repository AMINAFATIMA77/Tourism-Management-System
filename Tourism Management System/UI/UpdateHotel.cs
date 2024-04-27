using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.BL;
using Tourism_Management_System.Utilities;
using TMS_LIbrary.Utilities;
using System.Xml.Linq;

namespace Tourism_Management_System.UI
{
    public partial class UpdateHotel : Form
    {
        public UpdateHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatedName=textBox1.Text;
            string newName=textBox4.Text;
            string rooms=textBox2.Text;
           string capacity=textBox3.Text;
            Hotel hotel = new Hotel();
            if (!hotel.SetName(newName))
            {
                MessageBox.Show("Invalid name of hotel");
                return;
            }

            if (!hotel.SetNumberOfRooms(rooms))
            {
                MessageBox.Show("Invalid number of rooms");
                return;
            }

            if (!hotel.SetCapacityOfOneRoom(capacity))
            {
                MessageBox.Show("Invalid capacity");
                return;
            }
            if ( ObjectHandler.GetHotelDl().UpdateHotel(updatedName, hotel))
            {
                MessageBox.Show("Hotel updated successfully");
            }
            else
            {
                MessageBox.Show("Hotel could not be updated");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updatedName = textBox1.Text;
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
          
            if (!ObjectHandler.GetHotelDl().HotelExists(updatedName))
            {
                MessageBox.Show("Hotel with this name do no exist.Please ReEnter the name of hotel");
            }
            else
            {
                MessageBox.Show("Hotel exists.Please carry on");
            }

        }
    }
}
