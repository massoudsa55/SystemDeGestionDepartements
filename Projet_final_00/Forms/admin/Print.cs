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
	public partial class Print : Form
	{
		public Print()
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

		public DataTable SP_GET_NOM_MODULE()
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			DataTable dt = new DataTable();
			dt = db.SelectData("SP_GET_NOM_MODULE", null);
			db.Close();
			return dt;
		}

		public DataTable SP_SP_GET_NOTE_CRYSTAL_REPORT(string N, string S, string G, string M)
		{
			DATA_BASE.DataBase db = new DATA_BASE.DataBase();
			MySqlParameter[] param = new MySqlParameter[4];

			param[0] = new MySqlParameter("@niveau", MySqlDbType.Int16, 20);
			param[0].Value = N;

			param[1] = new MySqlParameter("@specialite", MySqlDbType.VarChar, 50);
			param[1].Value = S;

			param[2] = new MySqlParameter("@nom_grp", MySqlDbType.VarChar, 50);
			param[2].Value = G;

			param[3] = new MySqlParameter("@nom_model", MySqlDbType.VarChar, 50);
			param[3].Value = M;

			DataTable dt = new DataTable();
			dt = db.SelectData("SP_SP_GET_NOTE_CRYSTAL_REPORT", param);
			db.Close();
			return dt;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txt_niveau_SelectedIndexChanged(object sender, EventArgs e)
		{
			string n = (txt_niveau.SelectedIndex + 1).ToString();
			txt_spec.DataSource = SP_GET_SPECIALITE(n);
			txt_spec.DisplayMember = "NOM_SPECIALITE";
			txt_spec.ValueMember = "NOM_SPECIALITE";
		}

		private void txt_spec_SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_group.DataSource = SP_GET_GROUPE();
			txt_group.DisplayMember = "NOM_GROUPE";
			txt_group.ValueMember = "NOM_GROUPE";
			txt_Model.DataSource = SP_GET_NOM_MODULE();
			txt_Model.DisplayMember = "NOM_MODULE";
			txt_Model.ValueMember = "ID_MODULE";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.Credentials = new NetworkCredential("gestion.departement.mail@gmail.com", "gestion123123");
			client.EnableSsl = true;

			//yacinebakhti1mi @gmail.com   massoudsa55@gmail.com  oussamabengahtani@gmail.com
			MailMessage mail = new MailMessage("gestion.departement.mail@gmail.com", "massoudsa55@gmail.com",
			"test", "لقد تم تسجيلك بنجاح في كلية العلوم الدقيقة والإعلام الآلي");

			mail.IsBodyHtml = false;

			client.Send(mail);
			MessageBox.Show("sent succée ", "send mail", MessageBoxButtons.OK, MessageBoxIcon.Information);

			/*try
			{
				this.Cursor = Cursors.Default;
				CR_Print.CR_nots rep_print = new CR_Print.CR_nots();
				CR_forms.CR_Print_Notes rep_form_print = new CR_forms.CR_Print_Notes();

				rep_print.SetDataSource(SP_SP_GET_NOTE_CRYSTAL_REPORT(Convert.ToString(txt_niveau.SelectedValue), Convert.ToString(txt_spec.SelectedValue),
				Convert.ToString(txt_group.SelectedValue), Convert.ToString(txt_Model.SelectedValue)));

				rep_form_print.crystalReportViewer1.ReportSource = rep_print;
				rep_form_print.ShowDialog();
				this.Cursor = Cursors.Default;
			}
			catch
			{
				return;
			}*/
		}
	}
}
