using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00.Forms.admin
{
    public partial class Get_Emploi : Form
    {
        public Get_Emploi()
        {
            InitializeComponent();
            dgv_get_emploi.DataSource = SP_GET_EMPLOI();
        }

        public DataTable SP_GET_EMPLOI()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_EMPLOI", null);
            db.Close();
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_get_emploi_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
