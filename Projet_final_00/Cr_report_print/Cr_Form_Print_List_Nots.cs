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
	public partial class Cr_Form_Print_List_Nots : Form
	{
		public Cr_Form_Print_List_Nots()
		{
			InitializeComponent();
		}

		private void ens_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
	}
}
