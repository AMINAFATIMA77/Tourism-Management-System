using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_Management_System.UI
{
    public partial class PackageManager : Form
    {
        public PackageManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddPackage();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePackage();
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new DeletePackage();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form= new ViewPackagebyName();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ViewPackage();
            form.Show();
        }
    }
}
