using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Tourism_Management_System.Utilities
{
   public class Generic
    {
        public  static void CheckForEmptyTextBoxex(string username,string password,string id)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Invalid Username");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid Password");
                return;
            }
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid Id");
                return;
            }
        }
    }
}
