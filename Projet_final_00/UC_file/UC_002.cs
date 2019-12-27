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
	public partial class UC_002 : UserControl
	{
		public UC_002()
		{
			InitializeComponent();
		}

		private void connection_admin_Click(object sender, EventArgs e)
		{
			Connection admin = new Connection();
		    admin.type.Text = "Administration";
			admin.Show();
		}
	}
}
