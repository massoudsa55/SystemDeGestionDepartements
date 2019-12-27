namespace Projet_final_00.Forms.admin
{
	partial class Gestion_enseinant
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_enseinant));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label22 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_cherche = new System.Windows.Forms.TextBox();
			this.btn_modifier = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.affichage_resultat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.supprimierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.affichage_resultat)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1100, 27);
			this.panel1.TabIndex = 2;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.SystemColors.Window;
			this.label22.Location = new System.Drawing.Point(7, 4);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(184, 18);
			this.label22.TabIndex = 6;
			this.label22.Text = "Gestion des Enseignant";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::Projet_final_00.Properties.Resources.minimize;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Dock = System.Windows.Forms.DockStyle.Right;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(1046, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(27, 27);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(1073, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 27);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Projet_final_00.Properties.Resources._017_user_6;
			this.pictureBox1.Location = new System.Drawing.Point(40, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(107, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Recherche ici  :";
			// 
			// txt_cherche
			// 
			this.txt_cherche.Font = new System.Drawing.Font("Tahoma", 14F);
			this.txt_cherche.Location = new System.Drawing.Point(271, 32);
			this.txt_cherche.Name = "txt_cherche";
			this.txt_cherche.Size = new System.Drawing.Size(307, 30);
			this.txt_cherche.TabIndex = 0;
			this.txt_cherche.TextChanged += new System.EventHandler(this.txt_cherche_TextChanged);
			// 
			// btn_modifier
			// 
			this.btn_modifier.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_modifier.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_modifier.BorderRadius = 0;
			this.btn_modifier.ButtonText = "Modifier";
			this.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_modifier.DisabledColor = System.Drawing.Color.Gray;
			this.btn_modifier.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_modifier.Iconcolor = System.Drawing.Color.Transparent;
			this.btn_modifier.Iconimage = global::Projet_final_00.Properties.Resources._018_user_5;
			this.btn_modifier.Iconimage_right = null;
			this.btn_modifier.Iconimage_right_Selected = null;
			this.btn_modifier.Iconimage_Selected = null;
			this.btn_modifier.IconMarginLeft = 0;
			this.btn_modifier.IconMarginRight = 0;
			this.btn_modifier.IconRightVisible = true;
			this.btn_modifier.IconRightZoom = 0D;
			this.btn_modifier.IconVisible = true;
			this.btn_modifier.IconZoom = 85D;
			this.btn_modifier.IsTab = false;
			this.btn_modifier.Location = new System.Drawing.Point(221, 21);
			this.btn_modifier.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
			this.btn_modifier.Name = "btn_modifier";
			this.btn_modifier.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_modifier.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_modifier.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_modifier.selected = false;
			this.btn_modifier.Size = new System.Drawing.Size(170, 43);
			this.btn_modifier.TabIndex = 5;
			this.btn_modifier.Text = "Modifier";
			this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_modifier.Textcolor = System.Drawing.Color.White;
			this.btn_modifier.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
			// 
			// btn_supprimer
			// 
			this.btn_supprimer.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_supprimer.BorderRadius = 0;
			this.btn_supprimer.ButtonText = "Supprime";
			this.btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_supprimer.DisabledColor = System.Drawing.Color.Gray;
			this.btn_supprimer.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_supprimer.Iconcolor = System.Drawing.Color.Transparent;
			this.btn_supprimer.Iconimage = global::Projet_final_00.Properties.Resources._015_user_8;
			this.btn_supprimer.Iconimage_right = null;
			this.btn_supprimer.Iconimage_right_Selected = null;
			this.btn_supprimer.Iconimage_Selected = null;
			this.btn_supprimer.IconMarginLeft = 0;
			this.btn_supprimer.IconMarginRight = 0;
			this.btn_supprimer.IconRightVisible = true;
			this.btn_supprimer.IconRightZoom = 0D;
			this.btn_supprimer.IconVisible = true;
			this.btn_supprimer.IconZoom = 85D;
			this.btn_supprimer.IsTab = false;
			this.btn_supprimer.Location = new System.Drawing.Point(408, 22);
			this.btn_supprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_supprimer.Name = "btn_supprimer";
			this.btn_supprimer.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_supprimer.selected = false;
			this.btn_supprimer.Size = new System.Drawing.Size(170, 43);
			this.btn_supprimer.TabIndex = 6;
			this.btn_supprimer.Text = "Supprime";
			this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_supprimer.Textcolor = System.Drawing.Color.White;
			this.btn_supprimer.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
			// 
			// btn_add
			// 
			this.btn_add.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_add.BorderRadius = 0;
			this.btn_add.ButtonText = "Ajouter";
			this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_add.DisabledColor = System.Drawing.Color.Gray;
			this.btn_add.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
			this.btn_add.Iconimage = global::Projet_final_00.Properties.Resources._004_user_11;
			this.btn_add.Iconimage_right = null;
			this.btn_add.Iconimage_right_Selected = null;
			this.btn_add.Iconimage_Selected = null;
			this.btn_add.IconMarginLeft = 0;
			this.btn_add.IconMarginRight = 0;
			this.btn_add.IconRightVisible = true;
			this.btn_add.IconRightZoom = 0D;
			this.btn_add.IconVisible = true;
			this.btn_add.IconZoom = 85D;
			this.btn_add.IsTab = false;
			this.btn_add.Location = new System.Drawing.Point(34, 22);
			this.btn_add.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_add.Name = "btn_add";
			this.btn_add.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_add.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_add.selected = false;
			this.btn_add.Size = new System.Drawing.Size(170, 43);
			this.btn_add.TabIndex = 4;
			this.btn_add.Text = "Ajouter";
			this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_add.Textcolor = System.Drawing.Color.White;
			this.btn_add.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_modifier);
			this.groupBox3.Controls.Add(this.btn_supprimer);
			this.groupBox3.Controls.Add(this.btn_add);
			this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
			this.groupBox3.Location = new System.Drawing.Point(267, 118);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(606, 72);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Opérations";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_cherche);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(267, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(606, 79);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recherche";
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
			// affichage_resultat
			// 
			this.affichage_resultat.AllowUserToAddRows = false;
			this.affichage_resultat.AllowUserToDeleteRows = false;
			this.affichage_resultat.AllowUserToOrderColumns = true;
			this.affichage_resultat.AllowUserToResizeColumns = false;
			this.affichage_resultat.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.affichage_resultat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.affichage_resultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.affichage_resultat.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.affichage_resultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.affichage_resultat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.affichage_resultat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.affichage_resultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.affichage_resultat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.affichage_resultat.DoubleBuffered = true;
			this.affichage_resultat.EnableHeadersVisualStyles = false;
			this.affichage_resultat.HeaderBgColor = System.Drawing.Color.DarkTurquoise;
			this.affichage_resultat.HeaderForeColor = System.Drawing.SystemColors.WindowText;
			this.affichage_resultat.Location = new System.Drawing.Point(3, 23);
			this.affichage_resultat.MultiSelect = false;
			this.affichage_resultat.Name = "affichage_resultat";
			this.affichage_resultat.ReadOnly = true;
			this.affichage_resultat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.affichage_resultat.RowHeadersVisible = false;
			this.affichage_resultat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.affichage_resultat.Size = new System.Drawing.Size(1084, 374);
			this.affichage_resultat.TabIndex = 0;
			this.affichage_resultat.DoubleClick += new System.EventHandler(this.affichage_resultat_DoubleClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.affichage_resultat);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(5, 196);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1090, 400);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Liste des enseignant";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.toolStripSeparator1,
            this.supprimierToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(133, 76);
			// 
			// ajouterToolStripMenuItem
			// 
			this.ajouterToolStripMenuItem.Image = global::Projet_final_00.Properties.Resources.add;
			this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
			this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.ajouterToolStripMenuItem.Text = "Ajouter";
			this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
			// 
			// modifierToolStripMenuItem
			// 
			this.modifierToolStripMenuItem.Image = global::Projet_final_00.Properties.Resources.refresh;
			this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
			this.modifierToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.modifierToolStripMenuItem.Text = "Modifier";
			this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
			// 
			// supprimierToolStripMenuItem
			// 
			this.supprimierToolStripMenuItem.Image = global::Projet_final_00.Properties.Resources.remove;
			this.supprimierToolStripMenuItem.Name = "supprimierToolStripMenuItem";
			this.supprimierToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.supprimierToolStripMenuItem.Text = "Supprimier";
			this.supprimierToolStripMenuItem.Click += new System.EventHandler(this.supprimierToolStripMenuItem_Click);
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 6;
			this.bunifuElipse2.TargetControl = this.btn_add;
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 6;
			this.bunifuElipse3.TargetControl = this.btn_modifier;
			// 
			// bunifuElipse4
			// 
			this.bunifuElipse4.ElipseRadius = 6;
			this.bunifuElipse4.TargetControl = this.btn_supprimer;
			// 
			// Gestion_enseinant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Gestion_enseinant";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion_enseinant";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.affichage_resultat)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_cherche;
		private Bunifu.Framework.UI.BunifuFlatButton btn_modifier;
		private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
		private Bunifu.Framework.UI.BunifuFlatButton btn_add;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		public Bunifu.Framework.UI.BunifuCustomDataGrid affichage_resultat;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supprimierToolStripMenuItem;
		private System.Windows.Forms.Label label22;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
	}
}