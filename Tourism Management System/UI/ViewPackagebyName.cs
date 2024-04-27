using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_LIbrary.BL;
using Tourism_Management_System.Utilities;

namespace Tourism_Management_System
{
    public partial class ViewPackagebyName : Form
    {
         static DataTable dt = new DataTable();
        public ViewPackagebyName()
        {
            InitializeComponent();
        }

        private void Bosom_Load(object sender, EventArgs e)
        {
            if (dt == null || dt.Columns.Count < 1)
            {
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Destination", typeof(string));
                dt.Columns.Add("Price", typeof(double));
                dt.Columns.Add("Duration", typeof(string));
                dt.Columns.Add("TimeOfDeparture", typeof(DateTime));
                dt.Columns.Add("TimeOfArrival", typeof(DateTime));
                dt.Columns.Add("TimeOfReturn", typeof(DateTime));
                dt.Columns.Add("HotelName", typeof(string));
               lol.DataSource = dt;
             
                // Increase the height of rows
               lol.RowTemplate.Height = 50; 
                // Set row height
            }
        }

        public DataTable PopulateDataGridView(Package package)
        {
            dt.Rows.Clear();

            string name = package.GetPackageName();
            string destination = package.GetDestination();
            double price = package.GetPricePerperson();
            string duration = package.GetDuration();
            DateTime timeOfDeparture = package.GetTimeOfDeparture();
            DateTime timeOfArrival = package.GetTimeOfArrival();
            DateTime timeOfReturn = package.GetTimeOfReturn();
            Hotel h = package.GetHotel();



            if (package != null)
            {
                dt.Rows.Add(name, destination, price, duration, timeOfDeparture, timeOfArrival, timeOfReturn, h.Getname());
            }
            return dt;

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string name = guna2TextBox1.Text;
            Package package = ObjectHandler.GetPackageDL().ViewPackageByName(name);
            if (package == null)
            {
                MessageBox.Show("Package Unavailable");
            }
            else
            {
                dt = PopulateDataGridView(package);
                lol.DataSource = dt;
            }


        }


    }
}
