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
	public partial class Confiduration : Form
	{
		public Confiduration()
		{
			InitializeComponent();
			txt_type.DataSource = SP_GET_TYPE_USER();
			txt_type.DisplayMember = "ID_TYPE_USER";
			txt_type.ValueMember = "ID_TYPE_USER";
		}

		public DataTable SP_GET_ID_USER( string TYPE_USER)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			DataTable dt = new DataTable();
			MySqlParameter[] param = new MySqlParameter[1];

			param[0] = new MySqlParameter("@type_user", MySqlDbType.VarChar, 50);
			param[0].Value = TYPE_USER;

			dt = db.SelectData("SP_GET_ID_USER", param);
			db.Close();
			return dt;
		}

		public DataTable SP_GET_PASSWORD(string TYPE_USER)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			DataTable dt = new DataTable();

			
			MySqlParameter[] param = new MySqlParameter[1];

			param[0] = new MySqlParameter("@type_user", MySqlDbType.VarChar, 50);
			param[0].Value = TYPE_USER;

			dt = db.SelectData("SP_GET_PASSWORD", param);
			db.Close();
			return dt;
		}

		public DataTable SP_GET_TYPE_USER()
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();


			DataTable dt = new DataTable();
			dt = db.SelectData("SP_GET_TYPE_USER", null);
			db.Close();
			return dt;
		}

		public void SP_EDIT_USER_PASSWORD(string ID_USER ,string USER_NAM, string TYPE_USER, string PASS)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			db.Open();
			MySqlParameter[] param = new MySqlParameter[4];

			param[0] = new MySqlParameter("@id", MySqlDbType.Int32, 20);
			param[0].Value = ID_USER;

			param[1] = new MySqlParameter("@nom_user", MySqlDbType.VarChar, 50);
			param[1].Value = USER_NAM;

			param[2] = new MySqlParameter("@type_user", MySqlDbType.VarChar, 50);
			param[2].Value = TYPE_USER;

			param[3] = new MySqlParameter("@password", MySqlDbType.VarChar, 50);
			param[3].Value = PASS;

			db.ExecuteCommand("SP_EDIT_USER_PASSWORD", param);
			db.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            this.Close();
		}
		
		private void conferm(object sender, EventArgs e)
		{
			if (txt_nouv_mot_passe.Text != string.Empty && txt_conferm_mot_passe.Text != string.Empty &&
				txt_nouv_mot_passe.Text != txt_conferm_mot_passe.Text )
			{
				MessageBox.Show("S'il vous plaît veuillez confirmer le mot de passe entré ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_conferm_mot_passe.Focus();
				txt_conferm_mot_passe.SelectionStart = 0;
				txt_conferm_mot_passe.SelectionLength = txt_conferm_mot_passe.TextLength;
			}
		}

		private void annule(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			DataTable d = new DataTable();
			d = SP_GET_PASSWORD(Convert.ToString(txt_type.SelectedValue));
			string password = d.Rows[0][0].ToString();

			if (txt_nom_user.Text ==string.Empty || txt_mot_passe.Text == string.Empty || txt_nouv_mot_passe.Text == string.Empty ||
				txt_conferm_mot_passe.Text == string.Empty || txt_type.Text == string.Empty)
			{
				MessageBox.Show("S'il vous plaît remplire tout les informations", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (txt_mot_passe.Text != password)
				{
					MessageBox.Show("Le mot de passe ancien est incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_mot_passe.Focus();
					txt_mot_passe.SelectionStart = 0;
					txt_mot_passe.SelectionLength = txt_mot_passe.TextLength;
				}
				else
				{
					try
					{
						DataTable data = new DataTable();
						data = SP_GET_ID_USER(Convert.ToString(txt_type.SelectedValue));
						string id = data.Rows[0][0].ToString();
						SP_EDIT_USER_PASSWORD(id , txt_nom_user.Text, Convert.ToString(txt_type.SelectedValue), txt_conferm_mot_passe.Text);
						MessageBox.Show("Configuration succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_nom_user.Clear();
						txt_mot_passe.Clear();
						txt_nouv_mot_passe.Clear();
						txt_conferm_mot_passe.Clear();
						txt_type.Text = null;
						txt_nom_user.Focus();
					}
					catch
					{
						return;
					}
				}
			}
		}

		private void show_CheckedChanged(object sender, EventArgs e)
		{
			if (show.Checked == true)
			{
				txt_mot_passe.UseSystemPasswordChar = false;
				txt_nouv_mot_passe.UseSystemPasswordChar = false;
				txt_conferm_mot_passe.UseSystemPasswordChar = false;
			}
			else
			{
				txt_mot_passe.UseSystemPasswordChar = true;
				txt_nouv_mot_passe.UseSystemPasswordChar = true;
				txt_conferm_mot_passe.UseSystemPasswordChar = true;
			}
		}
	}
}
