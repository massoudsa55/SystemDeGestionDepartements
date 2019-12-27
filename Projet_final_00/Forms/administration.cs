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

namespace Projet_final_00.Forms
{
	public partial class administration : Form
	{
        MySqlConnection cn = new MySqlConnection("Server=" + Properties.Settings.Default.Server + "; Port=" +
                Properties.Settings.Default.Port + "; DataBase=" + Properties.Settings.Default.Database + "; uid=" +
                Properties.Settings.Default.User + "; passowrd=" + Properties.Settings.Default.Password + "");
        DataTable table = new DataTable();
        public administration()
		{
			InitializeComponent();
			data_tm.Text = DateTime.Now.ToString("D");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			home.get_home.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void bun4_Click(object sender, EventArgs e)
		{
            Forms.admin.Gestion_etudiant get = new Forms.admin.Gestion_etudiant();
            get.groupBox3.Visible = true;
            get.Show();
            this.Hide();
            
		}

		private void bunifuTileButton3_Click(object sender, EventArgs e)
		{
			Forms.admin.Gestion_enseinant gen = new Forms.admin.Gestion_enseinant();
            gen.groupBox3.Visible = true;
            gen.Show();
            this.Hide();
        }

		private void bunifuTileButton1_Click(object sender, EventArgs e)
		{
			Forms.admin.Gestion_emploi gemploi = new Forms.admin.Gestion_emploi();
			gemploi.ShowDialog();
		}

		private void bunifuTileButton6_Click(object sender, EventArgs e)
		{
			Forms.admin.Gestion_notes genot = new Forms.admin.Gestion_notes();
            genot.btn_imprimier.Visible = true;
            genot.btn_supprimier_note.Visible = true;
            genot.groupBox1.Visible = true;
            genot.panel5.Width = 1086;
            genot.btn_modifier_stocke.Location = new Point(299, 34);
            genot.Width = 1100;
            genot.ShowDialog();
		}

		private void bunifuTileButton2_Click(object sender, EventArgs e)
		{
			home.get_home.Show();
			this.Hide();
		}

		private void bunifuTileButton5_Click(object sender, EventArgs e)
		{
			Forms.admin.Confiduration config = new Forms.admin.Confiduration();
			config.ShowDialog();
		}

		private void config_server(object sender, EventArgs e)
		{
			Forms.Configue_Server server = new Configue_Server();
			server.ShowDialog();
		}

		private void crToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Backup File (*.sql) | *.sql ";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    using (cn)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = cn;
                                cn.Open();
                                mb.ExportToFile(sfd.FileName);
                                cn.Close();
                            }
                        }
                    }
                    MessageBox.Show("Enregistrement succès", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Échec de l'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
		}

        private void restuarationDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    using (cn)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = cn;
                                cn.Open();
                                mb.ImportFromFile(ofd.FileName);
                                cn.Close();
                            }
                        }
                    }
                    MessageBox.Show("Importation réussie", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("Échec de l'importation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
