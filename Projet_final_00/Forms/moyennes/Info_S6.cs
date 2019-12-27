using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00.Forms.moyennes
{
	public partial class Info_S6 : Form
	{
		double res_appmobil, res_sécur, res_info, res_crypto, res_redaction, res_projetfin, res_u1, res_u2, res_u3, res_u4, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_appmobil = (Double.Parse(cour_appmobil.Text) / 2) + ((Double.Parse(td_appmobil.Text) + Double.Parse(tp_appmobil.Text)) / 2) / 2;
				moy_appmobil.Text = Convert.ToString(res_appmobil);
				if (res_appmobil >= 10)
				{
					moy_appmobil.ForeColor = Color.Green;
					crid_appmobil.Text = "5";
				}
				else
				{
					moy_appmobil.ForeColor = Color.Red;
					crid_appmobil.Text = "0";
				}

				res_sécur = ((Double.Parse(cour_sécur.Text) / 2) + (Double.Parse(td_sécur.Text) / 2));
				moy_sécur.Text = Convert.ToString(res_sécur);
				if (res_sécur >= 10)
				{
					moy_sécur.ForeColor = Color.Green;
					crid_sécur.Text = "5";
				}
				else
				{
					moy_sécur.ForeColor = Color.Red;
					crid_sécur.Text = "0";
				}

				res_u1 = ((res_appmobil * 3) + (res_sécur * 3)) / 6;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "10";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_appmobil.Text) + Double.Parse(crid_sécur.Text)).ToString();
				}

				res_info = ((Double.Parse(cour_info.Text) / 2) + (Double.Parse(td_info.Text) / 2));
				moy_info.Text = Convert.ToString(res_info);
				if (res_info >= 10)
				{
					moy_info.ForeColor = Color.Green;
					crid_info.Text = "4";
				}
				else
				{
					moy_info.ForeColor = Color.Red;
					crid_info.Text = "0";
				}

				res_crypto = (Double.Parse(cour_crypto.Text) / 2) + ((Double.Parse(td_crypto.Text) + Double.Parse(tp_crypto.Text)) / 2) / 2;
				moy_crypto.Text = Convert.ToString(res_crypto);
				if (res_crypto >= 10)
				{
					moy_crypto.ForeColor = Color.Green;
					crid_crypto.Text = "4";
				}
				else
				{
					moy_crypto.ForeColor = Color.Red;
					crid_crypto.Text = "0";
				}

				res_u2 = ((res_info * 2) + (res_crypto * 2)) / 4;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "8";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_info.Text) + Double.Parse(crid_crypto.Text)).ToString();
				}

				res_redaction = (Double.Parse(cour_redaction.Text));
				moy_redaction.Text = Convert.ToString(res_redaction);
				if (res_redaction >= 10)
				{
					moy_redaction.ForeColor = Color.Green;
					crid_redaction.Text = "2";
				}
				else
				{
					moy_redaction.ForeColor = Color.Red;
					crid_redaction.Text = "0";
				}

				res_u3 = res_redaction;
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text = "0";
				}

				res_projetfin = (Double.Parse(cour_projetfin.Text));
				moy_projetfin.Text = Convert.ToString(res_projetfin);
				if (res_projetfin >= 10)
				{
					moy_projetfin.ForeColor = Color.Green;
					crid_projetfin.Text = "10";
				}
				else
				{
					moy_projetfin.ForeColor = Color.Red;
					crid_projetfin.Text = "0";
				}

				res_u4 = res_projetfin;
				moy_u4.Text = Convert.ToString(res_u4);
				if (res_u4 >= 10)
				{
					crid_u4.Text = "10";
				}
				else
				{
					crid_u4.Text = "0";
				}

				moyenne_genérel.Text = (((res_u1 * 6) + (res_u2 * 4) + (res_u3) + (res_u4 * 4)) / 15).ToString();
				moy_gen = Double.Parse(moyenne_genérel.Text);
				if (moy_gen >= 10)
				{
					moyenne_genérel.ForeColor = Color.White;
					crédit_total.ForeColor = Color.White;
					crédit_total.Text = "30";
				}
				else
				{
					crédit_total.ForeColor = Color.Red;
					crédit_total.Text = (Double.Parse(crid_u1.Text) + Double.Parse(crid_u2.Text) + Double.Parse(crid_u3.Text)).ToString();
				}
			}
			catch
			{
				MessageBox.Show("utilisé le simbole ' , ' comme le point ' . ' ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
}

		private void cour_appmobil_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
			}
		}

		private void cour_appmobil_Enter(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "0")
			{
				te.Text = "";
			}
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_appmobil.Text = cour_crypto.Text = cour_info.Text = cour_projetfin.Text = cour_redaction.Text = cour_sécur.Text =
			td_appmobil.Text = td_crypto.Text = td_info.Text = td_sécur.Text = tp_appmobil.Text = tp_crypto.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_appmobil.Text = moy_crypto.Text = moy_info.Text = moy_projetfin.Text = moy_redaction.Text = moy_sécur.Text = moy_u1.Text =
			moy_u2.Text = moy_u3.Text = moy_u4.Text = crid_appmobil.Text = crid_crypto.Text = crid_info.Text = crid_projetfin.Text =
			crid_redaction.Text = crid_sécur.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = crid_u4.Text = "?";

			moy_appmobil.ForeColor = moy_crypto.ForeColor = moy_info.ForeColor = moy_projetfin.ForeColor =
			moy_redaction.ForeColor = moy_sécur.ForeColor = Color.White;
		}

		public Info_S6()
		{
			InitializeComponent();
			data_tm.Text = DateTime.Now.ToString("D");

			int mon = DateTime.Now.Month;

			if (mon > 9)
			{
				int dt = DateTime.Now.Year;
				int dt1 = dt + 1;
				date.Text = (dt.ToString() + " / " + dt1.ToString());
			}
			if (mon < 9)
			{
				int dt = DateTime.Now.Year;
				int dt1 = dt - 1;
				date.Text = (dt1.ToString() + " / " + dt.ToString());
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
