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
using TMS_LIbrary.DL.DLwithDB;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
            DTPicker1.Format = DateTimePickerFormat.Time;
            DTPicker1.ShowUpDown = true;
            DTPicker2.Format = DateTimePickerFormat.Time;
            DTPicker2.ShowUpDown = true;
            DTPicker3.Format = DateTimePickerFormat.Time;
            DTPicker3.ShowUpDown = true;



        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DateTime mydate = guna2DateTimePicker1.Value.Date + DTPicker1.Value.TimeOfDay;
            DateTime mydate2= guna2DateTimePicker2.Value.Date + DTPicker2.Value.TimeOfDay;
            DateTime mydate3 = guna2DateTimePicker3.Value.Date + DTPicker3.Value.TimeOfDay;

            string name = textBox1.Text;
            string hotelName=txtHotel.Text;
            string destination = textBox3.Text;
            string price =textBox8.Text;
            string duration = textBox4.Text;
            DateTime timeofdep = mydate;
            DateTime timeofarr = mydate2;
            DateTime timeofret= mydate3;
            Package package = new Package();
            if (!package.SetName(name))
            {
                MessageBox.Show("Invalid name of package");
                return;
            }
            if (!ObjectHandler.GetHotelDl().HotelExists(hotelName))
            {
                MessageBox.Show("Hotel do Not exist");
                return;
                
            }
            Hotel hotel = ObjectHandler.GetHotelDl().ViewHotelByName(hotelName);
            package.SetHotel(hotel);
          
            if (!package.SetDestination(destination))
            {
                MessageBox.Show("Invalid destination");
                return;
            }
            if (!package.SetPrice(price))
            {
                MessageBox.Show("Invalid Price of Package");
                return;
            }
            
            if (!package.SetDuration(duration))
            {
                MessageBox.Show("Invalid duration");
                return;
            }
           
            if (!package.SetTimeOfDeparture(timeofdep))
            {
                MessageBox.Show("Invalid Time of Departure");
                return;
            }

            if (!package.SetTimeOfArrival(timeofarr))
            {
                MessageBox.Show("Invalid Time of Arrival");
                return;
            }
            if (!package.SetTimeOfReturn(timeofret))
            {
                MessageBox.Show("Invalid Time of Return");
                return;
            }


            if (ObjectHandler.GetPackageDL().AddPackage(package))
            {
                MessageBox.Show("Package addedd successfully");
            }
            else
            {
                MessageBox.Show("Package could not be added");
            }

        }

        private void AddPackage_Load(object sender, EventArgs e)
        {

        }
    }
}
