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
    public partial class ViewHotels : Form
    {
        static DataTable dt=new DataTable();
        public ViewHotels()
        {
            InitializeComponent();
        }


      

        private DataTable PopulateDataGridView(List<Hotel> hotels)
        {
            dt.Rows.Clear();

            foreach (Hotel hotel in hotels)
            {
                // Retrieve property values directly
                string name = hotel.Getname();
               double numberOfRooms = hotel.GetNumberOfRooms();
                double capacityOfOneRoom = hotel.GetCapacityOfOneRoom();

                // Add a row to the DataGridView with property values
                dt.Rows.Add(name, numberOfRooms, capacityOfOneRoom);
            }
            return dt;
        }


        private void ViewHotels_Load(object sender, EventArgs e)
        {
            if (dt == null || dt.Columns.Count < 1)
            {
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Number of Rooms", typeof(int));
                dt.Columns.Add("Capacity of One Room", typeof(int));
                ameena.DataSource = dt;
                ameena.ReadOnly = true;
            }
        }

        private void FetchData_Click(object sender, EventArgs e)
        {
            List<Hotel> hotels = ObjectHandler.GetHotelDl().ViewAllHotels();
            if (hotels == null || hotels.Count == 0)
            {
                MessageBox.Show("Hotels Unavailable");
            }
            else
            {
                // Populate the DataGridView with the list of hotels
                dt = PopulateDataGridView(hotels);
                ameena.DataSource = dt;
            }
        }
    }
}
