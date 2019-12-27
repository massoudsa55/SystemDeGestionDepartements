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

namespace Projet_final_00.Forms
{
    public partial class etudiant : Form
    {
        public etudiant()
        {
            InitializeComponent();

			// emploi
			txt_nom_groupe_emploi.DataSource = SP_GET_GROUPE();
            txt_nom_groupe_emploi.DisplayMember = "NOM_GROUPE";
            txt_nom_groupe_emploi.ValueMember = "NOM_GROUPE";
            txt_niveau_emploi.DataSource = SP_GET_NIVEAU();
            txt_niveau_emploi.DisplayMember = "NIVEAU";
            txt_niveau_emploi.ValueMember = "NIVEAU";
            // information
            txt_nom_groupe.DataSource = SP_GET_GROUPE();
            txt_nom_groupe.DisplayMember = "NOM_GROUPE";
            txt_nom_groupe.ValueMember = "NOM_GROUPE";
            txt_niveau.DataSource = SP_GET_NIVEAU();
            txt_niveau.DisplayMember = "NIVEAU";
            txt_niveau.ValueMember = "NIVEAU";

			calcul.Visible = false;

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
        public DataTable get_emploi_etudiant(string groupe, string niveau, string specialite)
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
            dt = db.SelectData("SP_GET_EMPLOI_ETUDIANT", param);
            db.Close();
            return dt;
        }
        public DataTable get_information_etudiant(string id)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_INFORMATION_ETUDIANT", param);
            db.Close();
            return dt;
        }
        public DataTable get_note_etudiant(string id)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_NOTE", param);
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

