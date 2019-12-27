using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00
{
	public partial class home : Form
	{
		int mov;
		int movx;
		int movy;

		private static home hom;
		static void home_close(object sender , FormClosedEventArgs e)
		{
			hom = null;
		} 

		public static home get_home
		{
			get
			{
				if (hom == null)
				{
					hom = new home();
					hom.FormClosed += new FormClosedEventHandler(home_close);
				}
				return hom;
			}
		}

		public home()
		{
			InitializeComponent();
			data_tm.Text = DateTime.Now.ToString("D");

			if (hom == null)
				hom = this;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void admin_Click(object sender, EventArgs e)
		{
			bunifuTransition2.HideSync(uC_0011);
			bunifuTransition2.HideSync(uC_0031);
			bunifuTransition2.HideSync(uC_0041);
			bunifuTransition1.ShowSync(uC_0021);
		}

		private void prof_Click(object sender, EventArgs e)
		{
			bunifuTransition2.HideSync(uC_0011);
			bunifuTransition2.HideSync(uC_0021);
			bunifuTransition2.HideSync(uC_0041);
			bunifuTransition1.ShowSync(uC_0031);
		}

		private void etudiant_Click(object sender, EventArgs e)
		{
			bunifuTransition2.HideSync(uC_0011);
			bunifuTransition2.HideSync(uC_0031);
			bunifuTransition2.HideSync(uC_0021);
			bunifuTransition1.ShowSync(uC_0041);
		}

		private void home_Click(object sender, EventArgs e)
		{
			bunifuTransition2.HideSync(uC_0041);
			bunifuTransition2.HideSync(uC_0031);
			bunifuTransition2.HideSync(uC_0021);
			bunifuTransition1.ShowSync(uC_0011);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/Udjelfa-507429222626366/");
		}

		private void home_Load(object sender, EventArgs e)
		{
			//this.Location = Screen.AllScreens[1].WorkingArea.Location;
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Interval = 1000;
			timer.Elapsed += Timer_Elapsed;
			timer.Start();
		}

		private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			circularProgressBar1.Invoke((MethodInvoker)delegate
			{
				circularProgressBar1.Text = DateTime.Now.ToString("HH:mm:ss");
				circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt");//AM or PM
			});
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movx = e.X;
			movy = e.Y;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.univ-djelfa.dz/ara/");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/Udjelfa-507429222626366/");
		}

		private void button2_Click(object sender, EventArgs e)
		{
            try
            {
                WindowState = FormWindowState.Minimized;
            }
            catch
            {
                return;
            }
		}

        private void sur_Click(object sender, EventArgs e)
        {
            Forms.Configue_Server server = new Forms.Configue_Server();
            server.ShowDialog();
        }

		private void sur_Click_1(object sender, EventArgs e)
		{
			Forms.A_propose apropose = new Forms.A_propose();
			apropose.ShowDialog();
		}
	}
}
