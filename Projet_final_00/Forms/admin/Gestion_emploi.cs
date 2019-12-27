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
using System.Net.Mail;
using System.Net;

namespace Projet_final_00.Forms.admin
{
	public partial class Gestion_emploi : Form
	{
        DataTable dt = new DataTable();
        void CreateTable()
        {
            dt.Columns.Add("ID Emploi");
            dt.Columns.Add("ID Specialite");
            dt.Columns.Add("ID Groupe");
            dt.Columns.Add("ID Enseignant");
            dt.Columns.Add("ID Module");
            dt.Columns.Add("Salle");
            dt.Columns.Add("Jour");
            dt.Columns.Add("Heur Debut");
            dt.Columns.Add("Heur Fin");
            affichage_emploi.DataSource = dt;
        }
        void ResizeDataGradeView()
        {
            this.affichage_emploi.RowHeadersWidth = 57;
            this.affichage_emploi.Columns[0].FillWeight = 102;
            this.affichage_emploi.Columns[1].FillWeight = 102;
            this.affichage_emploi.Columns[2].FillWeight = 102;
            this.affichage_emploi.Columns[3].FillWeight = 102;
            this.affichage_emploi.Columns[4].FillWeight = 102;
            this.affichage_emploi.Columns[5].FillWeight = 102;
            this.affichage_emploi.Columns[6].FillWeight = 102;
            this.affichage_emploi.Columns[7].FillWeight = 102;
            this.affichage_emploi.Columns[8].FillWeight = 101;
        }
        void ClearBoxes()
        {
            txt_id_emp.Clear();
            txt_specialite.Text = null;
            txt_groupe.Text = null;
            txt_id_ens.Clear();
            txt_id_mod.Clear();
            txt_salle.Text = null;
            txt_joure.Clear();
            txt_heur_debut.Text = null;
            txt_heur_fin.Text = null;
            btn_choisire.Focus();
        }
        public Gestion_emploi()
		{
			InitializeComponent();
            CreateTable();
            ResizeDataGradeView();
            txt_specialite.Text = null;
            txt_groupe.Text = null;
            txt_salle.Text = null;
            txt_specialite.DataSource = SP_GET_ID_SPECIALITE();
            txt_specialite.DisplayMember = "ID_SPECIALITE";
            txt_specialite.ValueMember = "ID_SPECIALITE";
            txt_groupe.DataSource = SP_GET_ID_GROUPE();
            txt_groupe.DisplayMember = "ID_GROUPE";
            txt_groupe.ValueMember = "ID_GROUPE";
            txt_salle.DataSource = SP_GET_SALLE();
            txt_salle.DisplayMember = "NOM_SALLE";
            txt_salle.ValueMember = "NOM_SALLE";
        }