        public DataTable SP_GET_GROUPE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();


            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_GROUPE", null);
            db.Close();
            return dt;
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
			home.get_home.Show();
			this.Hide();
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 250)
            {
                panel_menu.Width = 50;
                logo1.Visible = false;
                logo2.Visible = true;
                logo_text.Visible = false;
            }
            else
            {
                panel_menu.Width = 250;
                logo1.Visible = true;
                logo2.Visible = false;
                logo_text.Visible = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            calcul.Visible = false;
            emploi.Visible = false;
            information.Visible = false;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            calcul.Visible = false; 
            emploi.Visible = false;
            information.Visible = true;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            calcul.Visible = false;
            emploi.Visible = true;
            information.Visible = false;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            information.Visible = false;
            emploi.Visible = false;
            calcul.Visible = true;
            a_propose.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            calcul.Visible = false;
            emploi.Visible = false;
            information.Visible = false;
            a_propose.Visible = true;
        }

        private void btn_liste_groupe_Click(object sender, EventArgs e)
        {
            if ((txt_nom_groupe.Text != "") && (txt_niveau.Text != "") && (txt_nom_specialite.Text != "") && (txt_id_etudiant.Text != ""))
            {
                espace_daffichage.DataSource = null;
                MessageBox.Show("S'il vous plaît choisire : la liste de groupe ou les information ", "Erreur Il est impossible de remplir toutes les cases en même temps ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((txt_id_etudiant.Text == "") && (txt_nom_groupe.Text == "") && (txt_niveau.Text == "") && (txt_nom_specialite.Text == ""))
                {
                    espace_daffichage.DataSource = null;
                    MessageBox.Show("S'il vous plaît remplir votre choix ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((txt_nom_groupe.Text != "") && (txt_niveau.Text != "") && (txt_nom_specialite.Text != "") && (txt_id_etudiant.Text == ""))
                    {
                        espace_daffichage.DataSource = null;
                        DataTable dt = get_liste_groupe(txt_nom_groupe.Text, txt_niveau.Text, txt_nom_specialite.Text);
                        espace_daffichage.DataSource = dt;
                    }
                    if ((txt_id_etudiant.Text != "") && (txt_nom_groupe.Text == "") && (txt_niveau.Text == "") && (txt_nom_specialite.Text == ""))
                    {
                        espace_daffichage.DataSource = null;
                        DataTable dt1 = get_information_etudiant(txt_id_etudiant.Text);
                        espace_daffichage.DataSource = dt1;
                    }
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            espace_daffichage.DataSource = "";
            txt_id_etudiant.Clear();
            txt_nom_groupe.Text = null;
            txt_niveau.Text=null;
            txt_nom_specialite.Text = null;
        }

        private void btn_afficher_emploi_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_nom_groupe_emploi.Text != "") && (txt_niveau_emploi.Text != "") && (txt_nom_specialite_emploi.Text != "") && (txt_pour_note.Text != ""))
                {
                    espace_daffichage.DataSource = null;
                    MessageBox.Show("S'il vous plaît choisire : Lemploi ou les notes ", "Erreur Il est impossible de remplir toutes les cases en même temps ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if ((txt_nom_groupe_emploi.Text == "") && (txt_niveau_emploi.Text == "") && (txt_nom_specialite_emploi.Text == "") && (txt_pour_note.Text == ""))
                    {
                        MessageBox.Show("S'il vous plaît remplir votre choix  ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if ((txt_nom_groupe_emploi.Text != "") && (txt_niveau_emploi.Text != "") && (txt_nom_specialite_emploi.Text != "") && (txt_pour_note.Text == ""))
                        {
                            espace_emploi.DataSource = null;
                            DataTable dt = get_emploi_etudiant(txt_nom_groupe_emploi.Text, txt_niveau_emploi.Text, txt_nom_specialite_emploi.Text);
                            espace_emploi.DataSource = dt;
                        }
                        else
                        {
                            if ((txt_nom_groupe_emploi.Text == "") && (txt_niveau_emploi.Text == "") && (txt_nom_specialite_emploi.Text == "") && (txt_pour_note.Text != ""))
                            {
                                espace_emploi.DataSource = null;
                                DataTable dt = get_note_etudiant(txt_pour_note.Text);
                                espace_emploi.DataSource = dt;

                            }
                        }

                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void btn_clear_emploi_Click(object sender, EventArgs e)
        {
            espace_emploi.DataSource = "";
            txt_nom_groupe_emploi.Text = null;
            txt_niveau_emploi.Text = null;
            txt_nom_specialite_emploi.Text = null;
            txt_pour_note.Text = null;
        }

        private void emploi_Paint(object sender, PaintEventArgs e)
        {

        }

		private void bunifuFlatButton6_Click(object sender, EventArgs e)
		{
			home.get_home.Show();
			this.Hide();
		}

        private void txt_niveau_emploi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = (txt_niveau_emploi.SelectedIndex + 1).ToString();
            txt_nom_specialite_emploi.DataSource = SP_GET_SPECIALITE(n);
            txt_nom_specialite_emploi.DisplayMember = "NOM_SPECIALITE";
            txt_nom_specialite_emploi.ValueMember = "NOM_SPECIALITE";
        }

        private void txt_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = (txt_niveau.SelectedIndex + 1).ToString();
            txt_nom_specialite.DataSource = SP_GET_SPECIALITE(n);
            txt_nom_specialite.DisplayMember = "NOM_SPECIALITE";
            txt_nom_specialite.ValueMember = "NOM_SPECIALITE";
        }

		private void button6_Click(object sender, EventArgs e)
		{
			if ((niv2.Checked == false && niv3.Checked == false) || (s1.Checked == false && s2.Checked == false))
			{
				MessageBox.Show("S'il vous plaît choisir la semester et choisir le niveau ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				niv2.Checked = false;
				niv3.Checked = false;
				s1.Checked = false;
				s2.Checked = false;
			}
			else
			{
				if (niv2.Checked == true)
				{
					if (s1.Checked == true)
					{
						Forms.moyennes.Info_S3 info_s3 = new moyennes.Info_S3();
						info_s3.ShowDialog();
						niv2.Checked = false;
						niv3.Checked = false;
						s1.Checked = false;
						s2.Checked = false;
					}
					else
					{
						if (s2.Checked == true)
						{
							Forms.moyennes.Info_S4 info_s4 = new moyennes.Info_S4();
							info_s4.ShowDialog();
							niv2.Checked = false;
							niv3.Checked = false;
							s1.Checked = false;
							s2.Checked = false;
						}
					}
				}
				else
				{
					if (niv3.Checked == true)
					{
						if (s1.Checked == true)
						{
							Forms.moyennes.Info_S5 info_s5 = new moyennes.Info_S5();
							info_s5.ShowDialog();
							niv2.Checked = false;
							niv3.Checked = false;
							s1.Checked = false;
							s2.Checked = false;
						}
						else
						{
							if (s2.Checked == true)
							{
								Forms.moyennes.Info_S6 info_s6 = new moyennes.Info_S6();
								info_s6.ShowDialog();
								niv2.Checked = false;
								niv3.Checked = false;
								s1.Checked = false;
								s2.Checked = false;
							}
						}
					}
				}

			}
		}

		private void btn_niv1_Click(object sender, EventArgs e)
		{
			if (niv2.Checked == true || niv3.Checked == true)
			{
				MessageBox.Show("S'il vous plaît choisier seulement le semester , vous ne pouvez pas choisir le niveau dans ce cas", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				niv2.Checked = false;
				niv3.Checked = false;
				s1.Checked = false;
				s2.Checked = false;
			}
			else
			{
				if (s1.Checked == false && s2.Checked == false)
				{
					MessageBox.Show("S'il vous plaît choisier le semester ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (s1.Checked == true)
					{
						Forms.moyennes.MI_S1 mi_s1 = new moyennes.MI_S1();
						mi_s1.ShowDialog();
						niv2.Checked = false;
						niv3.Checked = false;
						s1.Checked = false;
						s2.Checked = false;
					}
					else
					{
						if (s2.Checked == true)
						{
							Forms.moyennes.MI_S2 mi_s2 = new moyennes.MI_S2();
							mi_s2.ShowDialog();
							niv2.Checked = false;
							niv3.Checked = false;
							s1.Checked = false;
							s2.Checked = false;
						}
					}
				}
			}
		}

		private void btn_math_Click(object sender, EventArgs e)
		{
			if ((niv2.Checked == false && niv3.Checked == false) || (s1.Checked == false && s2.Checked == false))
			{
				MessageBox.Show("s'il vous plaît choisir le semester et choisir le niveau à la fois ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				niv2.Checked = false;
				niv3.Checked = false;
				s1.Checked = false;
				s2.Checked = false;
			}
			else
			{
				if (niv2.Checked == true)
				{
					if (s1.Checked == true)
					{
						Forms.moyennes.Math_S3 math_s3 = new moyennes.Math_S3();
						math_s3.ShowDialog();
						niv2.Checked = false;
						niv3.Checked = false;
						s1.Checked = false;
						s2.Checked = false;
					}
					else
					{
						if (s2.Checked == true)
						{
							Forms.moyennes.Math_S4 math_s4 = new moyennes.Math_S4();
							math_s4.ShowDialog();
							niv2.Checked = false;
							niv3.Checked = false;
							s1.Checked = false;
							s2.Checked = false;
						}
					}
				}
				else
				{
					if (niv3.Checked == true)
					{
						if (s1.Checked == true)
						{
							Forms.moyennes.Math_S5 math_s5 = new moyennes.Math_S5();
							math_s5.ShowDialog();
							niv2.Checked = false;
							niv3.Checked = false;
							s1.Checked = false;
							s2.Checked = false;
						}
						else
						{
							if (s2.Checked == true)
							{
								Forms.moyennes.Math_S6 math_s6 = new moyennes.Math_S6();
								math_s6.ShowDialog();
								niv2.Checked = false;
								niv3.Checked = false;
								s1.Checked = false;
								s2.Checked = false;
							}
						}
					}
				}

			}
		}

		private void txt_réclamation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Déclaration dec = new Déclaration();
			dec.ShowDialog();
		}
	}
}
