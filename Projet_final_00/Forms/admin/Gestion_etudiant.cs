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
using Bunifu;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using System.Net.Mail;
using System.Net;


namespace Projet_final_00.Forms.admin
{
	public partial class Gestion_etudiant : Form
	{

		public static Gestion_etudiant gestion_etud;
		static void gestion_etud_close(object sender, FormClosedEventArgs e)
		{
			gestion_etud = null;
		}

		public static Gestion_etudiant get_gestion_etud
		{
			get
			{
				if (gestion_etud == null)
				{
					gestion_etud = new Gestion_etudiant();
					gestion_etud.FormClosed += new FormClosedEventHandler(gestion_etud_close);
				}
				return gestion_etud;
			}
		}

		MySqlConnection cn = new MySqlConnection("Server=" + Properties.Settings.Default.Server + "; Port=" +
        Properties.Settings.Default.Port + "; DataBase=" + Properties.Settings.Default.Database + "; uid=" +
        Properties.Settings.Default.User + "; passowrd=" + Properties.Settings.Default.Password + "");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

		public string niveau, specialite, groupe;

		public void CreateTable()
        {
            table.Columns.Add("ID Etudiant");
            table.Columns.Add("Nom etudaint");
            table.Columns.Add("Prenom etudiant");
            table.Columns.Add("Date de naissance");
            table.Columns.Add("Lien de naissance");
            table.Columns.Add("Adress etudiant");
            table.Columns.Add("Email etudiant");
            table.Columns.Add("Telephone etudiant");
            table.Columns.Add("Année Etude");
            table.Columns.Add("Niveau");
            table.Columns.Add("Specialite");
            table.Columns.Add("Nom groupe");
      
            affichage_resultat.DataSource = table;
        }
        public Gestion_etudiant()
		{
			InitializeComponent();

			if (gestion_etud == null)
				gestion_etud = this;

			txt_niveau.DataSource = SP_GET_NIVEAU();
            txt_niveau.DisplayMember = "NIVEAU";
            txt_niveau.ValueMember = "NIVEAU";
            GET_DATA();

        }

        public void GET_DATA()
        {
            table.Rows.Clear();
            adapter = new MySqlDataAdapter("SELECT ID_ETUDIANT, NOM_ETUDIANT, PRENOM_ETUDIANT, DATA_DE_NAISSANCE, LIEN_DE_NAISSANCE, ADRESS_ETUDIANT,EMAIL_ETUDIANT, TELEPHONE_ETUDIANT, ANNEE_ETUD, NIVEAU,NOM_SPECIALITE, NOM_GROUPE FROM etudiant INNER JOIN groupe ON groupe.ID_GROUPE = etudiant.ID_GROUPE INNER JOIN specialite ON specialite.ID_SPECIALITE = etudiant.ID_SPECIALITE", cn);
            adapter.Fill(table);
            affichage_resultat.DataSource = table;
        }
        public DataTable SP_GET_ETUDIANT(string NVS, string NSP, string NG)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();

            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@niveau", MySqlDbType.Int32, 20);
            param[0].Value = NVS;

            param[1] = new MySqlParameter("@nom_spesialite", MySqlDbType.VarChar, 50);
            param[1].Value = NSP;

            param[2] = new MySqlParameter("@groupe", MySqlDbType.VarChar, 50);
            param[2].Value = NG;

            DataTable dt = new DataTable();
            dt = db.SelectData("SP_GET_ETUDIANT_ADMIN", param);
            db.Close();
            return dt;
        }

        public void DeleteEtudiant(string ID_ETUDIANT)
        {
            DATA_BASE.DataBase db = new DATA_BASE.DataBase();
            db.Open();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@id", MySqlDbType.VarChar, 20);
            param[0].Value = ID_ETUDIANT;

            db.ExecuteCommand("SP_DELETE_ETUDIANT", param);
            db.Close();
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
            Forms.administration admin = new administration();
            admin.Show();
            this.Close();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

        private void txt_cherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablecopy = table.Copy();
                DataView dv = tablecopy.DefaultView;
                dv.RowFilter = "ID_ETUDIANT+NOM_ETUDIANT+PRENOM_ETUDIANT+DATA_DE_NAISSANCE+LIEN_DE_NAISSANCE+ADRESS_ETUDIANT+EMAIL_ETUDIANT+TELEPHONE_ETUDIANT+NIVEAU+NOM_SPECIALITE+NOM_GROUPE Like '%" + txt_cherche.Text + "%'";
                affichage_resultat.DataSource = dv;
            }
            catch
            {
                return;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est-ce-que vous voulez supprimer cette étudiant ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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

					MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", email, "تعليمة عن الخذف", "مرحبا بك " + nom_us + " " + prenom_us + " في كلية العلوم الدقيقة والإعلام الآلي \n نعلمك عزيزي الطالب(ة) أنه تم حذفك نهائيا من الكلية بشكل رسمي .\n" + "تحت رقم التسجيل التالي :   " + id_us + "\n\nلأي استفسار أو استعلام الرجاء مراسلتنا عبر البريد الإلكتروني التالي gestion.departement.mail@gmail.com أو التقرب من مصالحة شؤون الطلبة بالكلية .\n وشكرا .");
					
					mail.IsBodyHtml = false;

					client.Send(mail);
				}
				catch
				{
					MessageBox.Show("Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				finally
				{
					DeleteEtudiant(affichage_resultat.CurrentRow.Cells[0].Value.ToString());
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

        private void txt_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = (txt_niveau.SelectedIndex + 1).ToString();
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

        public void txt_groupe_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable t = new DataTable();
            t.Clear();
            string N = txt_niveau.Text;
            string S = txt_specialit.Text;
            string G = txt_groupe.Text;
            t = SP_GET_ETUDIANT(N, S, G);
            affichage_resultat.DataSource = t;
            
        }

		private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
		{
			Projet_final_00.Cr_report_print.Cr_Form_certificat_scolarité certificat = new Cr_report_print.Cr_Form_certificat_scolarité();
			certificat.Show();
		}

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Cr_Form_Print_List_Etud liste = new Cr_Form_Print_List_Etud();
            liste.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1_Click(sender, e);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_modifier_Click(sender, e);
        }

        private void listeÉtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuFlatButton4_Click(sender, e);
        }

