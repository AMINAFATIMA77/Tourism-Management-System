using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TMS_LIbrary.BL;
using TMS_LIbrary.Utilities;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System.UI
{
    public partial class UpdatePackage : Form
    {
        public UpdatePackage()
        {
            InitializeComponent();
            DTPicker1.Format = DateTimePickerFormat.Time;
            DTPicker1.ShowUpDown = true;
            DTPicker2.Format = DateTimePickerFormat.Time;
            DTPicker2.ShowUpDown = true;
            DTPicker3.Format = DateTimePickerFormat.Time;
            DTPicker3.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime mydate = guna2DateTimePicker1.Value.Date + DTPicker1.Value.TimeOfDay;
            DateTime mydate2 = guna2DateTimePicker2.Value.Date + DTPicker2.Value.TimeOfDay;
            DateTime mydate3 = guna2DateTimePicker3.Value.Date + DTPicker3.Value.TimeOfDay;
            string updatedName = textBox1.Text;
            string hotelName = txtHotel.Text;
            string newName = textBox2.Text;
            string destination = textBox3.Text;
            string price = textBox4.Text;
            string duration = textBox5.Text;
            DateTime timeofdep = mydate;
            DateTime timeofarr = mydate2;
            DateTime timeofret = mydate3;

            Package package = new Package();
            if (!package.SetName(newName))
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

            if (ObjectHandler.GetPackageDL().UpdatePackage(updatedName, package))
            {
                MessageBox.Show("Package updated successfully");
            }
            else
            {
                MessageBox.Show("Package could not be updated");
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string updatedName = textBox1.Text;
            if(string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            Validations v1 = new Validations();
            bool ans = v1.PackageExists(updatedName);
            if (!ans)
            {
                MessageBox.Show("Package with this name do no exist.Please ReEnter the name of package");
            }
            else
            {
                MessageBox.Show("Package exists.Please carry on with your updation");
            }
        }
    }
}
