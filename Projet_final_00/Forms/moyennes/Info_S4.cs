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
	public partial class Info_S4 : Form
	{
		double res_basedonne, res_gl, res_se, res_dvweb, res_reseau, res_thg, res_eng, res_asp, res_u1, res_u2, res_u3, moy_gen;

		private void cour_basedonne_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
			}
		}

		private void cour_basedonne_Click(object sender, EventArgs e)
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
				res_basedonne = ((((Double.Parse(cour_basedonne.Text) * 2) + (Double.Parse(td_basedonne.Text) + Double.Parse(tp_basedonne.Text)) / 2)) / 3);
				moy_basedonne.Text = Convert.ToString(res_basedonne);
				if (res_basedonne >= 10)
				{
					moy_basedonne.ForeColor = Color.Green;
					crid_basedonne.Text = "4";
				}
				else
				{
					moy_basedonne.ForeColor = Color.Red;
					crid_basedonne.Text = "0";
				}

				res_gl = ((((Double.Parse(cour_gl.Text) * 2) + Double.Parse(td_gl.Text))) / 3);
				moy_gl.Text = Convert.ToString(res_gl);
				if (res_gl >= 10)
				{
					moy_gl.ForeColor = Color.Green;
					crid_gl.Text = "4";
				}
				else
				{
					moy_gl.ForeColor = Color.Red;
					crid_gl.Text = "0";
				}

				res_se = ((((Double.Parse(cour_se1.Text) * 2) + (Double.Parse(td_se1.Text) + Double.Parse(tp_se1.Text)) / 2)) / 3);
				moy_se1.Text = Convert.ToString(res_se);
				if (res_se >= 10)
				{
					moy_se1.ForeColor = Color.Green;
					crid_se1.Text = "5";
				}
				else
				{
					moy_se1.ForeColor = Color.Red;
					crid_se1.Text = "0";
				}

				res_dvweb = ((((Double.Parse(cour_dvweb.Text) * 2) + Double.Parse(tp_dvweb.Text))) / 3);
				moy_dvweb.Text = Convert.ToString(res_dvweb);
				if (res_dvweb >= 10)
				{
					moy_dvweb.ForeColor = Color.Green;
					crid_dvweb.Text = "4";
				}
				else
				{
					moy_dvweb.ForeColor = Color.Red;
					crid_dvweb.Text = "0";
				}

				res_reseau = ((((Double.Parse(cour_reseau.Text) * 2) + (Double.Parse(td__reseau.Text) + Double.Parse(tp__reseau.Text)) / 2)) / 3);
				moy_reseau.Text = Convert.ToString(res_reseau);
				if (res_reseau >= 10)
				{
					moy_reseau.ForeColor = Color.Green;
					crid_reseau.Text = "5";
				}
				else
				{
					moy_reseau.ForeColor = Color.Red;
					crid_reseau.Text = "0";
				}

				res_thg = ((((Double.Parse(cour_thg.Text) * 2) + Double.Parse(td_thg.Text))) / 3);
				moy_thg.Text = Convert.ToString(res_thg);
				if (res_thg >= 10)
				{
					moy_thg.ForeColor = Color.Green;
					crid_thg.Text = "4";
				}
				else
				{
					moy_thg.ForeColor = Color.Red;
					crid_thg.Text = "0";
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

				res_asp = Double.Parse(cour_asp_jur.Text);
				moy_asp.Text = Convert.ToString(res_asp);
				if (res_asp >= 10)
				{
					moy_asp.ForeColor = Color.Green;
					crid_asp.Text = "2";
				}
				else
				{
					moy_asp.ForeColor = Color.Red;
					crid_asp.Text = "0";
				}

				res_u1 = ((res_basedonne * 2) + (res_gl * 2) + (res_se * 3)) / 7;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "13";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_basedonne.Text) + Double.Parse(crid_gl.Text) + Double.Parse(crid_se1.Text)).ToString();
				}

				res_u2 = ((res_dvweb * 2) + (res_reseau * 3) + (res_thg * 2)) / 7;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "13";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_dvweb.Text) + Double.Parse(crid_reseau.Text) + Double.Parse(crid_thg.Text)).ToString();
				}

				res_u3 = ((res_eng) + (res_asp)) / 2;
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "4";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_eng.Text) + Double.Parse(crid_asp.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 7) + (res_u2 * 7) + (res_u3 * 2)) / 16).ToString();
				moy_gen = Double.Parse(moyenne_genérel.Text);
				if (moy_gen >= 10)
				{
					moyenne_genérel.ForeColor = Color.White;
					crédit_total.ForeColor = Color.White;
					crédit_total.Text = "30";
				}
				else
				{
					moyenne_genérel.ForeColor = Color.White;
					crédit_total.ForeColor = Color.Red;
					crédit_total.Text = (Double.Parse(crid_u1.Text) + Double.Parse(crid_u2.Text) +
										 Double.Parse(crid_u3.Text)).ToString();
				}
			}
			catch
			{
				MessageBox.Show("utilisé le simbole ' , ' comme le point ' . ' ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_basedonne.Text = td_basedonne.Text = tp_basedonne.Text =  cour_gl.Text = td_gl.Text = cour_se1.Text = td_se1.Text =
			tp_se1.Text = cour_dvweb.Text = tp_dvweb.Text = cour_reseau.Text = td__reseau.Text = tp__reseau.Text = cour_thg.Text = 
			td_thg.Text = cour_eng.Text = cour_asp_jur.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_basedonne.Text = moy_gl.Text = moy_se1.Text = moy_dvweb.Text = moy_reseau.Text = moy_thg.Text = moy_eng.Text =
			moy_asp.Text = moy_u1.Text = moy_u2.Text = moy_u3.Text = crid_asp.Text = crid_basedonne.Text = crid_dvweb.Text = 
			crid_eng.Text = crid_gl.Text = crid_reseau.Text =crid_se1.Text = crid_thg.Text = crid_u1.Text =
			crid_u2.Text = crid_u3.Text = "?";

			moy_basedonne.ForeColor = moy_gl.ForeColor = moy_se1.ForeColor = moy_dvweb.ForeColor = moy_reseau.ForeColor =
			moy_thg.ForeColor = moy_eng.ForeColor = moy_asp.ForeColor = Color.White;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public Info_S4()
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


	}
}
