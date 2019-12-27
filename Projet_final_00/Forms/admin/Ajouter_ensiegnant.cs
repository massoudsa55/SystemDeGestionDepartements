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
using System.Net;
using System.Net.Mail;
using Bunifu;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace Projet_final_00.Forms.admin
{
	public partial class Ajouter_ensiegnant : Form
	{
		string id_us, nom_us, prenom_us;

		public Ajouter_ensiegnant()
		{
			InitializeComponent();
		}

        public void SP_ADD_ENSEIGNANT(string ID_ENSEIGNANT, string NOM_ENSEIGNANT, string PRENOM_ENSEIGNANT,
                                      object DATA_DE_NAISSANCE, string LIEN_DE_NAISSANCE, string ADRESS_ENSEIGNANT,
                                      string EMAIL_ENSEIGNANT, int TELEPHONE_ENSEIGNANT, string GRADE_ENSEIGNANT)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("@id_ens", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ENSEIGNANT;

            param[1] = new MySqlParameter("@nom_ens", MySqlDbType.VarChar, 50);
            param[1].Value = NOM_ENSEIGNANT;

            param[2] = new MySqlParameter("@prenom_ens", MySqlDbType.VarChar, 50);
            param[2].Value = PRENOM_ENSEIGNANT;

            param[3] = new MySqlParameter("@date_naissance", MySqlDbType.Date);
            param[3].Value = DATA_DE_NAISSANCE;

            param[4] = new MySqlParameter("@lien_naissance", MySqlDbType.VarChar, 60);
            param[4].Value = LIEN_DE_NAISSANCE;

            param[5] = new MySqlParameter("@adress_ens", MySqlDbType.VarChar, 60);
            param[5].Value = ADRESS_ENSEIGNANT;

            param[6] = new MySqlParameter("@email_ens", MySqlDbType.VarChar, 60);
            param[6].Value = EMAIL_ENSEIGNANT;

            param[7] = new MySqlParameter("@tel_ens", MySqlDbType.Int32, 20);
            param[7].Value = TELEPHONE_ENSEIGNANT;

            param[8] = new MySqlParameter("@rgade_ens", MySqlDbType.VarChar, 30);
            param[8].Value = GRADE_ENSEIGNANT;


            db.ExecuteCommand("SP_ADD_ENSEIGNANT", param);
            db.Close();
        }

        public void SP_EDIT_ENSEIGNANT(string ID_ENSEIGNANT, string NOM_ENSEIGNANT, string PRENOM_ENSEIGNANT,
                                      object DATA_DE_NAISSANCE, string LIEN_DE_NAISSANCE, string ADRESS_ENSEIGNANT,
                                      string EMAIL_ENSEIGNANT, int TELEPHONE_ENSEIGNANT, string GRADE_ENSEIGNANT)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("@id_ens", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ENSEIGNANT;

            param[1] = new MySqlParameter("@nom_ens", MySqlDbType.VarChar, 50);
            param[1].Value = NOM_ENSEIGNANT;

            param[2] = new MySqlParameter("@prenom_ens", MySqlDbType.VarChar, 50);
            param[2].Value = PRENOM_ENSEIGNANT;

            param[3] = new MySqlParameter("@date_naissance", MySqlDbType.Date);
            param[3].Value = DATA_DE_NAISSANCE;

            param[4] = new MySqlParameter("@lien_naissance", MySqlDbType.VarChar, 60);
            param[4].Value = LIEN_DE_NAISSANCE;

            param[5] = new MySqlParameter("@adress_ens", MySqlDbType.VarChar, 60);
            param[5].Value = ADRESS_ENSEIGNANT;

            param[6] = new MySqlParameter("@email_ens", MySqlDbType.VarChar, 60);
            param[6].Value = EMAIL_ENSEIGNANT;

            param[7] = new MySqlParameter("@tel_ens", MySqlDbType.Int32, 20);
            param[7].Value = TELEPHONE_ENSEIGNANT;

            param[8] = new MySqlParameter("@rgade_ens", MySqlDbType.VarChar, 30);
            param[8].Value = GRADE_ENSEIGNANT;


            db.ExecuteCommand("SP_EDIT_ENSEIGNANT", param);
            db.Close();
        }

        private void btn_anneler_Click(object sender, EventArgs e)
		{
			txt_id_enseignant.Text = null;
			this.Hide();
			Gestion_enseinant g = new Gestion_enseinant();
			g.Refresh();
			g.Show();
		}

        public DataTable VerifyEnseignant(string ID)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_VERIFY_ENSEIGNANT", param);
            db.Close();
            return dt;
        }

        private void txt_id_enseignant_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = VerifyEnseignant(txt_id_enseignant.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Cette identifiant déja exist s'il vous plaît remplacer ! ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id_enseignant.Focus();
                txt_id_enseignant.SelectionStart = 0;
                txt_id_enseignant.SelectionLength = txt_id_enseignant.TextLength;
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_enseignant.Text == string.Empty || txt_nom_enseignant.Text == string.Empty || txt_penom_enseignant.Text == string.Empty ||
               txt_date_naissance.Text == string.Empty || txt_lien_naissance.Text == string.Empty || txt_address_enseignant.Text == string.Empty ||
               txt_email.Text == string.Empty || txt_telephone.Text == string.Empty || txt_grade.Text == string.Empty)
            {
                MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txt_modifier.Text == "Ajoute Ensiegnant")
                    {
						try
						{
							string email = txt_email.Text;
							id_us = txt_id_enseignant.Text;
							nom_us = txt_nom_enseignant.Text;
							prenom_us = txt_penom_enseignant.Text;

							SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
							client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
							client.EnableSsl = true;
							MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تسجيل أستاذ جديد", "مرحبا بك " + nom_us + " " + prenom_us + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الأستاذ(ة) أنه تم تسجيلك في الكلية بشكل رسمي .\n" + "تحت رقم التسجيل التالي :   " + id_us + " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من إدارة الكلية .\n وشكرا .");
							
							mail.IsBodyHtml = false;

							client.Send(mail);
						}
						catch
						{
							MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						finally
						{
							SP_ADD_ENSEIGNANT(txt_id_enseignant.Text, txt_nom_enseignant.Text, txt_penom_enseignant.Text,
										  txt_date_naissance.Value.Date, txt_lien_naissance.Text, txt_address_enseignant.Text,
										  txt_email.Text, Convert.ToInt32(txt_telephone.Text), txt_grade.Text);



							MessageBox.Show("Ajouter succès", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txt_id_enseignant.Clear();
							txt_nom_enseignant.Clear();
							txt_penom_enseignant.Clear();
							txt_date_naissance.Text = null;
							txt_lien_naissance.Clear();
							txt_address_enseignant.Clear();
							txt_email.Clear();
							txt_telephone.Clear();
							txt_grade.Text = null;
						}
                    }
                    else
                    {
						try
						{
							string email = txt_email.Text;
							id_us = txt_id_enseignant.Text;
							nom_us = txt_nom_enseignant.Text;
							prenom_us = txt_penom_enseignant.Text;

							SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
							client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
							client.EnableSsl = true;

							MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تصحيح معلومات الأستاذ", "مرحبا بك " + nom_us + " " + prenom_us + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الأستاذ(ة) أنه تم تصحيح معلوماتك بشكل رسمي .\n" + "تحت رقم التسجيل التالي :   " + id_us + " .\nونعلمك أيضا أنه يمكنك الاطلاع على كل ماهو جديد باستخدام التطبيق المكتبي الخاص بالكلية NI-DJEL APPLICATION على حاسوبك الخاص .\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من إدارة الكلية .\n وشكرا .");
							//MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تصحيح معلومات الأستاذ", " مرحبا عزيزي الأستاذ \n نشكرك لإعلامنا بتصحيح معلوماتك الخاطئة .\n لقد تم تعديل معلوماتك في كلية العلوم الدققيقة والإعلام الآلي , رجاءا قم بالإطلاع , أي إستفسار راسلنا عبر البريد الإلكتروني gestion.departement.mail@gmail.com");
							mail.IsBodyHtml = false;

							client.Send(mail);
						}
						catch
						{
							MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						finally
						{
							SP_EDIT_ENSEIGNANT(txt_id_enseignant.Text, txt_nom_enseignant.Text, txt_penom_enseignant.Text,
										  txt_date_naissance.Value.Date, txt_lien_naissance.Text, txt_address_enseignant.Text,
										  txt_email.Text, Convert.ToInt32(txt_telephone.Text), txt_grade.Text);
							MessageBox.Show("Modification succès ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
                    }
                }
                catch
                {
                    return;
                }
            }
        }
	}
}
