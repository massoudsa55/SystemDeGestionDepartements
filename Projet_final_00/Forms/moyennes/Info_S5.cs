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
	public partial class Info_S5 : Form
	{
		double res_comp, res_se, res_prolog, res_gl, res_ihm, res_ia, res_lin, res_eng, res_u1, res_u2, res_u3 ,moy_general;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_compil.Text = cour_eng.Text = cour_gl.Text = cour_ia.Text = cour_ihm.Text = cour_lin.Text = cour_prog.Text = cour_se.Text =
			td_compil.Text = td_gl.Text = td_ia.Text = td_lin.Text = td_se.Text = tp_gl.Text = tp_ihm.Text = tp_prog.Text = tp_se.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_compil.Text = moy_eng.Text = moy_gl.Text = moy_ia.Text = moy_ihm.Text = moy_lin.Text = moy_prog.Text = moy_se.Text = moy_u1.Text =
			moy_u2.Text = moy_u3.Text = crid_compil.Text = crid_eng.Text = crid_gl.Text = crid_ia.Text = crid_ihm.Text = crid_lin.Text = 
			crid_prog.Text = crid_se.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_compil.ForeColor = moy_eng.ForeColor = moy_gl.ForeColor = moy_ia.ForeColor = moy_ihm.ForeColor = 
			moy_lin.ForeColor = moy_prog.ForeColor = moy_se.ForeColor = Color.White;
		}

		public Info_S5()
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

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cour_analyse_Leave(object sender, EventArgs e)
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
				res_comp = ((Double.Parse(cour_compil.Text) / 2) + (Double.Parse(td_compil.Text)/2)) ;
				moy_compil.Text = Convert.ToString(res_comp);
				if (res_comp >= 10)
				{
					moy_compil.ForeColor = Color.Green;
					crid_compil.Text = "4";
				}
				else
				{
					moy_compil.ForeColor = Color.Red;
					crid_compil.Text = "0";
				}

				res_se = (Double.Parse(cour_se.Text) / 2) + ((Double.Parse(td_se.Text) + Double.Parse(tp_se.Text))/2)/2 ;
				moy_se.Text = Convert.ToString(res_se);
				if (res_se >= 10)
				{
					moy_se.ForeColor = Color.Green;
					crid_se.Text = "4";
				}
				else
				{
					moy_se.ForeColor = Color.Red;
					crid_se.Text = "0";
				}

				res_prolog = ((Double.Parse(cour_prog.Text) / 2) + (Double.Parse(tp_prog.Text))/2) ;
				moy_prog.Text = Convert.ToString(res_prolog);
				if (res_prolog >= 10)
				{
					moy_prog.ForeColor = Color.Green;
					crid_prog.Text = "4";
				}
				else
				{
					moy_prog.ForeColor = Color.Red;
					crid_prog.Text = "0";
				}

				res_gl = (Double.Parse(cour_gl.Text) / 2) + ((Double.Parse(td_gl.Text) + Double.Parse(tp_gl.Text)) / 2) / 2;
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

				res_ihm = ((Double.Parse(cour_ihm.Text) / 2) + (Double.Parse(tp_ihm.Text))/2) ;
				moy_ihm.Text = Convert.ToString(res_ihm);
				if (res_ihm >= 10)
				{
					moy_ihm.ForeColor = Color.Green;
					crid_ihm.Text = "4";
				}
				else
				{
					moy_ihm.ForeColor = Color.Red;
					crid_ihm.Text = "0";
				}

				res_u1 = ((res_comp * 2) + (res_se * 2) + (res_prolog * 2) + (res_gl * 2) + (res_ihm * 2) ) / 10;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "20";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_compil.Text) + Double.Parse(crid_se.Text) + Double.Parse(crid_prog.Text) +
					(Double.Parse(crid_gl.Text)) + (Double.Parse(crid_ihm.Text)) ).ToString();
				}

				res_ia = ((Double.Parse(cour_ia.Text) / 2) + (Double.Parse(td_ia.Text)) / 2);
				moy_ia.Text = Convert.ToString(res_ia);
				if (res_ia >= 10)
				{
					moy_ia.ForeColor = Color.Green;
					crid_ia.Text = "4";
				}
				else
				{
					moy_ia.ForeColor = Color.Red;
					crid_ia.Text = "0";
				}

				res_lin = ((Double.Parse(cour_lin.Text) / 2) + (Double.Parse(td_lin.Text)) / 2);
				moy_lin.Text = Convert.ToString(res_lin);
				if (res_lin >= 10)
				{
					moy_lin.ForeColor = Color.Green;
					crid_lin.Text = "4";
				}
				else
				{
					moy_lin.ForeColor = Color.Red;
					crid_lin.Text = "0";
				}

				res_u2 = ((res_ia * 2) + (res_lin * 2)) / 4;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "8";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_ia.Text) + Double.Parse(crid_lin.Text)).ToString();
				}

				res_eng = (Double.Parse(cour_eng.Text)) ;
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
				
				res_u3 = res_eng;
				moy_u3.Text = Convert.ToString(res_eng);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "2";
				}
				else
				{
					crid_u3.Text ="0";
				}

				moyenne_genérel.Text = (((res_u1 * 10) + (res_u2 * 4) + (res_u3 )) / 15).ToString();
				moy_general = Double.Parse(moyenne_genérel.Text);
				if (moy_general >= 10)
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
	}
}
