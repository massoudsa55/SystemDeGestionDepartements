namespace Projet_final_00
{
	partial class Cr_Form_Print_List_Nots
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cr_Form_Print_List_Nots));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.ens_exit = new System.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.Cr_Print_List_Nots1 = new Projet_final_00.Cr_report_print.Cr_Print_List_Nots();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.ens_exit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(917, 27);
			this.panel1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.minimize;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(863, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 27);
			this.button2.TabIndex = 6;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ens_exit
			// 
			this.ens_exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ens_exit.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.ens_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ens_exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ens_exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.ens_exit.FlatAppearance.BorderSize = 0;
			this.ens_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ens_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ens_exit.Location = new System.Drawing.Point(890, 0);
			this.ens_exit.Name = "ens_exit";
			this.ens_exit.Size = new System.Drawing.Size(27, 27);
			this.ens_exit.TabIndex = 5;
			this.ens_exit.UseVisualStyleBackColor = false;
			this.ens_exit.Click += new System.EventHandler(this.ens_exit_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 15;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 27);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.Cr_Print_List_Nots1;
			this.crystalReportViewer1.Size = new System.Drawing.Size(917, 623);
			this.crystalReportViewer1.TabIndex = 1;
			// 
			// Cr_Form_Print_List_Nots
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 650);
			this.Controls.Add(this.crystalReportViewer1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cr_Form_Print_List_Nots";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cr_Form_Print_List_Nots";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button ens_exit;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private Cr_report_print.Cr_Print_List_Nots Cr_Print_List_Nots1;
	}
}