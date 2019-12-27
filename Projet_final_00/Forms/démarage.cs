using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_final_00.Forms
{
	public partial class démarage : Form
	{
		public démarage()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			loding.Width += 4;
			if (loding.Width >= 500)
			{
				timer1.Stop();
				home hom = new home();
				hom.Show();
				this.Hide();
			}
		}
	}
}
