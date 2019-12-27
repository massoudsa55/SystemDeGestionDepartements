namespace Projet_final_00.UC_file
{
	partial class UC_004
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.connection_etud = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(490, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue dans l\'espace des étudiants\r\n     pour vous connecter, cliquez ici";
            // 
            // connection_etud
            // 
            this.connection_etud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connection_etud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connection_etud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.connection_etud.Location = new System.Drawing.Point(665, 257);
            this.connection_etud.Name = "connection_etud";
            this.connection_etud.Size = new System.Drawing.Size(110, 32);
            this.connection_etud.TabIndex = 0;
            this.connection_etud.Text = "Connection";
            this.toolTip1.SetToolTip(this.connection_etud, "Connection");
            this.connection_etud.UseVisualStyleBackColor = true;
            this.connection_etud.Click += new System.EventHandler(this.connection_etud_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.connection_etud;
            // 
            // UC_004
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Projet_final_00.Properties.Resources.talaba_991656277;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.connection_etud);
            this.Controls.Add(this.label1);
            this.Name = "UC_004";
            this.Size = new System.Drawing.Size(934, 302);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button connection_etud;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
