using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_final_00.Forms
{
	public partial class Connection : Form
	{
		LOGINS.Class_Login log = new LOGINS.Class_Login();
		int mov;
		int movx;
		int movy;

		public Connection()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void nom_Enter(object sender, EventArgs e)
		{
			if (txt_nom.Text == "utilisateur")
			{
				txt_nom.Text = "";
				txt_nom.ForeColor = Color.Black;
			}
		}

		private void nom_Leave(object sender, EventArgs e)
		{
			if (txt_nom.Text == "")
			{
				txt_nom.Text = "utilisateur";
				txt_nom.ForeColor = Color.Gray;
			}
		}

		private void pass_Enter(object sender, EventArgs e)
		{
			if (txt_pass.Text == "Mot de passe")
			{
				txt_pass.Text = "";
				txt_pass.UseSystemPasswordChar = true;
				txt_pass.ForeColor = Color.Black;
			}
		}

		private void pass_Leave(object sender, EventArgs e)
		{
			if (txt_pass.Text == "")
			{
				txt_pass.UseSystemPasswordChar = false;
				txt_pass.Text = "Mot de passe";
				txt_pass.ForeColor = Color.Gray;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_nom.Text == "utilisateur")
                {
                    MessageBox.Show("S'il vous plaît entrer votre nom d'utilisateur  .. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Cursor = Cursors.Default;
                    txt_nom.Focus();
				}
                else
                {
                    if (txt_pass.Text == "Mot de passe")
                    {
                        MessageBox.Show("S'il vous plaît entrer votre mot de passe  .. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Cursor = Cursors.Default;
                        txt_pass.Focus();
					}
                    else
                    {
                        DataTable dt = log.LOGIN(txt_nom.Text, txt_pass.Text, type.Text);


                        if (dt.Rows.Count > 0)
                        {
							this.Cursor = Cursors.Default;
							if (type.Text == "Administration")
                            {
                                administration admin = new administration();
                                admin.Show();
                                this.Hide();
                                home.get_home.Hide();
                            }
                            else
                            {
                                if (type.Text == "Enseignants")
                                {
                                    enseignant ens = new enseignant();
                                    ens.Show();
                                    this.Hide();
                                    home.get_home.Hide();
                                }
                                else
                                {
                                    if (type.Text == "Etudiants")
                                    {
                                        etudiant etud = new etudiant();
                                        home hom = new home();
                                        hom.Hide();
                                        etud.Show();
                                        this.Hide();
                                        home.get_home.Hide();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'information d'entrée est fausse  .. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Cursor = Cursors.Default;
							txt_nom.Text = "utilisateur";
                            txt_pass.UseSystemPasswordChar = false;
                            txt_pass.Text = "Mot de passe";
                            txt_nom.Focus();
                        }

                    }
                }
            }
            catch
            {
                return;
            }                     	
		}

		private void Conx_admin_Load(object sender, EventArgs e)
		{
			//this.Location = Screen.AllScreens[1].WorkingArea.Location;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movx = e.X;
			movy = e.Y;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

        private void txt_nom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_pass.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_sort.PerformClick();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_enter.PerformClick();
            }
            if(e.KeyCode==Keys.Escape)
            {
                btn_sort.PerformClick();
            }
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
