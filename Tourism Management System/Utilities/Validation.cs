using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;
using Tourism_Management_System.UI;

namespace Tourism_Management_System.Utilities
{
  
    
        public class Validation : AddPackage
        {
            public void AttachValidationHandlers()
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Validating += TextBox_Validating;
                    }
                }
            }

            public void TextBox_Validating(object sender, CancelEventArgs e)
            {
                TextBox textBox = (TextBox)sender;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"TextBox cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
}