        public DataTable SP_GET_ID_SPECIALITE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_ID_SPECIALITE", null);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_ID_GROUPE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_ID_GROUPE", null);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_SALLE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_SALLE", null);
            db.Close();
            return dt;
        }

        public void DeleteEmploi(string ID_EMP)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_emp", MySqlDbType.VarChar, 32);
            param[0].Value = ID_EMP;

            db.ExecuteCommand("SP_DELETE_EMPLOI", param);
            db.Close();
        }

        public void SP_ADD_EMPLOI(string IEMP, string ISPE, string IG, string IENS, string IMOD, 
                                  string SAL, string JOR, string HD, string HF)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("@id_emp", MySqlDbType.VarChar, 32);
            param[0].Value = IEMP;

            param[1] = new MySqlParameter("@id_specialite", MySqlDbType.VarChar, 20);
            param[1].Value = ISPE;

            param[2] = new MySqlParameter("@id_groupe", MySqlDbType.VarChar, 20);
            param[2].Value = IG;

            param[3] = new MySqlParameter("@id_ens", MySqlDbType.VarChar, 20);
            param[3].Value = IENS;

            param[4] = new MySqlParameter("@id_mod", MySqlDbType.VarChar, 20);
            param[4].Value = IMOD;     

            param[5] = new MySqlParameter("@salle", MySqlDbType.VarChar, 20);
            param[5].Value = SAL;

            param[6] = new MySqlParameter("@jour", MySqlDbType.VarChar, 32);
            param[6].Value = JOR;

            param[7] = new MySqlParameter("@heur_debut", MySqlDbType.VarChar, 8);
            param[7].Value = HD;

            param[8] = new MySqlParameter("@heur_fin", MySqlDbType.VarChar, 8);
            param[8].Value = HF;

            db.ExecuteCommand("SP_ADD_EMPLOI", param);
            db.Close();
        }

        public void SP_EDIT_EMPLOI(string IEMP, string ISPE, string IG, string IENS, string IMOD,
                                  string SAL, string JOR, string HD, string HF)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("@id_emp", MySqlDbType.VarChar, 32);
            param[0].Value = IEMP;

            param[1] = new MySqlParameter("@id_specialite", MySqlDbType.VarChar, 20);
            param[1].Value = ISPE;

            param[2] = new MySqlParameter("@id_groupe", MySqlDbType.VarChar, 20);
            param[2].Value = IG;

            param[3] = new MySqlParameter("@id_ens", MySqlDbType.VarChar, 20);
            param[3].Value = IENS;

            param[4] = new MySqlParameter("@id_mod", MySqlDbType.VarChar, 20);
            param[4].Value = IMOD;

            param[5] = new MySqlParameter("@salle", MySqlDbType.VarChar, 20);
            param[5].Value = SAL;

            param[6] = new MySqlParameter("@jour", MySqlDbType.VarChar, 32);
            param[6].Value = JOR;

            param[7] = new MySqlParameter("@heur_debut", MySqlDbType.VarChar, 8);
            param[7].Value = HD;

            param[8] = new MySqlParameter("@heur_fin", MySqlDbType.VarChar, 8);
            param[8].Value = HF;

            db.ExecuteCommand("SP_EDIT_EMPLOI", param);
            db.Close();
        }

        public void SP_ADD_GROUPE(string IG, string NG)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = IG;

            param[1] = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
            param[1].Value = NG;

            db.ExecuteCommand("SP_ADD_GROUPE", param);
            db.Close();
        }

        public void SP_EDIT_GROUPE(string IG, string NG)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = IG;

            param[1] = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
            param[1].Value = NG;

            db.ExecuteCommand("SP_EDIT_GROUPE", param);
            db.Close();
        }

        public void SP_ADD_SALLE(string NS, string CS)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("@nom", MySqlDbType.VarChar, 20);
            param[0].Value = NS;

            param[1] = new MySqlParameter("@capacite", MySqlDbType.Int32, 3);
            param[1].Value = CS;

            db.ExecuteCommand("SP_ADD_SALLE", param);
            db.Close();
        }

        public void SP_EDIT_SALLE(string NS, string CS)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("@nom", MySqlDbType.VarChar, 20);
            param[0].Value = NS;

            param[1] = new MySqlParameter("@capacite", MySqlDbType.Int32, 3);
            param[1].Value = CS;

            db.ExecuteCommand("SP_EDIT_SALLE", param);
            db.Close();
        }

        public void SP_DELETE_SALLE(string NOM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@nom", MySqlDbType.VarChar, 20);
            param[0].Value = NOM;

            db.ExecuteCommand("SP_DELETE_SALLE", param);
            db.Close();
        }

        public void SP_DELETE_GROUPE(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            db.ExecuteCommand("SP_DELETE_GROUPE", param);
            db.Close();
        }

        public DataTable SP_VERIFY_GROUPE(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_VERIFY_GROUPE", param);
            db.Close();
            return dt;
        }

        public DataTable SP_VERIFY_SALLE(string NOM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@nom", MySqlDbType.VarChar, 20);
            param[0].Value = NOM;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_VERIFY_SALLE", param);
            db.Close();
            return dt;
        }

        public DataTable SP_INFORMATION_ENSEIGNANT(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_enseignant", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_INFORMATION_ENSEIGNANT", param);
            db.Close();
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

        private void btn_choisire_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txt_id_emp.ReadOnly = false;
            txt_id_emp.Focus();
            Program.type_modifier = "Ajouter";
            Gestion_enseinant g = new Gestion_enseinant();
            Get_Module m = new Get_Module();
            g.groupBox3.Visible = false;
            g.ShowDialog();
            txt_id_ens.Text = g.affichage_resultat.CurrentRow.Cells[0].Value.ToString();
            txt_id_mod.Text = Program.id_module;
        }

        private void txt_heur_fin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable em = new DataTable();
                if (Program.type_modifier == "Modifier")
                {
                    em = SP_INFORMATION_ENSEIGNANT(txt_id_ens.Text);
                    string nom = em.Rows[0][0].ToString();
                    string prenom = em.Rows[0][1].ToString();
                    string email = em.Rows[0][3].ToString();

                    try
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
                        client.EnableSsl = true;

						MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تنبيه : التعديل على توقيت", "مرحبا بك " + nom + " " + prenom + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الأستاذ(ة) أنه تم التعديل على توقيت بشكل رسمي .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من إدارة الكلية .\n وشكرا .");

						mail.IsBodyHtml = false;

                        client.Send(mail);
                    }
                    catch
                    {
                        MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web. ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        SP_EDIT_EMPLOI(txt_id_emp.Text, txt_specialite.Text, txt_groupe.Text,
                                   txt_id_ens.Text, txt_id_mod.Text, txt_salle.Text,
                                   txt_joure.Text, txt_heur_debut.Text, txt_heur_fin.Text);
                        MessageBox.Show("Modification succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }

                }
                else
                {
                    if (txt_id_emp.Text == string.Empty || txt_id_ens.Text == string.Empty || txt_id_mod.Text == string.Empty ||
                                            txt_specialite.Text == string.Empty || txt_groupe.Text == string.Empty || txt_salle.Text == string.Empty ||
                                            txt_joure.Text == string.Empty || txt_heur_debut.Text == string.Empty || txt_heur_fin.Text == string.Empty)
                    {
                        MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_choisire.Focus();
                    }
                    else
                    {
                        for (int j = 0; j < affichage_emploi.Rows.Count - 1; j++)
                        {
                            string TextDimodier = affichage_emploi.Rows[j].Cells[0].Value.ToString();
                            string TextNouveaur = txt_id_emp.Text;
                            if (TextDimodier.ToLower() == TextNouveaur.ToLower())
                            {
                                MessageBox.Show("Cette emploi déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                btn_choisire.Focus();
                                return;
                            }
                        }
                        DataRow r = dt.NewRow();
                        r[0] = txt_id_emp.Text;
                        r[1] = txt_id_ens.Text;
                        r[2] = txt_id_mod.Text;
                        r[3] = txt_specialite.SelectedValue;
                        r[4] = txt_groupe.SelectedValue;
                        r[5] = txt_salle.SelectedValue;
                        r[6] = txt_joure.Text;
                        r[7] = txt_heur_debut.Text;
                        r[8] = txt_heur_fin.Text;
                        dt.Rows.Add(r);
                        affichage_emploi.DataSource = dt;
                        ClearBoxes();
                    }
                }
            }
        }

        private void txt_id_emp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_id_emp.Text != string.Empty)
            {
                txt_specialite.Focus();
            }
        }

        private void txt_specialite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_specialite.Text != string.Empty)
            {
                txt_groupe.Focus();
            }
        }

        private void txt_groupe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_groupe.Text != string.Empty)
            {
                txt_salle.Focus();
            }
        }

        private void txt_salle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_salle.Text != string.Empty)
            {
                txt_joure.Focus();
            }
        }

        private void txt_joure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_joure.Text != string.Empty)
            {
                txt_heur_debut.Focus();
            }
        }

        private void txt_heur_debut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_heur_debut.Text != string.Empty)
            {
                txt_heur_fin.Focus();
            }
        }

        private void txt_heur_debut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_heur_fin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_modifier_stocke_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id_emp.ReadOnly = true;
                Program.type_modifier = "Modifier";
                Get_Emploi n = new Get_Emploi();
                n.ShowDialog();
                txt_id_emp.Text = n.dgv_get_emploi.CurrentRow.Cells[0].Value.ToString();
                txt_id_ens.Text = n.dgv_get_emploi.CurrentRow.Cells[3].Value.ToString();
                txt_id_mod.Text = n.dgv_get_emploi.CurrentRow.Cells[4].Value.ToString();
                txt_specialite.Text = n.dgv_get_emploi.CurrentRow.Cells[1].Value.ToString();
                txt_groupe.Text = n.dgv_get_emploi.CurrentRow.Cells[2].Value.ToString();
                txt_salle.Text = n.dgv_get_emploi.CurrentRow.Cells[5].Value.ToString();
                txt_joure.Text = n.dgv_get_emploi.CurrentRow.Cells[6].Value.ToString();
                txt_heur_debut.Text = n.dgv_get_emploi.CurrentRow.Cells[7].Value.ToString();
                txt_heur_fin.Text = n.dgv_get_emploi.CurrentRow.Cells[8].Value.ToString();
                txt_specialite.Focus();
            }
            catch
            {
                return;
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (affichage_emploi.Rows[0].Cells[0].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("Impposible ajouter avant remplire  ", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable em = new DataTable();
                    for (int i = 0; i < affichage_emploi.Rows.Count - 1; i++)
                    {
                        try
                        {
                            em = SP_INFORMATION_ENSEIGNANT(affichage_emploi.Rows[i].Cells[1].Value.ToString());
                            string nom = em.Rows[0][0].ToString();
                            string prenom = em.Rows[0][1].ToString();
                            string email = em.Rows[0][3].ToString();

                            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                            client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
                            client.EnableSsl = true;

                            MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تنبيه : إدراج توقيت", "مرحبا بك " + nom + " " + prenom + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الأستاذ(ة) أنه تم إدراج التوقيت بشكل رسمي .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من إدارة الكلية .\n وشكرا .");

                            mail.IsBodyHtml = false;

                            client.Send(mail);
                        }
                        catch
                        {
                            MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web. ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            SP_ADD_EMPLOI(affichage_emploi.Rows[i].Cells[0].Value.ToString(), affichage_emploi.Rows[i].Cells[3].Value.ToString(),
                                          affichage_emploi.Rows[i].Cells[4].Value.ToString(), affichage_emploi.Rows[i].Cells[1].Value.ToString(),
                                          affichage_emploi.Rows[i].Cells[2].Value.ToString(), affichage_emploi.Rows[i].Cells[5].Value.ToString(),
                                          affichage_emploi.Rows[i].Cells[6].Value.ToString(), affichage_emploi.Rows[i].Cells[7].Value.ToString(),
                                          affichage_emploi.Rows[i].Cells[8].Value.ToString());
                        }
                    }
                    MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    affichage_emploi.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("L'insertion a échoué", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void affichage_emploi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_id_emp.Text = affichage_emploi.CurrentRow.Cells[0].Value.ToString();
                txt_id_ens.Text = affichage_emploi.CurrentRow.Cells[1].Value.ToString();
                txt_id_mod.Text = affichage_emploi.CurrentRow.Cells[2].Value.ToString();
                txt_specialite.Text = affichage_emploi.CurrentRow.Cells[3].Value.ToString();
                txt_groupe.Text = affichage_emploi.CurrentRow.Cells[4].Value.ToString();
                txt_salle.Text = affichage_emploi.CurrentRow.Cells[5].Value.ToString();
                txt_joure.Text = affichage_emploi.CurrentRow.Cells[6].Value.ToString();
                txt_heur_debut.Text = affichage_emploi.CurrentRow.Cells[7].Value.ToString();
                txt_heur_fin.Text = affichage_emploi.CurrentRow.Cells[8].Value.ToString();
                affichage_emploi.Rows.RemoveAt(affichage_emploi.CurrentRow.Index);
                txt_id_emp.Focus();
            }
            catch
            {
                return;
            }
        }

        private void btn_supprimier_note_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Emploi n = new Get_Emploi();
                n.ShowDialog();
                string id = n.dgv_get_emploi.CurrentRow.Cells[0].Value.ToString();
                btn_choisire.Focus();
                if (MessageBox.Show("Est-ce-que vous voulez supprimer cette emploi ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DeleteEmploi(id);
                    MessageBox.Show("Supprimer succès", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec supprimer", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void supprimierCetteLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                affichage_emploi.Rows.RemoveAt(affichage_emploi.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affichage_emploi_DoubleClick(sender, e);
        }

        private void supprimierToutsLingesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            affichage_emploi.Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_enregistrer_Click(sender, e);
        }

        private void btn_new_g_Click(object sender, EventArgs e)
        {
            txt_id_groupe.Clear();
            txt_nom_groupe.Clear();
            txt_id_groupe.ReadOnly = false;
            txt_id_groupe.Focus();
            btn_ajoute_g.Enabled = true;
            btn_new_g.Enabled = false;
        }

        private void btn_new_s_Click(object sender, EventArgs e)
        {
            txt_nom_salle.Clear();
            txt_capacite.Clear();
            txt_nom_salle.ReadOnly = false;
            txt_nom_salle.Focus();
            btn_ajouter_s.Enabled = true;
            btn_new_s.Enabled = false;
        }

        private void btn_ajoute_g_Click(object sender, EventArgs e)
        {
            if (txt_id_groupe.ReadOnly == false)
            {
                try
                {
                    if (txt_id_groupe.Text == string.Empty || txt_nom_groupe.Text == string.Empty)
                    {
                        MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_id_groupe.Focus();
                    }
                    else
                    {
                        txt_id_groupe.ReadOnly = true;
                        btn_ajoute_g.Enabled = false;
                        btn_new_g.Enabled = true;
                        SP_ADD_GROUPE(txt_id_groupe.Text, txt_nom_groupe.Text);
                        MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_id_groupe.Clear();
                        txt_nom_groupe.Clear();
                        this.Hide();
                        Gestion_emploi ge = new Gestion_emploi();
                        ge.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("L'insertion a échoué", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    if (txt_id_groupe.ReadOnly == true)
                    {
                        SP_EDIT_GROUPE(txt_id_groupe.Text, txt_nom_groupe.Text);
                        MessageBox.Show("Modification succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_id_groupe.Clear();
                        txt_nom_groupe.Clear();
                        btn_new_g.Enabled = true;
                        btn_ajoute_g.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Échec Modification", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_ajouter_s_Click(object sender, EventArgs e)
        {
            if (txt_nom_salle.ReadOnly == false)
            {
                try
                {
                    if (txt_nom_salle.Text == string.Empty || txt_capacite.Text == string.Empty)
                    {
                        MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_nom_salle.Focus();
                    }
                    else
                    {
                        txt_nom_salle.ReadOnly = true;
                        btn_ajouter_s.Enabled = false;
                        btn_new_s.Enabled = true;
                        SP_ADD_SALLE(txt_nom_salle.Text, txt_capacite.Text);
                        MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nom_salle.Clear();
                        txt_capacite.Clear();
                        btn_ajouter_s.Enabled = false;
                        btn_new_s.Enabled = true;
                        this.Hide();
                        Gestion_emploi ge = new Gestion_emploi();
                        ge.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    if (txt_nom_salle.ReadOnly == true)
                    {
                        SP_EDIT_SALLE(txt_nom_salle.Text, txt_capacite.Text);
                        MessageBox.Show("Modification succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nom_salle.Clear();
                        txt_capacite.Clear();
                        btn_ajouter_s.Enabled = false;
                        btn_new_s.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Échec Modification", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_capacite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_modifier_g_Click(object sender, EventArgs e)
        {
            txt_id_groupe.ReadOnly = true;
            btn_ajoute_g.Enabled = true;
            btn_new_g.Enabled = false;
            Get_Groupe gs = new Get_Groupe();
            gs.ShowDialog();
            txt_id_groupe.Text = gs.dgv_get_groupe.CurrentRow.Cells[0].Value.ToString();
            txt_nom_groupe.Text = gs.dgv_get_groupe.CurrentRow.Cells[1].Value.ToString();
            txt_nom_groupe.Focus();
        }

        private void btn_modifier_s_Click(object sender, EventArgs e)
        {
            txt_nom_salle.ReadOnly = true;
            btn_ajouter_s.Enabled = true;
            btn_new_s.Enabled = false;
            Get_Salle gs = new Get_Salle();
            gs.ShowDialog();
            txt_nom_salle.Text = gs.dgv_get_salle.CurrentRow.Cells[0].Value.ToString();
            txt_capacite.Text = gs.dgv_get_salle.CurrentRow.Cells[1].Value.ToString();
            txt_capacite.Focus();

        }

        private void btn_supprimer_g_Click(object sender, EventArgs e)
        {
            Get_Groupe gm = new Get_Groupe();
            gm.ShowDialog();

            if (MessageBox.Show("Est-ce-que vous voulez supprimer cette groupe ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    SP_DELETE_GROUPE(gm.dgv_get_groupe.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Supprimer succès", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Gestion_emploi ge = new Gestion_emploi();
                    ge.ShowDialog();
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Échec supprimer", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_supprimier_s_Click(object sender, EventArgs e)
        {
            Get_Salle gs = new Get_Salle();
            gs.ShowDialog();

            if (MessageBox.Show("Est-ce-que vous voulez supprimer cette salle ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    SP_DELETE_SALLE(gs.dgv_get_salle.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Supprimer succès", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Gestion_emploi ge = new Gestion_emploi();
                    ge.ShowDialog();
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Échec supprimer", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_id_groupe_Validated(object sender, EventArgs e)
        {
            if (txt_id_groupe.ReadOnly == false)
            {
                DataTable dt = new DataTable();
                dt = SP_VERIFY_GROUPE(txt_id_groupe.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cette identifiant déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_id_groupe.Focus();
                    txt_id_groupe.SelectionStart = 0;
                    txt_id_groupe.SelectionLength = txt_id_groupe.TextLength;
                }
            }
            else
            {
                return;
            }
        }

        private void txt_nom_salle_Validated(object sender, EventArgs e)
        {
            if (txt_nom_salle.ReadOnly == false)
            {
                DataTable dt = new DataTable();
                dt = SP_VERIFY_SALLE(txt_nom_salle.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cette identifiant déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nom_salle.Focus();
                    txt_nom_salle.SelectionStart = 0;
                    txt_nom_salle.SelectionLength = txt_nom_salle.TextLength;
                }
            }
            else
            {
                return;
            }
        }
    }
}
