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
	public partial class Info_S3 : Form
	{
		double res_aso, res_asd, res_logique, res_poo, res_si, res_thl, res_eng, res_u1, res_u2, res_u3, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void cour_aso_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_asd.Text = td_asd.Text = tp_asd.Text = cour_aso.Text = tp_aso.Text = cour_logique.Text = td_logique.Text = cour_si.Text = td_si.Text =
			tp_si.Text = cour_poo.Text = td_poo.Text = tp_poo.Text = cour_thl.Text = td_thl.Text = cour_eng.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_asd.Text = moy_aso.Text = moy_logique.Text = moy_poo.Text = moy_si.Text = moy_thl.Text = moy_eng.Text =
			crid_asd.Text = crid_aso.Text = crid_logique.Text = crid_poo.Text = crid_si.Text = crid_thl.Text = crid_eng.Text =
			moy_u1.Text = moy_u2.Text = moy_u3.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_aso.ForeColor = moy_asd.ForeColor = moy_logique.ForeColor = moy_poo.ForeColor = moy_si.ForeColor =
			moy_thl.ForeColor = moy_eng.ForeColor = Color.GhostWhite;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_aso = ((((Double.Parse(cour_aso.Text) * 2) + Double.Parse(tp_aso.Text))) / 3);
				moy_aso.Text = Convert.ToString(res_aso);
				if (res_aso >= 10)
				{
					moy_aso.ForeColor = Color.Green;
					crid_aso.Text = "5";
				}
				else
				{
					moy_aso.ForeColor = Color.Red;
					crid_aso.Text = "0";
				}
				res_asd = ((((Double.Parse(cour_asd.Text) * 2) + (Double.Parse(td_asd.Text) + Double.Parse(tp_asd.Text)) / 2)) / 3);
				moy_asd.Text = Convert.ToString(res_asd);
				if (res_asd >= 10)
				{
					moy_asd.ForeColor = Color.Green;
					crid_asd.Text = "6";
				}
				else
				{
					moy_asd.ForeColor = Color.Red;
					crid_asd.Text = "0";
				}

				res_logique = ((((Double.Parse(cour_logique.Text) * 2) + Double.Parse(td_logique.Text))) / 3);
				moy_logique.Text = Convert.ToString(res_logique);
				if (res_logique >= 10)
				{
					moy_logique.ForeColor = Color.Green;
					crid_logique.Text = "4";
				}
				else
				{
					moy_logique.ForeColor = Color.Red;
					crid_logique.Text = "0";
				}

				res_poo = ((((Double.Parse(cour_poo.Text) * 2) + (Double.Parse(td_poo.Text) + Double.Parse(tp_poo.Text)) / 2)) / 3);
				moy_poo.Text = Convert.ToString(res_poo);
				if (res_poo >= 10)
				{
					moy_poo.ForeColor = Color.Green;
					crid_poo.Text = "5";
				}
				else
				{
					moy_poo.ForeColor = Color.Red;
					crid_poo.Text = "0";
				}
				res_si = ((((Double.Parse(cour_si.Text) * 2) + (Double.Parse(td_si.Text) + Double.Parse(tp_si.Text)) / 2)) / 3);
				moy_si.Text = Convert.ToString(res_si);
				if (res_si >= 10)
				{
					moy_si.ForeColor = Color.Green;
					crid_si.Text = "4";
				}
				else
				{
					moy_si.ForeColor = Color.Red;
					crid_si.Text = "0";
				}

				res_thl = ((((Double.Parse(cour_thl.Text) * 2) + Double.Parse(td_thl.Text))) / 3);
				moy_thl.Text = Convert.ToString(res_thl);
				if (res_thl >= 10)
				{
					moy_thl.ForeColor = Color.Green;
					crid_thl.Text = "4";
				}
				else
				{
					moy_thl.ForeColor = Color.Red;
					crid_thl.Text = "0";
				}

				res_eng = Double.Parse(cour_eng.Text);
				moy_eng.Text = Convert.ToString(res_eng);
				if (res_eng >= 10)
				{
					moy_eng.ForeColor = Color.Green;
					crid_eng.Text = "2";
				}
				else
				{
					moy_eng.ForeColor = Color.Red;
					crid_eng.Text = "0";
				}

				res_u1 = ((res_aso * 2) + (res_asd * 3) + (res_logique * 2)) / 7;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "15";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_aso.Text) + Double.Parse(crid_asd.Text) + Double.Parse(crid_logique.Text)).ToString();
				}

				res_u2 = ((res_poo * 3) + (res_si * 3) + (res_thl * 2)) / 8;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "13";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_poo.Text) + Double.Parse(crid_si.Text) + Double.Parse(crid_thl.Text)).ToString();
				}

				res_u3 = (res_eng);
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_eng.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 7) + (res_u2 * 8) + (res_u3 )) / 16).ToString();
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

		public Info_S3()
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

		private void efface_text(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "0")
			{
				te.Text = "";
			}
		}
	}
}
