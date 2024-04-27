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
    public partial class ViewHotelsByName : Form
    {
        DataTable dt=new DataTable();
        public ViewHotelsByName()
        {
            InitializeComponent();
        }

        public DataTable PopulateDataGridView(Hotel hotel)
        {
            dt.Rows.Clear();

            // Retrieve property values
            string name = hotel.Getname();
            double numberOfRooms = hotel.GetNumberOfRooms();
            double capacityOfOneRoom = hotel.GetCapacityOfOneRoom();

            // Add a row to the DataTable with property values
            if (hotel != null)
            {
                dt.Rows.Add(name, numberOfRooms, capacityOfOneRoom);
            }
            return dt;
        }


        private void FetchData_Click(object sender, EventArgs e)
        {
            string name = guna2TextBox1.Text;

            Hotel hotel = ObjectHandler.GetHotelDl().ViewHotelByName(name);
            if (hotel == null)
            {
                MessageBox.Show("Package Unavailable");
            }
            else
            {
                dt = PopulateDataGridView(hotel);
                ameena.DataSource = dt;
            }
        }

        public void ViewHotels_Load(object sender, EventArgs e)
        {
            if (ameena == null || ameena.Columns.Count < 1)
            {
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Number of Rooms", typeof(double));
                dt.Columns.Add("Capacity of One Room", typeof(double));

                // Set the DataGridView's DataSource to the DataTable
                ameena.DataSource = dt;
               // PopulateDataGridView();

                // Make the DataGridView read-only
                ameena.ReadOnly = true;
            }

        }

       
    }
}
