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
	public partial class MI_S1 : Form
	{
		double res_ana, res_alg, res_algo, res_phy, res_elec, res_termo, res_bur, res_eng, res_u1, res_u2, res_u3, moy_gen;

		private void td_analyse_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
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

		private void effacer_Click(object sender, EventArgs e)
		{
			/*int mon = DateTime.Now.Month;

			if (mon > 10)
			{
				int dt = DateTime.Now.Year;
				int dt1 = dt+1;
				date.Text = (dt.ToString() + " / " + dt1.ToString());
			}
			if (mon < 10)
			{
				int dt = DateTime.Now.Year;
				int dt1 = dt - 1;
				date.Text = (dt1.ToString() + " / " + dt.ToString());
			}*/

			cour_algéber.Text = td_algéber.Text = cour_analyse.Text = td_analyse.Text = cour_algo.Text = td_algo.Text = tp_algo.Text =
		    cour_electro.Text = td_electeo.Text = cour_physique.Text = td_physique.Text = cour_termono.Text = cour_eng.Text =
		    tp_bureatique.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_algeber.Text = moy_algo.Text = moy_analyse.Text = moy_electro.Text = moy_eng.Text = moy_physique.Text = moy_termono.Text =
			moy_tpbureatique.Text = moy_u1.Text = moy_u2.Text = moy_u3.Text = moy_u4.Text = crid_algeber.Text = crid_algo.Text = crid_analyse.Text =
			crid_electro.Text = crid_eng.Text = crid_piysique.Text = crid_termono.Text = crid_tpbureautique.Text = crid_u1.Text = crid_u2.Text =
			crid_u3.Text = crid_u4.Text = "?";

			moy_analyse.ForeColor = moy_algeber.ForeColor = moy_algo.ForeColor = moy_physique.ForeColor = moy_electro.ForeColor =
			moy_termono.ForeColor = moy_tpbureatique.ForeColor = moy_eng.ForeColor = Color.White;

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
					crid_analyse.Text = "6";
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
					crid_algeber.Text = "5";
				}
				else
				{
					moy_algeber.ForeColor = Color.Red;
					crid_algeber.Text = "0";
				}

				res_algo = ((((Double.Parse(cour_algo.Text) * 2) + (Double.Parse(td_algo.Text) + Double.Parse(tp_algo.Text)) / 2)) / 3);
				moy_algo.Text = Convert.ToString(res_algo);
				if (res_algo >= 10)
				{
					moy_algo.ForeColor = Color.Green;
					crid_algo.Text = "6";
				}
				else
				{
					moy_algo.ForeColor = Color.Red;
					crid_algo.Text = "0";
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
				res_elec = ((((Double.Parse(cour_electro.Text) * 2) + Double.Parse(td_electeo.Text))) / 3);
				moy_electro.Text = Convert.ToString(res_elec);
				if (res_elec >= 10)
				{
					moy_electro.ForeColor = Color.Green;
					crid_electro.Text = "2";
				}
				else
				{
					moy_electro.ForeColor = Color.Red;
					crid_electro.Text = "0";
				}

				res_termo = Double.Parse(cour_termono.Text);
				moy_termono.Text = Convert.ToString(res_termo);
				if (res_termo >= 10)
				{
					moy_termono.ForeColor = Color.Green;
					crid_termono.Text = "4";
				}
				else
				{
					moy_termono.ForeColor = Color.Red;
					crid_termono.Text = "0";
				}
				res_bur = Double.Parse(tp_bureatique.Text);
				moy_tpbureatique.Text = Convert.ToString(res_bur);
				if (res_bur >= 10)
				{
					moy_tpbureatique.ForeColor = Color.Green;
					crid_tpbureautique.Text = "3";
				}
				else
				{
					moy_tpbureatique.ForeColor = Color.Red;
					crid_tpbureautique.Text = "0";
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
				res_u1 = ((res_ana * 4) + (res_alg * 2) + (res_algo * 4)) / 10;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "17";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_analyse.Text) + Double.Parse(crid_algeber.Text) + Double.Parse(crid_algo.Text)).ToString();
				}
				res_u2 = ((res_phy * 2) + (res_elec * 2)) / 4;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "4";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_piysique.Text) + Double.Parse(crid_electro.Text)).ToString();
				}
				res_u3 = (res_termo + res_bur) / 2;
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "7";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_termono.Text) + Double.Parse(crid_tpbureautique.Text)).ToString();
				}
				moy_u4.Text = Convert.ToString(res_eng);
				crid_u4.Text = crid_eng.Text;

				moyenne_genérel.Text = (((res_u1 * 10) + (res_u2 * 4) + (res_u3 * 2) + res_eng) / 17).ToString();
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

		public MI_S1()
		{
			InitializeComponent();
			
			data_tm.Text= DateTime.Now.ToString("D");

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
