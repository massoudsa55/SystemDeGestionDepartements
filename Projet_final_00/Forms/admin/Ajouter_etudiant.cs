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
    public partial class Ajouter_etudiant : Form
    {
		string id_us, nom_us, prenom_us;

        public Ajouter_etudiant()
        {
            InitializeComponent();
            txt_id_specialite.Text = null;
            txt_id_groupe.Text = null;
            txt_id_specialite.DataSource = SP_GET_ID_SPECIALITE();
            txt_id_specialite.DisplayMember = "ID_SPECIALITE";
            txt_id_specialite.ValueMember = "ID_SPECIALITE";
            txt_id_groupe.DataSource = SP_GET_ID_GROUPE();
            txt_id_groupe.DisplayMember = "ID_GROUPE";
            txt_id_groupe.ValueMember = "ID_GROUPE";
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

        public void SP_ADD_ETUDIANT(string ID_ETUDIANT, string ID_SPECIALITE, string ID_GROUPE,
            string NOM_ETUDIANT, string PRENOM_ETUDIANT, object DATA_DE_NAISSANCE, string LIEN_DE_NAISSANCE,
            string ADRESS_ETUDIANT, string EMAIL_ETUDIANT, int TELEPHONE_ETUDIANT, object ANNEE_ETUD)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ETUDIANT;

            param[1] = new MySqlParameter("@id_specialite", MySqlDbType.VarChar, 20);
            param[1].Value = ID_SPECIALITE;

            param[2] = new MySqlParameter("@id_groupe", MySqlDbType.VarChar, 20);
            param[2].Value = ID_GROUPE;

            param[3] = new MySqlParameter("@nom_etudiant", MySqlDbType.VarChar, 50);
            param[3].Value = NOM_ETUDIANT;

            param[4] = new MySqlParameter("@prenom_etudiant", MySqlDbType.VarChar, 50);
            param[4].Value = PRENOM_ETUDIANT;

            param[5] = new MySqlParameter("@data_de_naissance", MySqlDbType.Date);
            param[5].Value = DATA_DE_NAISSANCE;

            param[6] = new MySqlParameter("@lien_de_naissance", MySqlDbType.VarChar, 60);
            param[6].Value = LIEN_DE_NAISSANCE;

            param[7] = new MySqlParameter("@adress_etudiant", MySqlDbType.VarChar, 60);
            param[7].Value = ADRESS_ETUDIANT;

            param[8] = new MySqlParameter("@email_etudiant", MySqlDbType.VarChar, 60);
            param[8].Value = EMAIL_ETUDIANT;

            param[9] = new MySqlParameter("@telephone_etudiant", MySqlDbType.Int32, 20);
            param[9].Value = TELEPHONE_ETUDIANT;

            param[10] = new MySqlParameter("@annee_etud", MySqlDbType.Date);
            param[10].Value = ANNEE_ETUD;


            db.ExecuteCommand("SP_ADD_ETUDIANT", param);
            db.Close();
        }


        public void SP_EDIT_ETUDIANT(string ID_ETUDIANT, string ID_SPECIALITE, string ID_GROUPE,
            string NOM_ETUDIANT, string PRENOM_ETUDIANT, object DATA_DE_NAISSANCE, string LIEN_DE_NAISSANCE,
            string ADRESS_ETUDIANT, string EMAIL_ETUDIANT, int TELEPHONE_ETUDIANT, object ANNEE_ETUD)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("@id_etudiant", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ETUDIANT;

            param[1] = new MySqlParameter("@id_specialite", MySqlDbType.VarChar, 20);
            param[1].Value = ID_SPECIALITE;

            param[2] = new MySqlParameter("@id_groupe", MySqlDbType.VarChar, 20);
            param[2].Value = ID_GROUPE;

            param[3] = new MySqlParameter("@nom_etudiant", MySqlDbType.VarChar, 50);
            param[3].Value = NOM_ETUDIANT;

            param[4] = new MySqlParameter("@prenom_etudiant", MySqlDbType.VarChar, 50);
            param[4].Value = PRENOM_ETUDIANT;

            param[5] = new MySqlParameter("@data_de_naissance", MySqlDbType.Date);
            param[5].Value = DATA_DE_NAISSANCE;

            param[6] = new MySqlParameter("@lien_de_naissance", MySqlDbType.VarChar, 60);
            param[6].Value = LIEN_DE_NAISSANCE;

            param[7] = new MySqlParameter("@adress_etudiant", MySqlDbType.VarChar, 60);
            param[7].Value = ADRESS_ETUDIANT;

            param[8] = new MySqlParameter("@email_etudiant", MySqlDbType.VarChar, 60);
            param[8].Value = EMAIL_ETUDIANT;

            param[9] = new MySqlParameter("@telephone_etudiant", MySqlDbType.Int32, 20);
            param[9].Value = TELEPHONE_ETUDIANT;

            param[10] = new MySqlParameter("@annee_etud", MySqlDbType.Date);
            param[10].Value = ANNEE_ETUD;


            db.ExecuteCommand("SP_EDIT_ETUDIANT", param);
            db.Close();
        }


        private void btn_anneler_Click_1(object sender, EventArgs e)
        {
			txt_id_etudiant.Text = null;
			this.Hide();
			Gestion_etudiant g = new Gestion_etudiant();
			g.ShowDialog();
		}

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_etudiant.Text == string.Empty || txt_id_specialite.Text == string.Empty || txt_id_groupe.Text == string.Empty ||
               txt_nom_etudiant.Text == string.Empty || txt_penom_etudiant.Text == string.Empty || txt_date_naissance.Text == string.Empty ||
               txt_lien_naissance.Text == string.Empty || txt_address_etudiant.Text == string.Empty || txt_email.Text == string.Empty ||
               txt_telephone.Text == string.Empty || txt_date_etude.Text == string.Empty)
            {
                MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txt_modifier.Text == "Ajoute Etudiant")
                    {
						try
						{
							string email = txt_email.Text;
							id_us = txt_id_etudiant.Text;
							nom_us = txt_nom_etudiant.Text;
							prenom_us = txt_penom_etudiant.Text;

							SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
							client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
							client.EnableSsl = true;

							MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تسجيل طالب جديد", "مرحبا بك " +nom_us+ " " +prenom_us +" في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الطالب(ة) أنه تم تسجيلك في الكلية بشكل رسمي .\n"+"تحت رقم التسجيل التالي :   "+id_us+ " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من مصالحة شؤون الطلبة بالكلية .\n وشكرا .");
							
							mail.IsBodyHtml = false;

							client.Send(mail);
						}
						catch
						{
							MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						finally
						{
							SP_ADD_ETUDIANT(txt_id_etudiant.Text, Convert.ToString(txt_id_specialite.SelectedValue), Convert.ToString(txt_id_groupe.SelectedValue), txt_nom_etudiant.Text, txt_penom_etudiant.Text, txt_date_naissance.Value.Date, txt_lien_naissance.Text, txt_address_etudiant.Text, txt_email.Text, Convert.ToInt32(txt_telephone.Text), txt_date_etude.Value.Date);
							MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txt_id_etudiant.Clear();
							txt_id_specialite.Text = null;
							txt_id_groupe.Text = null;
							txt_nom_etudiant.Clear();
							txt_penom_etudiant.Clear();
							txt_date_naissance.Text = null;
							txt_lien_naissance.Clear();
							txt_address_etudiant.Clear();
							txt_email.Clear();
							txt_telephone.Clear();
							txt_date_etude.Text = null;
						}
                    }
                    else
                    {
						try
						{
							string email = txt_email.Text;
							id_us = txt_id_etudiant.Text;
							nom_us = txt_nom_etudiant.Text;
							prenom_us = txt_penom_etudiant.Text;
							SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
							client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
							client.EnableSsl = true;
							MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تصحيح معلومات الطالب", "مرحبا بك " + nom_us + " " + prenom_us + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الطالب(ة) أنه تم تصحيح معلوماتك بشكل رسمي .\n" + "تحت رقم التسجيل التالي :   " + id_us + " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من مصالحة شؤون الطلبة بالكلية .\n وشكرا .");
							
							mail.IsBodyHtml = false;

							client.Send(mail);
						}
						catch
						{
							MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						finally
						{
							SP_EDIT_ETUDIANT(txt_id_etudiant.Text, Convert.ToString(txt_id_specialite.SelectedValue), Convert.ToString(txt_id_groupe.SelectedValue), txt_nom_etudiant.Text, txt_penom_etudiant.Text, txt_date_naissance.Value.Date, txt_lien_naissance.Text, txt_address_etudiant.Text, txt_email.Text, Convert.ToInt32(txt_telephone.Text), txt_date_etude.Value.Date);
							MessageBox.Show("Modification succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void txt_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        public DataTable VerifyEtudiant(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;
          
            DataTable dt = new DataTable();
            dt = db.SelectData("SP_VERIFY_ETUDIANT", param);
            db.Close();
            return dt;
        }

        private void txt_id_etudiant_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = VerifyEtudiant(txt_id_etudiant.Text);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Cette identifiant déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id_etudiant.Focus();
                txt_id_etudiant.SelectionStart = 0;
                txt_id_etudiant.SelectionLength = txt_id_etudiant.TextLength;
            }
        }
    }
}
