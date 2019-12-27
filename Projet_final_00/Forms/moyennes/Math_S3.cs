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
	public partial class Math_S3 : Form
	{
		double res_analyse3, res_algebre3, res_topo, res_logique, res_outprog, res_analysenum, res_histoir, res_u1, res_u2, res_u3, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void cour_analyse3_Leave(object sender, EventArgs e)
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

		public Math_S3()
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_analyse3 = ((((Double.Parse(cour_analyse3.Text) * 2) + Double.Parse(td_analyse3.Text))) / 3);
				moy_analyse3.Text = Convert.ToString(res_analyse3);
				if (res_analyse3 >= 10)
				{
					moy_analyse3.ForeColor = Color.Green;
					crid_analyse3.Text = "7";
				}
				else
				{
					moy_analyse3.ForeColor = Color.Red;
					crid_analyse3.Text = "0";
				}
				res_algebre3 = (((Double.Parse(cour_algéber3.Text) * 2) + (Double.Parse(td_algéber3.Text))) / 3);
				moy_algeber3.Text = Convert.ToString(res_algebre3);
				if (res_algebre3 >= 10)
				{
					moy_algeber3.ForeColor = Color.Green;
					crid_algeber3.Text = "5";
				}
				else
				{
					moy_algeber3.ForeColor = Color.Red;
					crid_algeber3.Text = "0";
				}
				res_topo = (((Double.Parse(cour_topo.Text) * 2) + (Double.Parse(td_topo.Text))) / 3);
				moy_topo.Text = Convert.ToString(res_topo);
				if (res_topo >= 10)
				{
					moy_topo.ForeColor = Color.Green;
					crid_topo.Text = "6";
				}
				else
				{
					moy_topo.ForeColor = Color.Red;
					crid_topo.Text = "0";
				}
				res_logique = ((((Double.Parse(cour_logique.Text) * 2) + Double.Parse(td_logique.Text))) / 3);
				moy_logique.Text = Convert.ToString(res_logique);
				if (res_logique >= 10)
				{
					moy_logique.ForeColor = Color.Green;
					crid_logique.Text = "3";
				}
				else
				{
					moy_logique.ForeColor = Color.Red;
					crid_logique.Text = "0";
				}


				res_outprog = (((Double.Parse(cour_outprog.Text) * 2) + Double.Parse(tp_outprog.Text))) / 3;
				moy_outprog.Text = Convert.ToString(res_outprog);
				if (res_outprog >= 10)
				{
					moy_outprog.ForeColor = Color.Green;
					crid_outprog.Text = "3";
				}
				else
				{
					moy_outprog.ForeColor = Color.Red;
					crid_outprog.Text = "0";
				}

				res_analysenum = (((Double.Parse(cour_analysenum.Text) * 2) + (Double.Parse(td_analysenum.Text) + Double.Parse(tp_analysenum.Text)) / 2)) / 3;
				moy_analysenum.Text = Convert.ToString(res_analysenum);
				if (res_analysenum >= 10)
				{
					moy_analysenum.ForeColor = Color.Green;
					crid_analysenum.Text = "4";
				}
				else
				{
					moy_analysenum.ForeColor = Color.Red;
					crid_analysenum.Text = "0";
				}

				res_histoir = Double.Parse(cour_histoir.Text);
				moy_histoir.Text = Convert.ToString(res_histoir);
				if (res_histoir >= 10)
				{
					moy_histoir.ForeColor = Color.Green;
					crid_histoir.Text = "2";
				}
				else
				{
					moy_histoir.ForeColor = Color.Red;
					crid_histoir.Text = "0";
				}

				res_u1 = ((res_algebre3 * 2) + (res_analyse3 * 4) + (res_topo * 3)) / 9;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "18";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_analyse3.Text) + Double.Parse(crid_algeber3.Text) + Double.Parse(crid_topo.Text)).ToString();
				}

				res_u2 = ((res_logique * 2) + (res_outprog * 1) + (res_analysenum * 2)) / 5;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "10";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_logique.Text) + Double.Parse(crid_outprog.Text) + Double.Parse(crid_analysenum.Text)).ToString();
				}

				res_u3 = (res_histoir);
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_histoir.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 9) + (res_u2 * 5) + res_u3) / 15).ToString();
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

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_analyse3.Text = td_analyse3.Text = cour_algéber3.Text = td_algéber3.Text = cour_topo.Text = td_topo.Text = cour_logique.Text = td_logique.Text =
			cour_outprog.Text = tp_outprog.Text = td_analysenum.Text = tp_analysenum.Text = cour_analysenum.Text = td_histoir.Text = cour_histoir.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_analyse3.Text = moy_algeber3.Text = moy_logique.Text = moy_topo.Text = moy_outprog.Text = moy_analysenum.Text = moy_histoir.Text =
			crid_analyse3.Text = crid_algeber3.Text = crid_logique.Text = crid_topo.Text = crid_outprog.Text = crid_analysenum.Text = crid_histoir.Text =
			moy_u1.Text = moy_u2.Text = moy_u3.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_analyse3.ForeColor = moy_algeber3.ForeColor = moy_logique.ForeColor = moy_topo.ForeColor = moy_analysenum.ForeColor =
			moy_outprog.ForeColor = moy_histoir.ForeColor = Color.GhostWhite;
		}
	}
}
