using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace Projet_final_00
{
	static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string id_module;
        public static string type_modifier="";
        
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new Forms.moyennes.MI_S1());
			//Application.Run(new Forms.admin.Gestion_notes());
		    //Application.Run(new Forms.admin.Gestion_enseinant());
			//Application.Run(new Forms.administration());
			//Application.Run(new Forms.admin.Confiduration());
			//Application.Run(new Forms.admin.Print());
			Application.Run(new Forms.démarage());
			//Application.Run(new Forms.etudiant());
			//Application.Run(new Forms.enseignant());
		    //Application.Run(new Forms.Déclaration());
		}
	}
}
