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
	public partial class Math_S6 : Form
	{
		double res_mesur, res_anahib, res_eqdef, res_eqphmth, res_optim,res_intdida, res_u1, res_u2, res_u3, res_u4, moy_gen;

		private void button5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				res_mesur = ((((Double.Parse(cour_mesur.Text) * 2) + Double.Parse(td_mesur.Text))) / 3);
				moy_mesur.Text = Convert.ToString(res_mesur);
				if (res_mesur >= 10)
				{
					moy_mesur.ForeColor = Color.Green;
					crid_mesur.Text = "6";
				}
				else
				{
					moy_mesur.ForeColor = Color.Red;
					crid_mesur.Text = "0";
				}

				res_anahib = ((((Double.Parse(cour_anahib.Text) * 2) + Double.Parse(td_anahib.Text))) / 3);
				moy_anahib.Text = Convert.ToString(res_anahib);
				if (res_anahib >= 10)
				{
					moy_anahib.ForeColor = Color.Green;
					crid_anahib.Text = "5";
				}
				else
				{
					moy_anahib.ForeColor = Color.Red;
					crid_anahib.Text = "0";
				}

				res_eqdef = ((((Double.Parse(cour_eqdef.Text) * 2) + (Double.Parse(td_eqdef.Text) + Double.Parse(tp_transformation.Text)) / 2)) / 3);
				moy_eqdef.Text = Convert.ToString(res_eqdef);
				if (res_eqdef >= 10)
				{
					moy_eqdef.ForeColor = Color.Green;
					crid_eqdef.Text = "6";
				}
				else
				{
					moy_eqdef.ForeColor = Color.Red;
					crid_eqdef.Text = "0";
				}

				res_eqphmth = ((((Double.Parse(cour_eqphmth.Text) * 2) + Double.Parse(td_eqphmth.Text))) / 3);
				moy_eqphmth.Text = Convert.ToString(res_eqphmth);
				if (res_eqphmth >= 10)
				{
					moy_eqphmth.ForeColor = Color.Green;
					crid_eqphmth.Text = "5";
				}
				else
				{
					moy_eqphmth.ForeColor = Color.Red;
					crid_eqphmth.Text = "0";
				}

				res_optim = Double.Parse(cour_optim.Text);
				moy_optim.Text = Convert.ToString(res_optim);
				if (res_optim >= 10)
				{
					moy_optim.ForeColor = Color.Green;
					crid_optim.Text = "5";
				}
				else
				{
					moy_optim.ForeColor = Color.Red;
					crid_optim.Text = "0";
				}

				res_intdida = Double.Parse(cour_intdida.Text);
				moy_intdida.Text = Convert.ToString(res_intdida);
				if (res_intdida >= 10)
				{
					moy_intdida.ForeColor = Color.Green;
					crid_intdida.Text = "3";
				}
				else
				{
					moy_intdida.ForeColor = Color.Red;
					crid_intdida.Text = "0";
				}

				res_u1 = ((res_mesur * 4) + (res_anahib * 3)) / 7;
				moy_u1.Text = Convert.ToString(res_u1);
				if (res_u1 >= 10)
				{
					crid_u1.Text = "11";
				}
				else
				{
					crid_u1.Text = (Double.Parse(crid_mesur.Text) + Double.Parse(crid_anahib.Text)).ToString();
				}

				res_u2 = ((res_eqdef * 4) + (res_eqphmth * 2)) / 6;
				moy_u2.Text = Convert.ToString(res_u2);
				if (res_u2 >= 10)
				{
					crid_u2.Text = "11";
				}
				else
				{
					crid_u2.Text = (Double.Parse(crid_eqdef.Text) + Double.Parse(crid_eqphmth.Text)).ToString();
				}

				res_u3 = (res_optim);
				moy_u3.Text = Convert.ToString(res_u3);
				if (res_u3 >= 10)
				{
					crid_u3.Text = "5";
				}
				else
				{
					crid_u3.Text = (Double.Parse(crid_optim.Text)).ToString();
				}

				res_u4 = (res_intdida);
				moy_u4.Text = Convert.ToString(res_u4);
				if (res_u4 >= 10)
				{
					crid_u4.Text = "3";
				}
				else
				{
					crid_u4.Text = (Double.Parse(crid_intdida.Text)).ToString();
				}

				moyenne_genérel.Text = (((res_u1 * 7) + (res_u2 * 6) + (res_u3 * 2) + res_u4) / 16).ToString();
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
					crédit_total.Text = (Double.Parse(crid_u1.Text) + Double.Parse(crid_u2.Text) + Double.Parse(crid_u3.Text) + Double.Parse(crid_u4.Text)).ToString();
				}
			}
			catch
			{
				MessageBox.Show("utilisé le simbole ' , ' comme le point ' . ' ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		public Math_S6()
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

		private void cour_intro_Enter(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "0")
			{
				te.Text = "";
			}
		}

		private void cour_intro_Leave(object sender, EventArgs e)
		{
			TextBox te = (TextBox)sender;
			if (te.Text == "")
			{
				te.Text = "0";
			}
		}

		private void effacer_Click(object sender, EventArgs e)
		{
			cour_optim.Text = cour_eqphmth.Text = cour_mesur.Text = cour_anahib.Text = cour_eqdef.Text =
			td_eqphmth.Text = td_mesur.Text = td_anahib.Text = td_eqdef.Text = tp_transformation.Text = cour_intdida.Text = "0";

			moyenne_genérel.Text = crédit_total.Text = "";

			moy_optim.Text = moy_eqphmth.Text = moy_mesur.Text = moy_anahib.Text = moy_eqdef.Text = moy_u1.Text = moy_u2.Text =
			moy_u3.Text = crid_optim.Text = crid_eqphmth.Text = crid_mesur.Text = crid_anahib.Text = crid_eqdef.Text = 
			crid_intdida.Text = moy_intdida.Text = moy_u4.Text = crid_u1.Text = crid_u2.Text = crid_u3.Text = "?";

			moy_optim.ForeColor = moy_eqphmth.ForeColor = moy_mesur.ForeColor = moy_anahib.ForeColor = moy_eqdef.ForeColor = moy_intdida.ForeColor = Color.White;
		}
	}
}
