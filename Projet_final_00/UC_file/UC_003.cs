using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_final_00.Forms;

namespace Projet_final_00.UC_file
{
	public partial class UC_003 : UserControl
	{
		public UC_003()
		{
			InitializeComponent();
		}

		private void connection_ens_Click(object sender, EventArgs e)
		{
			Connection ens = new Connection();
			ens.type.Text = "Enseignants";
			ens.Show();
		}
	}
}
