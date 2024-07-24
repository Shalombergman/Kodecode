using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClockWithSql
{
    public partial class frmlerning : Form
    {
        public frmlerning()
        {
            InitializeComponent();
        }

        private void frmlerning_Load(object sender, EventArgs e)
        {
            string sql = "select count(*) from Employes";
            SqlDataAdapter reader = DBConnection.runSQLAlllResult(sql);
            while (reader.Read())
            {
                //תביא לי את העמודה מסוג
                reader.getint32(0)
                reader.getint32(0)
                reader.getint32(0)
            }
            MessageBox.Show(res);
        }
    }
}
