using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_final_00.Forms.admin
{
    public partial class Get_Note : Form
    {
        public Get_Note()
        {
            InitializeComponent();
            txt_niveau.DataSource = SP_GET_NIVEAU();
            txt_niveau.DisplayMember = "NIVEAU";
            txt_niveau.ValueMember = "NIVEAU";
        }
        public DataTable SP_GET_NIVEAU()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();


            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_NIVEAU", null);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_SPECIALITE(string niv)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@niveau", MySqlDbType.Int16, 20);
            param[0].Value = niv;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_SPECIALITE", param);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_GROUPE()
        { 
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
          

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_GROUPE", null);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_NOTE_ADMIN(string N, string S, string G)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@niveau", MySqlDbType.Int16, 20);
            param[0].Value = N;

            param[1] = new MySqlParameter("@nom_spesialite", MySqlDbType.VarChar, 50);
            param[1].Value = S;

            param[2] = new MySqlParameter("@groupe", MySqlDbType.VarChar, 50);
            param[2].Value = G;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_NOTE_ADMIN", param);
            db.Close();
            return dt;
        }

        private void txt_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = (txt_niveau.SelectedIndex+1).ToString();
            txt_specialit.DataSource = SP_GET_SPECIALITE(n);
            txt_specialit.DisplayMember = "NOM_SPECIALITE";
            txt_specialit.ValueMember = "NOM_SPECIALITE";
        }

        private void txt_specialit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_groupe.DataSource = SP_GET_GROUPE();
            txt_groupe.DisplayMember = "NOM_GROUPE";
            txt_groupe.ValueMember = "NOM_GROUPE";
        }

        private void txt_groupe_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable t = new DataTable();
            t.Clear();
            string N = txt_niveau.Text;
            string S = txt_specialit.Text;
            string G = txt_groupe.Text;
            t = SP_GET_NOTE_ADMIN(N, S, G);
            dgv_note.DataSource = t;
        }

        private void dgv_note_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		
    }
}
