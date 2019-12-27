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
	public partial class Math_S5 : Form
	{
		double res_intro, res_method, res_transformation, res_géométrie, res_ethique, res_u1, res_u2, res_u3, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_ethique.Text = cour_géométrie.Text = cour_intro.Text = cour_method.Text = cour_transformation.Text =
			td_géométrie.Text = td_intro.Text = td_method.Text = td_transformation.Text = tp_transformation.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_ethique.Text = moy_géométrie.Text = moy_intro.Text = moy_method.Text = moy_transformation.Text = moy_u1.Text = moy_u2.Text =
			moy_u3.Text = crid_ethique.Text = crid_géométrie.Text = crid_intro.Text = crid_method.Text = crid_transformation.Text =
			crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_ethique.ForeColor = moy_géométrie.ForeColor = moy_intro.ForeColor = moy_method.ForeColor = moy_transformation.ForeColor = Color.White;
		}

		private void cour_intro_Leave(object sender, EventArgs e)
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_intro = ((((Double.Parse(cour_intro.Text) * 2) + Double.Parse(td_intro.Text))) / 3);
				moy_intro.Text = Convert.ToString(res_intro);
				if (res_intro >= 10)
				{
					moy_intro.ForeColor = Color.Green;
					crid_intro.Text = "9";
				}
				else
				{
					moy_intro.ForeColor = Color.Red;
					crid_intro.Text = "0";
				}

				res_method = ((((Double.Parse(cour_method.Text) * 2) + Double.Parse(td_method.Text))) / 3);
				moy_method.Text = Convert.ToString(res_method);
				if (res_method >= 10)
				{
					moy_method.ForeColor = Color.Green;
					crid_method.Text = "9";
				}
				else
				{
					moy_method.ForeColor = Color.Red;
					crid_method.Text = "0";
				}

				res_transformation = ((((Double.Parse(cour_transformation.Text) * 2) + (Double.Parse(td_transformation.Text) + Double.Parse(tp_transformation.Text)) / 2)) / 3);
				moy_transformation.Text = Convert.ToString(res_transformation);
				if (res_transformation >= 10)
				{
					moy_transformation.ForeColor = Color.Green;
					crid_transformation.Text = "5";
				}
				else
				{
					moy_transformation.ForeColor = Color.Red;
					crid_transformation.Text = "0";
				}

				res_géométrie = ((((Double.Parse(cour_géométrie.Text) * 2) + Double.Parse(td_géométrie.Text))) / 3);
				moy_géométrie.Text = Convert.ToString(res_géométrie);
				if (res_géométrie >= 10)
				{
					moy_géométrie.ForeColor = Color.Green;
					crid_géométrie.Text = "5";
				}
				else
				{
					moy_géométrie.ForeColor = Color.Red;
					crid_géométrie.Text = "0";
				}

				res_ethique = Double.Parse(cour_ethique.Text);
				moy_ethique.Text = Convert.ToString(res_ethique);
				if (res_ethique >= 10)
				{
					moy_ethique.ForeColor = Color.Green;
					crid_ethique.Text = "2";
				}
				else
				{
					moy_ethique.ForeColor = Color.Red;
					crid_ethique.Text = "0";
				}
				
				res_u1 = ((res_intro * 5) + (res_method * 5)) / 10;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "18";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_intro.Text) + Double.Parse(crid_method.Text)).ToString();
				}
				
				res_u2 = ((res_transformation * 2) + (res_géométrie * 2)) / 4;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "10";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_transformation.Text) + Double.Parse(crid_géométrie.Text)).ToString();
				}

				res_u3 = (res_ethique);
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_ethique.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 10) + (res_u2 * 4) + (res_u3 * 2)) / 16).ToString();
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

		public Math_S5()
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
