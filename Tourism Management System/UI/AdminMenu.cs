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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new DeletePManager();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddPManager();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form=new AddPManager();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePManager();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new DeletePManager();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePManager();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new DeletePManager();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new AddPManager();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePManager();
            form.Show();
        }
    }
}
