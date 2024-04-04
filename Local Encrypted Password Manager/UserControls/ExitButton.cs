using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Encrypted_Password_Manager.UserControls
{
    public partial class ExitButton : UserControl
    {
        public ExitButton()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }
    }
}
