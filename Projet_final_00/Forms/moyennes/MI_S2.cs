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
	public partial class MI_S2 : Form
	{
		double res_ana, res_alg, res_algo, res_phy, res_stat, res_hist, res_struct, res_poo, res_tec, res_u1, res_u2, res_u3,res_u4, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void cour_analyse_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
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

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_algo.Text = cour_algéber.Text = cour_analyse.Text = cour_histoir.Text = cour_physique.Text = cour_poo.Text = cour_stat.Text =
			cour_structure.Text = cour_tecnique.Text = td_algo.Text = td_algéber.Text = td_analyse.Text  = td_physique.Text =
			td_stat.Text = td_structure.Text = tp_algo.Text = tp_poo.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_algeber.Text = moy_algo.Text = moy_analyse.Text = moy_histoir.Text = moy_physique.Text = moy_poo.Text = moy_stat.Text =
			moy_structure.Text = moy_tecnique.Text = moy_u1.Text = moy_u2.Text = moy_u3.Text = moy_u4.Text = crid_algeber.Text = crid_algo.Text =
			crid_analyse.Text = crid_histoir.Text = crid_piysique.Text = crid_poo.Text = crid_stat.Text = crid_structure.Text = crid_tecnique.Text = 
			crid_u1.Text = crid_u2.Text = crid_u3.Text = crid_u4.Text = "?"; 

			moy_algeber.ForeColor = moy_algo.ForeColor = moy_analyse.ForeColor = moy_histoir.ForeColor = moy_physique.ForeColor =
			moy_poo.ForeColor = moy_stat.ForeColor = moy_structure.ForeColor = moy_tecnique.ForeColor = Color.White;
		}

		public MI_S2()
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_ana = ((((Double.Parse(cour_analyse.Text) * 2) + Double.Parse(td_analyse.Text))) / 3);
				moy_analyse.Text = Convert.ToString(res_ana);
				if (res_ana >= 10)
				{
					moy_analyse.ForeColor = Color.Green;
					crid_analyse.Text = "4";
				}
				else
				{
					moy_analyse.ForeColor = Color.Red;
					crid_analyse.Text = "0";
				}

				res_alg = ((((Double.Parse(cour_algéber.Text) * 2) + Double.Parse(td_algéber.Text))) / 3);
				moy_algeber.Text = Convert.ToString(res_alg);
				if (res_alg >= 10)
				{
					moy_algeber.ForeColor = Color.Green;
					crid_algeber.Text = "4";
				}
				else
				{
					moy_algeber.ForeColor = Color.Red;
					crid_algeber.Text = "0";
				}

				res_stat = ((((Double.Parse(cour_stat.Text) * 2) + Double.Parse(td_stat.Text))) / 3);
				moy_stat.Text = Convert.ToString(res_stat);
				if (res_stat >= 10)
				{
					moy_stat.ForeColor = Color.Green;
					crid_stat.Text = "3";
				}
				else
				{
					moy_stat.ForeColor = Color.Red;
					crid_stat.Text = "0";
				}

				res_u1 = ((res_ana * 2) + (res_alg * 2) + (res_stat * 1)) / 5;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "11";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_analyse.Text) + Double.Parse(crid_algeber.Text) + Double.Parse(crid_stat.Text)).ToString();
				}

				res_phy = ((((Double.Parse(cour_physique.Text) * 2) + Double.Parse(td_physique.Text))) / 3);
				moy_physique.Text = Convert.ToString(res_phy);
				if (res_phy >= 10)
				{
					moy_physique.ForeColor = Color.Green;
					crid_piysique.Text = "2";
				}
				else
				{
					moy_physique.ForeColor = Color.Red;
					crid_piysique.Text = "0";
				}

				res_hist = Double.Parse(cour_histoir.Text);
				moy_histoir.Text = Convert.ToString(res_hist);
				if (res_hist >= 10)
				{
					moy_histoir.ForeColor = Color.Green;
					crid_histoir.Text = "1";
				}
				else
				{
					moy_histoir.ForeColor = Color.Red;
					crid_histoir.Text = "0";
				}

				res_u2 = ((res_phy * 2) + (res_hist)) / 3;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "3";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_piysique.Text) + Double.Parse(crid_histoir.Text)).ToString();
				}

				res_poo = ((((Double.Parse(cour_poo.Text) * 2) + Double.Parse(tp_poo.Text))) / 3);
				moy_poo.Text = Convert.ToString(res_poo);
				if (res_poo >= 10)
				{
					moy_poo.ForeColor = Color.Green;
					crid_poo.Text = "3";
				}
				else
				{
					moy_poo.ForeColor = Color.Red;
					crid_poo.Text = "0";
				}

				res_tec = Double.Parse(cour_tecnique.Text);
				moy_tecnique.Text = Convert.ToString(res_tec);
				if (res_tec >= 10)
				{
					moy_tecnique.ForeColor = Color.Green;
					crid_tecnique.Text = "4";
				}
				else
				{
					moy_tecnique.ForeColor = Color.Red;
					crid_tecnique.Text = "0";
				}

				res_u3 = (res_poo + (res_tec * 2)) / 3;
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "7";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_poo.Text) + Double.Parse(crid_tecnique.Text)).ToString();
				}

				res_algo = ((((Double.Parse(cour_algo.Text) * 2) + (Double.Parse(td_algo.Text) + Double.Parse(tp_algo.Text)) / 2)) / 3);
				moy_algo.Text = Convert.ToString(res_algo);
				if (res_algo >= 10)
				{
					moy_algo.ForeColor = Color.Green;
					crid_algo.Text = "5";
				}
				else
				{
					moy_algo.ForeColor = Color.Red;
					crid_algo.Text = "0";
				}

				res_struct = ((((Double.Parse(cour_structure.Text) * 2) + Double.Parse(td_structure.Text))) / 3);
				moy_structure.Text = Convert.ToString(res_struct);
				if (res_struct >= 10)
				{
					moy_structure.ForeColor = Color.Green;
					crid_structure.Text = "4";
				}
				else
				{
					moy_structure.ForeColor = Color.Red;
					crid_structure.Text = "0";
				}

				res_u4 = ((res_algo * 3) + (res_struct * 2)) / 5;
				moy_u4.Text = Convert.ToString(res_u4);
				if (res_u4 >= 10)
				{
					crid_u4.Text = "4";
				}
				else
				{
					crid_u4.Text = (Double.Parse(crid_algo.Text) + Double.Parse(crid_structure.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 5) + (res_u2 * 3) + (res_u3 * 3) + (res_u4 * 5)) / 16).ToString();
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
					crédit_total.Text = (Double.Parse(crid_u1.Text) + Double.Parse(crid_u2.Text) +
										 Double.Parse(crid_u3.Text) + Double.Parse(crid_u4.Text)).ToString();
				}
			}
			catch
			{
				MessageBox.Show("utilisé le simbole ' , ' comme le point ' . ' ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
