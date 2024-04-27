using Guna.UI2.WinForms;
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
    public partial class ViewPackage : Form
    {
        DataTable dt = new DataTable();
        public ViewPackage()
        {
            InitializeComponent();
        }

        private DataTable PopulateDataGridView(List<Package> packages)
        {
            dt.Rows.Clear();

            foreach (Package package in packages)
            {

                string name = package.GetPackageName();
                string destination = package.GetDestination();
                double price = package.GetPricePerperson();
                string duration = package.GetDuration();
                DateTime timeOfDeparture = package.GetTimeOfDeparture();
                DateTime timeOfArrival = package.GetTimeOfArrival();
                DateTime timeOfReturn = package.GetTimeOfReturn();
                Hotel h = package.GetHotel();

                dt.Rows.Add(name, destination, price, duration, timeOfDeparture, timeOfArrival, timeOfReturn, h.Getname());
            }
            return dt;
        }

        private void ViewPackage_Load(object sender, EventArgs e)
        {
            if (ameena == null || ameena.Columns.Count < 1)
            {
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Destination", typeof(string));
                dt.Columns.Add("Price", typeof(double));
                dt.Columns.Add("Duration", typeof(string));
                dt.Columns.Add("TimeOfDeparture", typeof(DateTime));
                dt.Columns.Add("TimeOfArrival", typeof(DateTime));
                dt.Columns.Add("TimeOfReturn", typeof(DateTime));
                dt.Columns.Add("HotelName", typeof(string));
                ameena.DataSource = dt;
                ameena.ReadOnly = true;
                List<Package> packages = ObjectHandler.GetPackageDL().ViewAllPackages();
                if (packages == null || packages.Count == 0)
                {
                    MessageBox.Show("Packages Unavailable");
                }
                else

                    // Populate the DataGridView with the list of packages
                    dt = PopulateDataGridView(packages);
                ameena.DataSource = dt;
            }

        }
        }


        //private DataTable PopulateDataGridView(List<Package> packages)
        //{
        //    dt.Rows.Clear();

        //    foreach (Package package in packages)
        //    {
                
        //        string name = package.GetPackageName();
        //        string destination = package.GetDestination();
        //        double price = package.GetPricePerperson();
        //        string duration = package.GetDuration();
        //        DateTime timeOfDeparture = package.GetTimeOfDeparture();
        //        DateTime timeOfArrival = package.GetTimeOfArrival();
        //        DateTime timeOfReturn = package.GetTimeOfReturn();
        //        Hotel h = package.GetHotel();

        //        dt.Rows.Add(name, destination, price, duration, timeOfDeparture, timeOfArrival, timeOfReturn,h.Getname());
        //    }
        //    return dt;
        //}


        //private void guna2Button2_Click(object sender, EventArgs e)
        //{
        //    List<Package> packages = ObjectHandler.GetPackageDL().ViewAllPackages();
        //    if (packages == null || packages.Count == 0)
        //    {
        //        MessageBox.Show("Packages Unavailable");
        //    }
        //    else

        //    // Populate the DataGridView with the list of packages
        //    dt = PopulateDataGridView(packages);
        //    ameena.DataSource = dt;
        //}

        //}
    }

