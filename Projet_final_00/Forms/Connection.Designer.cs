namespace Projet_final_00.Forms
{
	partial class Connection
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_nom = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_sort = new System.Windows.Forms.Button();
			this.btn_enter = new System.Windows.Forms.Button();
			this.type = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 408);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(350, 42);
			this.panel4.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label2.Location = new System.Drawing.Point(94, -4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bienvenue";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(82, -5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Se connecter";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 35);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(350, 44);
			this.panel2.TabIndex = 6;
			// 
			// txt_nom
			// 
			this.txt_nom.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_nom.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nom.ForeColor = System.Drawing.Color.Gray;
			this.txt_nom.Location = new System.Drawing.Point(42, 6);
			this.txt_nom.Name = "txt_nom";
			this.txt_nom.Size = new System.Drawing.Size(250, 24);
			this.txt_nom.TabIndex = 0;
			this.txt_nom.Text = "utilisateur";
			this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_nom.Enter += new System.EventHandler(this.nom_Enter);
			this.txt_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nom_KeyDown);
			this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);
			this.txt_nom.Leave += new System.EventHandler(this.nom_Leave);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel5.Controls.Add(this.txt_pass);
			this.panel5.Controls.Add(this.pictureBox3);
			this.panel5.Location = new System.Drawing.Point(24, 280);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(302, 35);
			this.panel5.TabIndex = 7;
			// 
			// txt_pass
			// 
			this.txt_pass.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_pass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_pass.ForeColor = System.Drawing.Color.Gray;
			this.txt_pass.Location = new System.Drawing.Point(42, 6);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(250, 24);
			this.txt_pass.TabIndex = 1;
			this.txt_pass.Text = "Mot de passe";
			this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_pass.Enter += new System.EventHandler(this.pass_Enter);
			this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
			this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
			this.txt_pass.Leave += new System.EventHandler(this.pass_Leave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::Projet_final_00.Properties.Resources._015_security;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = global::Projet_final_00.Properties.Resources._015_security;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 35);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Controls.Add(this.txt_nom);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(24, 228);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(302, 35);
			this.panel3.TabIndex = 8;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::Projet_final_00.Properties.Resources.profile;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 35);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 35);
			this.panel1.TabIndex = 9;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 15;
			this.bunifuElipse1.TargetControl = this;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(103, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "  Bienvenue dans l\'espace de ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::Projet_final_00.Properties.Resources.login_icon;
			this.pictureBox1.Location = new System.Drawing.Point(24, 98);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// btn_sort
			// 
			this.btn_sort.BackColor = System.Drawing.SystemColors.Control;
			this.btn_sort.BackgroundImage = global::Projet_final_00.Properties.Resources._031_login_1;
			this.btn_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_sort.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_sort.FlatAppearance.BorderSize = 0;
			this.btn_sort.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_sort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sort.Location = new System.Drawing.Point(195, 341);
			this.btn_sort.Name = "btn_sort";
			this.btn_sort.Size = new System.Drawing.Size(60, 60);
			this.btn_sort.TabIndex = 3;
			this.btn_sort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btn_sort, "Sortir");
			this.btn_sort.UseVisualStyleBackColor = false;
			this.btn_sort.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_enter
			// 
			this.btn_enter.BackColor = System.Drawing.SystemColors.Control;
			this.btn_enter.BackgroundImage = global::Projet_final_00.Properties.Resources._032_login;
			this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_enter.FlatAppearance.BorderSize = 0;
			this.btn_enter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_enter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_enter.Location = new System.Drawing.Point(84, 341);
			this.btn_enter.Name = "btn_enter";
			this.btn_enter.Size = new System.Drawing.Size(60, 60);
			this.btn_enter.TabIndex = 2;
			this.btn_enter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btn_enter, "Connecter");
			this.btn_enter.UseVisualStyleBackColor = false;
			this.btn_enter.Click += new System.EventHandler(this.button1_Click);
			// 
			// type
			// 
			this.type.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.type.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.type.Location = new System.Drawing.Point(111, 145);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(205, 33);
			this.type.TabIndex = 22;
			this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Connection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 450);
			this.Controls.Add(this.type);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_sort);
			this.Controls.Add(this.btn_enter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(520, 60);
			this.Name = "Connection";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Conx_admin";
			this.Load += new System.EventHandler(this.Conx_admin_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_nom;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_sort;
		private System.Windows.Forms.Button btn_enter;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label type;
        private System.Windows.Forms.ToolTip toolTip1;
	}
}