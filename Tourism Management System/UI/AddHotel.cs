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
using Tourism_Management_System.Properties;
using TMS_LIbrary.DL.DLwithDB;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class AddHotel : Form
    {
        public AddHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string rooms = textBox2.Text;
            string capacity = textBox3.Text;

            Hotel hotel = new Hotel();

            if (!hotel.SetName(name))
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
         if( ObjectHandler.GetHotelDl().AddHotel(hotel))
            { 
                MessageBox.Show("Hotel added successfully");
            }
          else
            {
                MessageBox.Show("Hotel cannot be addedd");
            }
            
        }
    }
}
