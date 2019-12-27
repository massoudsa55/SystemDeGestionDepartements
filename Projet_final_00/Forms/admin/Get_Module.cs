using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00
{
    public partial class Get_Module : Form
    {
        public Get_Module()
        {
            InitializeComponent();
            dgv_get_module.DataSource = SP_GET_MODULE();
        }

        public DataTable SP_GET_MODULE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_MODULE", null);
            db.Close();
            return dt;
        }

        private void dgv_get_module_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		
    }
}
