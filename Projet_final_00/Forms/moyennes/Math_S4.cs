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
	public partial class Math_S4 : Form
	{
		double res_analyse4, res_algebre4, res_anacomplexe, res_geometrie, res_proba, res_analysenum, res_appmath , res_u1, res_u2, res_u3, moy_gen;

		private void cour_analyse4_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_analyse4 = ((((Double.Parse(cour_analyse4.Text) * 2) + Double.Parse(td_analyse4.Text))) / 3);
				moy_analyse4.Text = Convert.ToString(res_analyse4);
				if (res_analyse4 >= 10)
				{
					moy_analyse4.ForeColor = Color.Green;
					crid_analyse4.Text = "8";
				}
				else
				{
					moy_analyse4.ForeColor = Color.Red;
					crid_analyse4.Text = "0";
				}
				res_algebre4 = (((Double.Parse(cour_algéber4.Text) * 2) + (Double.Parse(td_algéber4.Text))) / 3);
				moy_algeber4.Text = Convert.ToString(res_algebre4);
				if (res_algebre4 >= 10)
				{
					moy_algeber4.ForeColor = Color.Green;
					crid_algeber4.Text = "5";
				}
				else
				{
					moy_algeber4.ForeColor = Color.Red;
					crid_algeber4.Text = "0";
				}
				res_anacomplexe = (((Double.Parse(cour_anacomplexe.Text) * 2) + (Double.Parse(td_aanacomplexe.Text)) ) / 3);
				moy_anacomplexe.Text = Convert.ToString(res_anacomplexe);
				if (res_anacomplexe >= 10)
				{
					moy_anacomplexe.ForeColor = Color.Green;
					crid_anacomplexe.Text = "5";
				}
				else
				{
					moy_anacomplexe.ForeColor = Color.Red;
					crid_anacomplexe.Text = "0";
				}
				res_geometrie = ((((Double.Parse(cour_geometrie.Text) * 2) + Double.Parse(td_geometrie.Text))) / 3);
				moy_geometrie.Text = Convert.ToString(res_geometrie);
				if (res_geometrie >= 10)
				{
					moy_geometrie.ForeColor = Color.Green;
					crid_geometrie.Text = "3";
				}
				else
				{
					moy_geometrie.ForeColor = Color.Red;
					crid_geometrie.Text = "0";
				}


				res_proba = (((Double.Parse(cour_proba.Text) * 2) + Double.Parse(tp_proba.Text))) / 3;
				moy_proba.Text = Convert.ToString(res_proba);
				if (res_proba >= 10)
				{
					moy_proba.ForeColor = Color.Green;
					crid_proba.Text = "3";
				}
				else
				{
					moy_proba.ForeColor = Color.Red;
					crid_proba.Text = "0";
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

				res_appmath = (((Double.Parse(cour_appmath.Text) * 2) + Double.Parse(td_appmath.Text))) / 3;
				moy_appmath.Text = Convert.ToString(res_appmath);
				if (res_appmath >= 10)
				{
					moy_appmath.ForeColor = Color.Green;
					crid_appmath.Text = "2";
				}
				else
				{
					moy_appmath.ForeColor = Color.Red;
					crid_appmath.Text = "0";
				}

				res_u1 = ((res_algebre4 * 3) + (res_analyse4 * 4) + (res_anacomplexe * 3)) / 10;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "18";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_analyse4.Text) + Double.Parse(crid_algeber4.Text) + Double.Parse(crid_anacomplexe.Text)).ToString();
				}

				res_u2 = ((res_geometrie * 2) + (res_proba * 2) + (res_analysenum * 2)) / 6;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "10";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_geometrie.Text) + Double.Parse(crid_proba.Text) + Double.Parse(crid_analysenum.Text)).ToString();
				}

				res_u3 = (res_appmath);
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_appmath.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 10) + (res_u2 * 6) + res_u3) / 17).ToString();
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
			cour_analyse4.Text = td_analyse4.Text = cour_algéber4.Text = td_algéber4.Text = cour_anacomplexe.Text = td_aanacomplexe.Text = cour_geometrie.Text = td_geometrie.Text =
			cour_proba.Text = tp_proba.Text = td_analysenum.Text = tp_analysenum.Text = cour_analysenum.Text = td_appmath.Text = cour_appmath.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_analyse4.Text = moy_algeber4.Text = moy_anacomplexe.Text = moy_analysenum.Text = moy_appmath.Text = moy_geometrie.Text =
			moy_proba.Text = crid_analyse4.Text = crid_algeber4.Text = crid_anacomplexe.Text = crid_appmath.Text = crid_analysenum.Text =
			crid_proba.Text = crid_geometrie.Text = moy_u1.Text = moy_u2.Text = moy_u3.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_analyse4.ForeColor = moy_algeber4.ForeColor = moy_anacomplexe.ForeColor = moy_appmath.ForeColor = moy_analysenum.ForeColor =
			moy_geometrie.ForeColor = moy_proba.ForeColor = Color.GhostWhite;
		}

		private void cour_analyse3_Click(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "0")
			{
				te.Text = "";
			}
		}

		public Math_S4()
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

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
