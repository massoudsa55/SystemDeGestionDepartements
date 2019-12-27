using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00.Forms
{
	public partial class Déclaration : Form
	{
		public Déclaration()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btn_envoyer_Click(object sender, EventArgs e)
		{
			if (txt_email.Text == string.Empty || txt_pass.Text == string.Empty || txt_objet.Text == string.Empty || txt_message.Text == string.Empty)
			{
				MessageBox.Show("S'il vous plaît remplire tout les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					string email = txt_email.Text;
					string pass = txt_pass.Text;
					string objet = txt_objet.Text;
					string message = txt_message.Text;

					SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
					client.Credentials = new NetworkCredential(email, pass);
					client.EnableSsl = true;

					MailMessage mail = new MailMessage(email, "gestion.departement.mail@gmail.com", objet, message);
					mail.IsBodyHtml = false;
					client.Send(mail);
					MessageBox.Show("Votre message a été envoyé succès", "Evoyer", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txt_email.Text = "Adresse email";    txt_email.ForeColor = Color.Silver;
					txt_pass.Text = "Mot de passe";      txt_pass.ForeColor = Color.Silver; txt_pass.isPassword = false;
					txt_objet.Text = "Objet";            txt_objet.ForeColor = Color.Silver;
					txt_message.Text = ""; 
				}
				catch
				{
					MessageBox.Show("Erreur d'envoi ! \n Vérifier votre connexion au réseau. vérifier que la permission d’accéder au Web.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txt_email.Text = "Adresse email";    txt_email.ForeColor = Color.Silver;
					txt_pass.Text = "Mot de passe";      txt_pass.ForeColor = Color.Silver; txt_pass.isPassword = false;
					txt_objet.Text = "Objet";            txt_objet.ForeColor = Color.Silver;
					txt_message.Text = "";
				}
			}
		}

		private void txt_email_Enter(object sender, EventArgs e)
		{
			if (txt_email.Text == "Adresse email")
			{
				txt_email.Text = "";
				txt_email.ForeColor = Color.White;
			}
		}

		private void txt_email_Leave(object sender, EventArgs e)
		{
			if (txt_email.Text == "")
			{
				txt_email.Text = "Adresse email";
				txt_email.ForeColor = Color.Silver;
			}
		}

		private void txt_objet_Enter(object sender, EventArgs e)
		{
			if (txt_objet.Text == "Objet")
			{
				txt_objet.Text = "";
				txt_objet.ForeColor = Color.White;
			}
		}

		private void txt_objet_Leave(object sender, EventArgs e)
		{
			if (txt_objet.Text == "")
			{
				txt_objet.Text = "Objet";
				txt_objet.ForeColor = Color.Silver;
			}
		}

		private void txt_pass_Enter(object sender, EventArgs e)
		{
			if (txt_pass.Text == "Mot de passe")
			{
				txt_pass.Text = "";
				txt_pass.isPassword = true;
				txt_pass.ForeColor = Color.White;
			}
		}

		private void txt_pass_Leave(object sender, EventArgs e)
		{
			if (txt_pass.Text == "")
			{
				txt_pass.isPassword = false;
				txt_pass.Text = "Mot de passe";
				txt_pass.ForeColor = Color.Silver;
			}
		}

		private void show_CheckedChanged(object sender, EventArgs e)
		{
			if (show.Checked == true)
			{
				txt_pass.isPassword = false;
			}
			else
			{
				txt_pass.isPassword = true;
			}
		}
	}
}
