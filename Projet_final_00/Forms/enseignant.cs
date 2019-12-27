using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_final_00.Forms
{
	public partial class enseignant : Form
	{
		public enseignant()
		{
			InitializeComponent();
            logo_txt.Visible = false;

			// emploi
			txt_nom_groupe.DataSource = SP_GET_GROUPE();
			txt_nom_groupe.DisplayMember = "NOM_GROUPE";
			txt_nom_groupe.ValueMember = "NOM_GROUPE";
			txt_niveau.DataSource = SP_GET_NIVEAU();
			txt_niveau.DisplayMember = "NIVEAU";
			txt_niveau.ValueMember = "NIVEAU";
		}
        public DataTable get_emploi_ens(string id)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_enseignant", MySqlDbType.VarChar, 20);
            param[0].Value = id;

            db.Open();
            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_EMPLOI_ENSEIGNANT", param);
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

		public DataTable SP_INFORMATION_ENSEIGNANT(string id)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_enseignant", MySqlDbType.VarChar, 20);
            param[0].Value = id;

            db.Open();
            DataTable dt = new DataTable();
            dt = db.SelectData("SP_INFORMATION_ENSEIGNANT", param);
            db.Close();
            return dt;
        }


		public DataTable get_liste_groupe(string groupe, String niveau, string specialite)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			MySqlParameter[] param = new MySqlParameter[3];

			param[0] = new MySqlParameter("@nom_groupe", MySqlDbType.VarChar, 50);
			param[0].Value = groupe;

			param[1] = new MySqlParameter("@niveau", MySqlDbType.Int16, 20);
			param[1].Value = niveau;

			param[2] = new MySqlParameter("@nom_spesialite", MySqlDbType.VarChar, 50);
			param[2].Value = specialite;

			DataTable dt = new DataTable();
			dt = db.SelectData("SP_LISTE_GROUPE", param);
			db.Close();
			return dt;
		}

		private void ens_exit_Click(object sender, EventArgs e)
		{
			home.get_home.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
			}
			else
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void menu_Click(object sender, EventArgs e)
		{
			if (menu_panel.Width == 250)
			{
				menu_panel.Width = 50;
				logo_01.Visible = false;
				logo_02.Visible = true;
				logo_txt.Visible = false;
			}
			else
			{
				menu_panel.Width = 250;
				logo_01.Visible = true;
				logo_02.Visible = false;
				logo_txt.Visible = true;
			}
		}

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            information.Visible = true;
            emploi.Visible = false;
            a_propose.Visible = false;
        }

        private void btn_clear_emploi_Click(object sender, EventArgs e)
        {
            txt_id_ens_emploi.Text = null;
            espace_affichage_emploi.DataSource = null;
			txt_nom_groupe.Text = null;
			txt_niveau.Text = null;
			txt_nom_specialite.Text = null;
		}

        private void btn_affichage_emploi_Click(object sender, EventArgs e)
        {
            try
            {
				if ((txt_nom_groupe.Text != "") && (txt_niveau.Text != "") && (txt_nom_specialite.Text != "") && (txt_id_ens_emploi.Text != string.Empty))
				{
					espace_affichage_emploi.DataSource = null;
					MessageBox.Show("S'il vous plaît choisire : la liste de groupe ou les information ", "Erreur Il est impossible de remplir toutes les cases en même temps ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if ((txt_id_ens_emploi.Text == "") && (txt_nom_groupe.Text == "") && (txt_niveau.Text == "") && (txt_nom_specialite.Text == ""))
					{
						espace_affichage_emploi.DataSource = null;
						MessageBox.Show("S'il vous plaît remplir votre choix ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if ((txt_nom_groupe.Text != "") && (txt_niveau.Text != "") && (txt_nom_specialite.Text != "") && (txt_id_ens_emploi.Text == ""))
						{
							espace_affichage_emploi.DataSource = null;
							DataTable dt = get_liste_groupe(txt_nom_groupe.Text, txt_niveau.Text, txt_nom_specialite.Text);
							espace_affichage_emploi.DataSource = dt;
						}
						if ((txt_id_ens_emploi.Text != "") && (txt_nom_groupe.Text == "") && (txt_niveau.Text == "") && (txt_nom_specialite.Text == ""))
						{
							espace_affichage_emploi.DataSource = null;
							espace_affichage_emploi.DataSource = get_emploi_ens(txt_id_ens_emploi.Text);
						}
					}
				}
            }
            catch
            {
                return;
            }
        }

		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			home.get_home.Show();
			this.Hide();
		}

        private void btn_affichage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_enseignant.Text == string.Empty)
                {
                    MessageBox.Show("S'il vous plaît entrer votre numéro identifiant  ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    espace_enseignant.DataSource = SP_INFORMATION_ENSEIGNANT(txt_id_enseignant.Text);
                }
            }
            catch
            {
                return;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            information.Visible = false;
            emploi.Visible = true;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            emploi.Visible = false;
            information.Visible = false;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            emploi.Visible = false;
            information.Visible = false;
            a_propose.Visible = true;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            information.Visible = true;
            emploi.Visible = false;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            information.Visible = false;
            emploi.Visible = true;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            emploi.Visible = false;
            information.Visible = false;
            a_propose.Visible = true;
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            home.get_home.Show();
            this.Hide();
        }

		private void txt_niveau_SelectedIndexChanged(object sender, EventArgs e)
		{
			string n = (txt_niveau.SelectedIndex + 1).ToString();
			txt_nom_specialite.DataSource = SP_GET_SPECIALITE(n);
			txt_nom_specialite.DisplayMember = "NOM_SPECIALITE";
			txt_nom_specialite.ValueMember = "NOM_SPECIALITE";
		}

        private void button3_Click(object sender, EventArgs e)
        {
            admin.Gestion_notes note = new admin.Gestion_notes();
            note.btn_imprimier.Visible = false;
            note.btn_supprimier_note.Visible = false;
            note.groupBox1.Visible = false;
            note.panel5.Width = 704;
            note.btn_modifier_stocke.Location = new Point(420,34);
            note.Width = 715;
            note.ShowDialog();
        }

		private void txt_réclamation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Déclaration dec = new Déclaration();
			dec.ShowDialog();
		}
	}
}
