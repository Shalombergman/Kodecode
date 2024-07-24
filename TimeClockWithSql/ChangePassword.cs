using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClockWithSql
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

        }

        private void ButConfirm_Click(object sender, EventArgs e)
        {
            string res = EmployeeManager.ChangePassword(TxtId.Text, TxtOldPassword.Text, TxtNewPassword.Text, TxtConfirmPassword.Text);
            MessageBox.Show(res);

        }
    }
}
