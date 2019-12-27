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
	public partial class Gestion_enseinant : Form
	{
        MySqlConnection connection = new MySqlConnection("Server=" + Properties.Settings.Default.Server + "; Port=" +
                Properties.Settings.Default.Port + "; DataBase=" + Properties.Settings.Default.Database + "; uid=" +
                Properties.Settings.Default.User + "; passowrd=" + Properties.Settings.Default.Password + "");
        MySqlDataAdapter adapter;
        DataTable tab = new DataTable();
        public Gestion_enseinant()
		{
			InitializeComponent();
            GET_DATA();
        }

        public void GET_DATA()
        {
            tab.Rows.Clear();
            adapter = new MySqlDataAdapter("SELECT ID_ENSEIGNANT, NOM_ENSEIGNANT, PRENOM_ENSEIGNANT, DATA_DE_NAISSANCE, LIEN_DE_NAISSANCE, ADRESS_ENSEIGNANT, EMAIL_ENSEIGNANT, TELEPHONE_ENSEIGNANT, GRADE_ENSEIGNANT FROM enseignant", connection);
            adapter.Fill(tab);
            affichage_resultat.DataSource = tab;
        }

        public void DeleteEnseignant(string ID_ENSEIGNANT)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id_ens", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ENSEIGNANT;

            db.ExecuteCommand("SP_DELETE_ENSEIGNANT", param);
            db.Close();
        }

        private void button2_Click(object sender, EventArgs e)
		{
            administration admin = new administration();
            admin.Show();
            this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

        private void txt_cherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablecopy = tab.Copy();
                DataView dv = tablecopy.DefaultView;
                dv.RowFilter = "ID_ENSEIGNANT+NOM_ENSEIGNANT+PRENOM_ENSEIGNANT+DATA_DE_NAISSANCE+LIEN_DE_NAISSANCE+ADRESS_ENSEIGNANT+EMAIL_ENSEIGNANT+TELEPHONE_ENSEIGNANT+GRADE_ENSEIGNANT Like '%" + txt_cherche.Text + "%'";
                affichage_resultat.DataSource = dv;
            }
            catch
            {
                return;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            affichage_resultat.DataSource = null;
            Ajouter_ensiegnant ens = new Ajouter_ensiegnant();
            ens.txt_id_enseignant.Enabled = true;
            ens.Show();
            this.Hide();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                Ajouter_ensiegnant ens = new Ajouter_ensiegnant();
                ens.txt_id_enseignant.Text = affichage_resultat.CurrentRow.Cells[0].Value.ToString();
                ens.txt_nom_enseignant.Text = affichage_resultat.CurrentRow.Cells[1].Value.ToString();
                ens.txt_penom_enseignant.Text = affichage_resultat.CurrentRow.Cells[2].Value.ToString();
                ens.txt_date_naissance.Value = Convert.ToDateTime(affichage_resultat.CurrentRow.Cells[3].Value.ToString());
                ens.txt_lien_naissance.Text = affichage_resultat.CurrentRow.Cells[4].Value.ToString();
                ens.txt_address_enseignant.Text = affichage_resultat.CurrentRow.Cells[5].Value.ToString();
                ens.txt_email.Text = affichage_resultat.CurrentRow.Cells[6].Value.ToString();
                ens.txt_telephone.Text = affichage_resultat.CurrentRow.Cells[7].Value.ToString();
                ens.txt_grade.Text = affichage_resultat.CurrentRow.Cells[8].Value.ToString();
                ens.txt_id_enseignant.Enabled = false;
                ens.txt_modifier.Width = 360;
                ens.txt_modifier.Text = "Modifier : " + affichage_resultat.CurrentRow.Cells[1].Value.ToString() + " " + affichage_resultat.CurrentRow.Cells[2].Value.ToString();
                affichage_resultat.DataSource = null;
                ens.Show();
                this.Hide();
            }
            catch
            {
                return;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est-ce-que vous voulez supprimer cette enseignant ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
				try
				{
					string email = affichage_resultat.CurrentRow.Cells[6].Value.ToString();
					string id_us = affichage_resultat.CurrentRow.Cells[0].Value.ToString();
					string nom_us = affichage_resultat.CurrentRow.Cells[1].Value.ToString();
					string prenom_us = affichage_resultat.CurrentRow.Cells[2].Value.ToString();

					SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
					client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
					client.EnableSsl = true;

					MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تعليمة عن الخذف", "مرحبا بك " + nom_us + " " + prenom_us + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الأستاذ(ة) أنه تم حذفك نهائيا من الكلية بشكل رسمي .\n" + "تحت رقم التسجيل التالي :   " + id_us + "\n\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من إدارة الكلية .\n وشكرا .");
					
					mail.IsBodyHtml = false;

					client.Send(mail);
				}
				catch
				{
					MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				finally
				{
					DeleteEnseignant(affichage_resultat.CurrentRow.Cells[0].Value.ToString());
					MessageBox.Show("Supprimer succès", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
                this.Hide();
                affichage_resultat.DataSource = null;
                this.Show();
                GET_DATA();
            }
            else
            {
                MessageBox.Show("Échec supprimer", "Supprimier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void affichage_resultat_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            Get_Module m = new Get_Module();
            m.ShowDialog();
            Program.id_module = m.dgv_get_module.CurrentRow.Cells[0].Value.ToString();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_modifier_Click(sender, e);
        }

        private void supprimierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_supprimer_Click(sender, e);
        }
    }
}
