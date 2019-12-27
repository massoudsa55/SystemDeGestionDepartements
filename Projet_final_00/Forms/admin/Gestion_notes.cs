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
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace Projet_final_00.Forms.admin
{
    public partial class Gestion_notes : Form
    {
        DataTable dt = new DataTable();
        void CreateTable()
        {
            dt.Columns.Add("ID Etudiant");
            dt.Columns.Add("ID Module");
            dt.Columns.Add("Sémestre");
            dt.Columns.Add("TD");
            dt.Columns.Add("TP");
            dt.Columns.Add("Cours");
            affichage_note.DataSource = dt;
        }
        void ResizeDataGradeView()
        {
            this.affichage_note.RowHeadersWidth = 56;
            this.affichage_note.Columns[0].FillWeight = 105;
            this.affichage_note.Columns[1].FillWeight = 104;
            this.affichage_note.Columns[2].FillWeight = 101;
            this.affichage_note.Columns[3].FillWeight = 119;
            this.affichage_note.Columns[4].FillWeight = 114;
            this.affichage_note.Columns[5].FillWeight = 117;
        }
        void ClearBoxes()
        {
            txt_id_etud.Clear();
            txt_id_mod.Clear();
            txt_semestre.Text = null;
            txt_td_mod.Clear();
            txt_tp_mod.Clear();
            txt_cours_mod.Clear();
            btn_choisire.Focus();
        }
        public Gestion_notes()
        {
            InitializeComponent();
            CreateTable();
            ResizeDataGradeView();
            txt_id_unite_enseigner.Text = null;
            txt_id_type_module.Text = null;
            txt_id_type_module.DataSource = SP_GET_ID_TYPE_MODULE();
            txt_id_type_module.DisplayMember = "ID_TYPE_MODULE";
            txt_id_type_module.ValueMember = "ID_TYPE_MODULE";
            txt_id_unite_enseigner.DataSource = SP_GET_ID_UNITE_NESEIGNER();
            txt_id_unite_enseigner.DisplayMember = "ID_UNITE_ENSEIGNER";
            txt_id_unite_enseigner.ValueMember = "ID_UNITE_ENSEIGNER";
        }

        public DataTable SP_GET_ID_TYPE_MODULE()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_ID_TYPE_MODULE", null);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_ID_UNITE_NESEIGNER()
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_ID_UNITE_NESEIGNER", null);
            db.Close();
            return dt;
        }

        public void SP_ADD_MODULE(string ID_MODULE, string ID_UNITE_ENSEIGNER, string ID_TYPE_MODULE, 
                                  string NOM_MODULE, int COEFFICIENT_MODULE)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[0].Value = ID_MODULE;

            param[1] = new MySqlParameter("@id_unite_enseigner", MySqlDbType.VarChar, 32);
            param[1].Value = ID_UNITE_ENSEIGNER;

            param[2] = new MySqlParameter("@id_type_module", MySqlDbType.VarChar, 20);
            param[2].Value = ID_TYPE_MODULE;

            param[3] = new MySqlParameter("@nom_module", MySqlDbType.VarChar, 50);
            param[3].Value = NOM_MODULE;

            param[4] = new MySqlParameter("@coefficient", MySqlDbType.Int16, 2);
            param[4].Value = COEFFICIENT_MODULE;

            db.ExecuteCommand("SP_ADD_MODULE", param);
            db.Close();
        }

        public void SP_EDIT_MODULE(string ID_MODULE, string ID_UNITE_ENSEIGNER, string ID_TYPE_MODULE, 
                                   string NOM_MODULE, int COEFFICIENT_MODULE)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[0].Value = ID_MODULE;

            param[1] = new MySqlParameter("@id_unite_enseigner", MySqlDbType.VarChar, 32);
            param[1].Value = ID_UNITE_ENSEIGNER;

            param[2] = new MySqlParameter("@id_type_module", MySqlDbType.VarChar, 20);
            param[2].Value = ID_TYPE_MODULE;

            param[3] = new MySqlParameter("@nom_module", MySqlDbType.VarChar, 50);
            param[3].Value = NOM_MODULE;

            param[4] = new MySqlParameter("@coefficient", MySqlDbType.Int16, 2);
            param[4].Value = COEFFICIENT_MODULE;

            db.ExecuteCommand("SP_EDIT_MODULE", param);
            db.Close();
        }

        public void SP_EDIT_NOTE(string IE, string IM, string NS, double TDM, double TPM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@td_module", MySqlDbType.Double, 5);
            param[3].Value = TDM;

            param[4] = new MySqlParameter("@tp_module", MySqlDbType.Double, 5);
            param[4].Value = TPM;

            param[5] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[5].Value = CM;

            db.ExecuteCommand("SP_EDIT_NOTE", param);
            db.Close();
        }

        public void SP_EDIT_NOTE_TD_ET_TP_NULL(string IE, string IM, string NS, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[3].Value = CM;

            db.ExecuteCommand("SP_EDIT_NOTE_TD_ET_TP_NULL", param);
            db.Close();
        }

        public void SP_EDIT_NOTE_TD_NULL(string IE, string IM, string NS, double TPM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@tp_module", MySqlDbType.Double, 5);
            param[3].Value = TPM;

            param[4] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[4].Value = CM;

            db.ExecuteCommand("SP_EDIT_NOTE_TD_NULL", param);
            db.Close();
        }

        public void SP_EDIT_NOTE_TP_NULL(string IE, string IM, string NS, double TDM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@td_module", MySqlDbType.Double, 5);
            param[3].Value = TDM;

            param[4] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[4].Value = CM;

            db.ExecuteCommand("SP_EDIT_NOTE_TP_NULL", param);
            db.Close();
        }

        public void SP_ADD_NOTE(string IE, string IM, string NS, double TDM, double TPM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@td_module", MySqlDbType.Double, 5);
            param[3].Value = TDM;

            param[4] = new MySqlParameter("@tp_module", MySqlDbType.Double, 5);
            param[4].Value = TPM;

            param[5] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[5].Value = CM;

            db.ExecuteCommand("SP_ADD_NOTE", param);
            db.Close();
        }

        public void SP_ADD_NOTE_TD_ET_TP_NULL(string IE, string IM, string NS, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[3].Value = CM;

            db.ExecuteCommand("SP_ADD_NOTE_TD_ET_TP_NULL", param);
            db.Close();
        }

        public void SP_ADD_NOTE_TD_NULL(string IE, string IM, string NS, double TPM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@tp_module", MySqlDbType.Double, 5);
            param[3].Value = TPM;

            param[4] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[4].Value = CM;

            db.ExecuteCommand("SP_ADD_NOTE_TD_NULL", param);
            db.Close();
        }

        public void SP_ADD_NOTE_TP_NULL(string IE, string IM, string NS, double TDM, double CM)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = IE;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = IM;

            param[2] = new MySqlParameter("@nom_semestre", MySqlDbType.VarChar, 20);
            param[2].Value = NS;

            param[3] = new MySqlParameter("@td_module", MySqlDbType.Double, 5);
            param[3].Value = TDM;

            param[4] = new MySqlParameter("@cours_module", MySqlDbType.Double, 5);
            param[4].Value = CM;

            db.ExecuteCommand("SP_ADD_NOTE_TP_NULL", param);
            db.Close();
        }


        public DataTable VerifyModule(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_VERIFY_MODULE", param);
            db.Close();
            return dt;
        }

        public void DeleteEModule(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            db.ExecuteCommand("SP_DELETE_MODULE", param);
            db.Close();
        }

        public void DeleteNote(string ID_ETD, string ID_MOD)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("@id_etud", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ETD;

            param[1] = new MySqlParameter("@id_module", MySqlDbType.VarChar, 20);
            param[1].Value = ID_MOD;

            db.ExecuteCommand("SP_DELETE_NOTE", param);
            db.Close();
        }

        public DataTable SP_GET_IDETUDIANT(string NE, string PE, int N, string NS, string NG)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@nom_etud", MySqlDbType.VarChar, 50);
            param[0].Value = NE;

            param[1] = new MySqlParameter("@prenom_etud", MySqlDbType.VarChar, 50);
            param[1].Value = PE;

            param[2] = new MySqlParameter("@niveau", MySqlDbType.Int32, 20);
            param[2].Value = N;

            param[3] = new MySqlParameter("@nom_specialite", MySqlDbType.VarChar, 50);
            param[3].Value = NS;

            param[4] = new MySqlParameter("@groupe_etud", MySqlDbType.VarChar, 50);
            param[4].Value = NG;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_IDETUDIANT", param);
            db.Close();
            return dt;
        }

        public DataTable SP_GET_IDMODULE(string M)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@nom_module", MySqlDbType.VarChar, 50);
            param[0].Value = M;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_IDMODULE", param);
            db.Close();
            return dt;
        }

		public DataTable SP_GET_EMAIL(string e)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			MySqlParameter[] param = new MySqlParameter[1];

			param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
			param[0].Value = e;

			DataTable dt = new DataTable();
			dt = db.SelectData("SP_GET_EMAIL", param);
			db.Close();
			return dt;
		}

		public DataTable SP_GET_NOMMODUL_EMAIL(string e)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			MySqlParameter[] param = new MySqlParameter[1];

			param[0] = new MySqlParameter("@ID", MySqlDbType.VarChar, 20);
			param[0].Value = e;

			DataTable dt = new DataTable();
			dt = db.SelectData("SP_GET_NOMMODUL_EMAIL", param);
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

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_id_module.ReadOnly = false;
            txt_id_module.Clear();
            txt_id_type_module.Text = null;
            txt_id_unite_enseigner.Text = null;
            txt_nom_module.Clear();
            txt_coefficient.Clear();
            btn_ajoute.Enabled = true;
            btn_new.Enabled = false;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            txt_id_module.ReadOnly = true;
            Get_Module gm = new Get_Module();
            gm.ShowDialog();
            txt_id_module.Text = gm.dgv_get_module.CurrentRow.Cells[0].Value.ToString();
            txt_id_unite_enseigner.Text = gm.dgv_get_module.CurrentRow.Cells[1].Value.ToString();
            txt_id_type_module.Text = gm.dgv_get_module.CurrentRow.Cells[2].Value.ToString();
            txt_nom_module.Text = gm.dgv_get_module.CurrentRow.Cells[3].Value.ToString();
            txt_coefficient.Text = gm.dgv_get_module.CurrentRow.Cells[4].Value.ToString();
            btn_ajoute.Enabled = true;
            btn_new.Enabled = false;

        }

        private void btn_ajoute_Click(object sender, EventArgs e)
        {


            if (txt_id_module.ReadOnly == false)
            {
                try
                {


                    if (txt_id_module.Text != string.Empty || Convert.ToString(txt_id_unite_enseigner.SelectedValue) != string.Empty || Convert.ToString(txt_id_type_module.SelectedValue) != string.Empty || txt_nom_module.Text != string.Empty || txt_coefficient.Text != string.Empty)
                    {
                        SP_ADD_MODULE(txt_id_module.Text, Convert.ToString(txt_id_unite_enseigner.SelectedValue), Convert.ToString(txt_id_type_module.SelectedValue), txt_nom_module.Text, Convert.ToInt16(txt_coefficient.Text));
                        MessageBox.Show("Ajouter succès ", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_id_module.ReadOnly = false;
                        txt_id_module.Clear();
                        txt_id_type_module.Text = null;
                        txt_id_unite_enseigner.Text = null;
                        txt_nom_module.Clear();
                        txt_coefficient.Clear();
                        btn_ajoute.Enabled = false;
                        btn_new.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("S'il vous plaît remplire tout les informations ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    return;
                }

            }
            else
            {
                try
                {
                    SP_EDIT_MODULE(txt_id_module.Text, Convert.ToString(txt_id_unite_enseigner.SelectedValue), Convert.ToString(txt_id_type_module.SelectedValue), txt_nom_module.Text, Convert.ToInt16(txt_coefficient.Text));
                    MessageBox.Show("Modification succès ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id_module.ReadOnly = false;
                    txt_id_module.Clear();
                    txt_id_type_module.Text = null;
                    txt_id_unite_enseigner.Text = null;
                    txt_nom_module.Clear();
                    txt_coefficient.Clear();
                    btn_ajoute.Enabled = false;
                    btn_new.Enabled = true;
                }
                catch
                {
                    return;
                }
            }

        }

        private void txt_id_module_Validated(object sender, EventArgs e)
        {
            if (txt_id_module.ReadOnly == false)
            {
                DataTable dt = new DataTable();
                dt = VerifyModule(txt_id_module.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce identifiant déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_id_module.Focus();
                    txt_id_module.SelectionStart = 0;
                    txt_id_module.SelectionLength = txt_id_module.TextLength;
                }
            }
            else
            {
                return;
            }
        }

        private void txt_coefficient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Get_Module gm = new Get_Module();
            gm.ShowDialog();

            if (MessageBox.Show("Est-ce-que vous voulez supprimer cette module ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    DeleteEModule(gm.dgv_get_module.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Supprimer succès ", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Échec supprimer ", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_choisire_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txt_semestre.Enabled = true;
            Program.type_modifier = "Ajouter";
            Gestion_etudiant g = new Gestion_etudiant();
            Get_Module m = new Get_Module();
            g.groupBox3.Visible = false;
            g.ShowDialog();
            txt_id_etud.Text = g.affichage_resultat.CurrentRow.Cells[0].Value.ToString();
            txt_id_mod.Text = Program.id_module;
        }

        private void txt_td_mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txt_td_mod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tp_mod.Focus();
            }
        }

        private void txt_tp_mod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cours_mod.Focus();
            }
        }

        private void txt_cours_mod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_cours_mod.Text != string.Empty)
            {
                if (Program.type_modifier == "Modifier")
                {
					DataTable em = new DataTable();
					int i = txt_semestre.SelectedIndex;
					string sem = txt_semestre.Items[i].ToString();

					em = SP_GET_EMAIL(txt_id_etud.Text);
					string nom_etud = em.Rows[0][0].ToString();
					string prenom_etud = em.Rows[0][1].ToString();
					string email = em.Rows[0][2].ToString();

					em = SP_GET_NOMMODUL_EMAIL(txt_id_mod.Text);
					string nom_modul = em.Rows[0][0].ToString();

					try
					{
						SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
						client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
						client.EnableSsl = true;

						MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "التعديل على النقاط", "مرحبا بك " + nom_etud + " " + prenom_etud + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الطالب(ة) أنه تم التعديل على النقاط بشكل رسمي .\n" + "للمقياس التــالي :   " + nom_modul + " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من مصالحة شؤون الطلبة بالكلية .\n وشكرا .");
						
						mail.IsBodyHtml = false;

						client.Send(mail);
					}
					catch
					{
						MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web. ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					finally
					{
                        if (txt_td_mod.Text != string.Empty && txt_tp_mod.Text != string.Empty && txt_cours_mod.Text != string.Empty)
                        {
                            SP_EDIT_NOTE(txt_id_etud.Text, txt_id_mod.Text, sem, Convert.ToDouble(txt_td_mod.Text), Convert.ToDouble(txt_tp_mod.Text), Convert.ToDouble(txt_cours_mod.Text));
                        }
                        else
                        {
                            if (txt_td_mod.Text == string.Empty && txt_tp_mod.Text != string.Empty && txt_cours_mod.Text != string.Empty)
                            {
                                SP_EDIT_NOTE_TD_NULL(txt_id_etud.Text, txt_id_mod.Text, sem, Convert.ToDouble(txt_tp_mod.Text), Convert.ToDouble(txt_cours_mod.Text));
                            }
                            else
                            {
                                if (txt_td_mod.Text != string.Empty && txt_tp_mod.Text == string.Empty && txt_cours_mod.Text != string.Empty)
                                {
                                    SP_EDIT_NOTE_TP_NULL(txt_id_etud.Text, txt_id_mod.Text, sem, Convert.ToDouble(txt_td_mod.Text), Convert.ToDouble(txt_cours_mod.Text));
                                }
                                else
                                {
                                    if (txt_td_mod.Text == string.Empty && txt_tp_mod.Text == string.Empty && txt_cours_mod.Text != string.Empty)
                                    {
                                        SP_EDIT_NOTE_TD_ET_TP_NULL(txt_id_etud.Text, txt_id_mod.Text, sem, Convert.ToDouble(txt_cours_mod.Text));
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Modification succès ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_id_etud.Clear();
						txt_id_mod.Clear();
						txt_semestre.Text = null;
						txt_td_mod.Clear();
						txt_tp_mod.Clear();
						txt_cours_mod.Clear();
						btn_choisire.Focus();
					}
                }
                else
                {
                    if (txt_id_etud.Text == string.Empty || txt_id_mod.Text == string.Empty || txt_semestre.Text == string.Empty)
                    {
                        MessageBox.Show("S'il vous plaît remplire tout les informations ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_choisire.Focus();
                    }
                    else
                    {
                        for(int j = 0; j < affichage_note.Rows.Count - 1; j++)
                        {
                            if(affichage_note.Rows[j].Cells[0].Value.ToString()==txt_id_etud.Text && affichage_note.Rows[j].Cells[1].Value.ToString() == txt_id_mod.Text)
                            {
                                MessageBox.Show("Ce identifiant déja exist s'il vous plaît remplacer !", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                btn_choisire.Focus();
                                return;
                            }
                        }
                        int i = txt_semestre.SelectedIndex;
                        string sem = txt_semestre.Items[i].ToString();
                        DataRow r = dt.NewRow();
                        r[0] = txt_id_etud.Text;
                        r[1] = txt_id_mod.Text;
                        r[2] = sem;
                        r[3] = txt_td_mod.Text;
                        r[4] = txt_tp_mod.Text;
                        r[5] = txt_cours_mod.Text;
                        dt.Rows.Add(r);
                        affichage_note.DataSource = dt;
                        ClearBoxes();
                    }
                }
            }
        }

        private void txt_semestre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_semestre.Text != string.Empty)
            {
                txt_td_mod.Focus();
            }
        }

        private void affichage_note_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_id_etud.Text = affichage_note.CurrentRow.Cells[0].Value.ToString();
                txt_id_mod.Text = affichage_note.CurrentRow.Cells[1].Value.ToString();
                txt_semestre.Text = affichage_note.CurrentRow.Cells[2].Value.ToString();
                txt_td_mod.Text = affichage_note.CurrentRow.Cells[3].Value.ToString();
                txt_tp_mod.Text = affichage_note.CurrentRow.Cells[4].Value.ToString();
                txt_cours_mod.Text = affichage_note.CurrentRow.Cells[5].Value.ToString();
                affichage_note.Rows.RemoveAt(affichage_note.CurrentRow.Index);
                txt_td_mod.Focus();
            }
            catch
            {
                return;
            }
        }

        private void btn_modifier_stocke_Click(object sender, EventArgs e)
        {
            try
            {
                txt_semestre.Enabled = false;
                Program.type_modifier = "Modifier";
                DataTable t = new DataTable();
                DataTable j = new DataTable();
                Get_Note n = new Get_Note();
                n.ShowDialog();
                string nom = n.dgv_note.CurrentRow.Cells[0].Value.ToString();
                string prenom = n.dgv_note.CurrentRow.Cells[1].Value.ToString();
                int niveau = Convert.ToInt16(n.dgv_note.CurrentRow.Cells[2].Value.ToString());
                string specialite = n.dgv_note.CurrentRow.Cells[3].Value.ToString();
                string groupe = n.dgv_note.CurrentRow.Cells[4].Value.ToString();
                txt_semestre.Text = n.dgv_note.CurrentRow.Cells[5].Value.ToString();
                string module = n.dgv_note.CurrentRow.Cells[6].Value.ToString();
                txt_td_mod.Text = n.dgv_note.CurrentRow.Cells[7].Value.ToString();
                txt_tp_mod.Text = n.dgv_note.CurrentRow.Cells[8].Value.ToString();
                txt_cours_mod.Text = n.dgv_note.CurrentRow.Cells[9].Value.ToString();

                t = SP_GET_IDETUDIANT(nom, prenom, niveau, specialite, groupe);
                txt_id_etud.Text = t.Rows[0][0].ToString();

                j = SP_GET_IDMODULE(module);
                txt_id_mod.Text = j.Rows[0][0].ToString();
                txt_td_mod.Focus();
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
                if (affichage_note.Rows[0].Cells[0].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("Impposible ajouter avant remplire  ", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
					DataTable em = new DataTable();
					for (int i = 0; i < affichage_note.Rows.Count - 1; i++)
					{
                        try
                        {
                            em = SP_GET_EMAIL(affichage_note.Rows[i].Cells[0].Value.ToString());
                            string nom_etud = em.Rows[0][0].ToString();
                            string prenom_etud = em.Rows[0][1].ToString();
                            string email = em.Rows[0][2].ToString();

                            em = SP_GET_NOMMODUL_EMAIL(affichage_note.Rows[i].Cells[1].Value.ToString());
                            string nom_modul = em.Rows[0][0].ToString();


                            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                            client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
                            client.EnableSsl = true;

                            MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تنبيه : إدراج نقاط", "مرحبا بك " + nom_etud + " " + prenom_etud + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الطالب(ة) أنه تم إدراج النقاط بشكل رسمي .\n" + "للمقياس التــالي :   " + nom_modul + " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من مصالحة شؤون الطلبة بالكلية .\n وشكرا .");

                            mail.IsBodyHtml = false;

                            client.Send(mail);
                        }
                        catch
                        {
                            MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web. ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            string TD = affichage_note.Rows[i].Cells[3].Value.ToString();
                            string TP = affichage_note.Rows[i].Cells[4].Value.ToString();
                            string COURS = affichage_note.Rows[i].Cells[5].Value.ToString();

                            if (TD != string.Empty && TP != string.Empty)
                            {
                                SP_ADD_NOTE(affichage_note.Rows[i].Cells[0].Value.ToString(), affichage_note.Rows[i].Cells[1].Value.ToString(),
                                            affichage_note.Rows[i].Cells[2].Value.ToString(), Convert.ToDouble(affichage_note.Rows[i].Cells[3].Value.ToString()),
                                            Convert.ToDouble(affichage_note.Rows[i].Cells[4].Value.ToString()), Convert.ToDouble(affichage_note.Rows[i].Cells[5].Value.ToString()));
                            }
                            else
                            {
                                if (TD == string.Empty && TP != string.Empty)
                                {
                                    SP_ADD_NOTE_TD_NULL(affichage_note.Rows[i].Cells[0].Value.ToString(), affichage_note.Rows[i].Cells[1].Value.ToString(),
                                                        affichage_note.Rows[i].Cells[2].Value.ToString(), Convert.ToDouble(affichage_note.Rows[i].Cells[4].Value.ToString()), 
                                                        Convert.ToDouble(affichage_note.Rows[i].Cells[5].Value.ToString()));
                                }
                                else
                                {
                                    if (TD != string.Empty && TP == string.Empty)
                                    {
                                        SP_ADD_NOTE_TP_NULL(affichage_note.Rows[i].Cells[0].Value.ToString(), affichage_note.Rows[i].Cells[1].Value.ToString(),
                                                            affichage_note.Rows[i].Cells[2].Value.ToString(), Convert.ToDouble(affichage_note.Rows[i].Cells[3].Value.ToString()), Convert.ToDouble(affichage_note.Rows[i].Cells[5].Value.ToString()));
                                    }
                                    else
                                    {
                                        if (TD == string.Empty && TP == string.Empty)
                                        {
                                            SP_ADD_NOTE_TD_ET_TP_NULL(affichage_note.Rows[i].Cells[0].Value.ToString(), affichage_note.Rows[i].Cells[1].Value.ToString(),
                                                                      affichage_note.Rows[i].Cells[2].Value.ToString(), Convert.ToDouble(affichage_note.Rows[i].Cells[5].Value.ToString()));
                                        }
                                    }
                                }
                            }
						}
					}
                    MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    affichage_note.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("L'insertion a échoué", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable t = new DataTable();
                DataTable j = new DataTable();
                Get_Note n = new Get_Note();
                n.ShowDialog();
                string nom = n.dgv_note.CurrentRow.Cells[0].Value.ToString();
                string prenom = n.dgv_note.CurrentRow.Cells[1].Value.ToString();
                int niveau = Convert.ToInt16(n.dgv_note.CurrentRow.Cells[2].Value.ToString());
                string specialite = n.dgv_note.CurrentRow.Cells[3].Value.ToString();
                string groupe = n.dgv_note.CurrentRow.Cells[4].Value.ToString();
                string module = n.dgv_note.CurrentRow.Cells[6].Value.ToString();

                t = SP_GET_IDETUDIANT(nom, prenom, niveau, specialite, groupe);
                string id_etud = t.Rows[0][0].ToString();
                j = SP_GET_IDMODULE(module);
                string id_mod = j.Rows[0][0].ToString();
                btn_choisire.Focus();
                //DeleteENote(string ID_ETD, string ID_MOD)
                if (MessageBox.Show("Est-ce-que vous voulez supprimer cette note ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    DeleteNote(id_etud, id_mod);
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

		private void btn_imprimier_Click(object sender, EventArgs e)
		{
			Cr_Form_Print_List_Nots print = new Cr_Form_Print_List_Nots();
			print.Show();
		}

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affichage_note_DoubleClick(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_enregistrer_Click(sender, e);
        }

        private void supprimierToutsLingesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            affichage_note.Refresh();
        }

        private void supprimierCetteLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                affichage_note.Rows.RemoveAt(affichage_note.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btn_imprimier_Click(sender, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
