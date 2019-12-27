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
	public partial class Configue_Server : Form
	{
		public Configue_Server()
		{
			InitializeComponent();
            txt_server.Text = Properties.Settings.Default.Server;
            txt_porte.Text = Properties.Settings.Default.Port;
            txt_database.Text = Properties.Settings.Default.Database;
            txt_user.Text = Properties.Settings.Default.User;
            txt_password.Text = Properties.Settings.Default.Password;

        }

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_server.Text;
            Properties.Settings.Default.Port = txt_porte.Text;
            Properties.Settings.Default.Database = txt_database.Text;
            Properties.Settings.Default.User = txt_user.Text;
            Properties.Settings.Default.Password = txt_password.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Enregistrement succès", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_porte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