        private void certificatScolaritéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1_Click_1(sender, e);
        }

        private void supprimierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_supprimer_Click(sender, e);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            affichage_resultat.DataSource = null;
            this.Hide();
            Ajouter_etudiant etud = new Ajouter_etudiant();
            etud.txt_id_etudiant.Enabled = true;
            etud.Show();
            
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajouter_etudiant ae = new Ajouter_etudiant();
            ae.txt_id_etudiant.Text = affichage_resultat.CurrentRow.Cells[0].Value.ToString();
            ae.txt_nom_etudiant.Text = affichage_resultat.CurrentRow.Cells[1].Value.ToString();
            ae.txt_penom_etudiant.Text = affichage_resultat.CurrentRow.Cells[2].Value.ToString();
            ae.txt_date_naissance.Value = Convert.ToDateTime(affichage_resultat.CurrentRow.Cells[3].Value);
            ae.txt_lien_naissance.Text = affichage_resultat.CurrentRow.Cells[4].Value.ToString();
            ae.txt_address_etudiant.Text = affichage_resultat.CurrentRow.Cells[5].Value.ToString();
            ae.txt_email.Text = affichage_resultat.CurrentRow.Cells[6].Value.ToString();
            ae.txt_telephone.Text = affichage_resultat.CurrentRow.Cells[7].Value.ToString();
            ae.txt_date_etude.Value = Convert.ToDateTime(affichage_resultat.CurrentRow.Cells[8].Value);
            ae.txt_id_etudiant.Enabled = false;
            ae.txt_modifier.Width =360;
            niveau = affichage_resultat.CurrentRow.Cells[9].Value.ToString();
            specialite = affichage_resultat.CurrentRow.Cells[10].Value.ToString();
            groupe = affichage_resultat.CurrentRow.Cells[11].Value.ToString();
            if (Convert.ToInt16(niveau) == 1)
            {
                if ((specialite == "Mi"))
                {
                    ae.txt_id_specialite.Text = "SPE1MI";
                    ae.txt_id_groupe.Text = "GRP1MI" + groupe;
                }
                else
                {
                    ae.txt_id_specialite.Text = "SPE1MASTRE";
                    ae.txt_id_groupe.Text = "GRP1MASTRE" + groupe;
                }

            }
            else
            {
                if ((Convert.ToInt16(niveau) == 2))
                {
                    if (specialite == "Math")
                    {
                        ae.txt_id_specialite.Text = "SPE2M";
                        if (groupe == "G1") ae.txt_id_groupe.Text = "GRP2MG1";
                        if (groupe == "G2") ae.txt_id_groupe.Text = "GRP2MG2";
                        if (groupe == "G3") ae.txt_id_groupe.Text = "GRP2MG3";
                    }
                    if (specialite == "Mastre")
                    {
                        ae.txt_id_specialite.Text = "SPE2MASTRE";
                        if (groupe == "G1") ae.txt_id_groupe.Text = "GRP2MASTREG1";
                        if (groupe == "G2") ae.txt_id_groupe.Text = "GRP2MASTREG2";
                        if (groupe == "G3") ae.txt_id_groupe.Text = "GRP2MASTREG3";
                    }
                }
                else
                {
                    if ((Convert.ToInt16(niveau) == 2) && (specialite == "Info"))
                    {
                        ae.txt_id_specialite.Text = "SPE2I";
                        if (groupe == "G1") ae.txt_id_groupe.Text = "GRP2IG1";
                        if (groupe == "G2") ae.txt_id_groupe.Text = "GRP2IG2";
                        if (groupe == "G3") ae.txt_id_groupe.Text = "GRP2IG3";
                    }
                    else
                    {
                        if ((Convert.ToInt16(niveau) == 3) && (specialite == "Math"))
                        {
                            ae.txt_id_specialite.Text = "SPE3M";
                            if (groupe == "G1") ae.txt_id_groupe.Text = "GRP3MG1";
                            if (groupe == "G2") ae.txt_id_groupe.Text = "GRP3MG2";
                            if (groupe == "G3") ae.txt_id_groupe.Text = "GRP3MG3";
                        }
                        else
                        {
                            if ((Convert.ToInt16(niveau) == 3) && (specialite == "Info"))
                            {
                                ae.txt_id_specialite.Text = "SPE3I";
                                if (groupe == "G1") ae.txt_id_groupe.Text = "GRP3IG1";
                                if (groupe == "G2") ae.txt_id_groupe.Text = "GRP3IG2";
                                if (groupe == "G3") ae.txt_id_groupe.Text = "GRP3IG3";
                            }
                        }
                    }
                }
            }

            ae.txt_modifier.Text= "Modifier : "+affichage_resultat.CurrentRow.Cells[1].Value.ToString()+" "+ affichage_resultat.CurrentRow.Cells[2].Value.ToString();
            affichage_resultat.DataSource = null;
            ae.Show();
           
        }

    }
}
