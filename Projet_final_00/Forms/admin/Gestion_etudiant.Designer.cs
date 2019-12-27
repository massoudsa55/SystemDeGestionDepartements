namespace Projet_final_00.Forms.admin
{
	partial class Gestion_etudiant
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_etudiant));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label22 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_cherche = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.affichage_resultat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listeÉtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.certificatScolaritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.supprimierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_modifier = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txt_specialit = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_niveau = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_groupe = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.affichage_resultat)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.panel1.TabIndex = 1;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.SystemColors.Window;
			this.label22.Location = new System.Drawing.Point(3, 4);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(168, 18);
			this.label22.TabIndex = 6;
			this.label22.Text = "Gestion des Etudiant";
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
			this.button2.Click += new System.EventHandler(this.button1_Click);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_cherche);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(621, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 87);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recherche";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Projet_final_00.Properties.Resources._017_user_6;
			this.pictureBox1.Location = new System.Drawing.Point(16, 24);
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
			this.label3.Location = new System.Drawing.Point(83, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Recherche ici  :";
			// 
			// txt_cherche
			// 
			this.txt_cherche.Font = new System.Drawing.Font("Tahoma", 14F);
			this.txt_cherche.Location = new System.Drawing.Point(247, 40);
			this.txt_cherche.Name = "txt_cherche";
			this.txt_cherche.Size = new System.Drawing.Size(206, 30);
			this.txt_cherche.TabIndex = 0;
			this.txt_cherche.TextChanged += new System.EventHandler(this.txt_cherche_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.affichage_resultat);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 125);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1076, 345);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Liste des étudiants";
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
			this.affichage_resultat.ContextMenuStrip = this.contextMenuStrip1;
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
			this.affichage_resultat.Size = new System.Drawing.Size(1070, 319);
			this.affichage_resultat.TabIndex = 0;
			this.affichage_resultat.DoubleClick += new System.EventHandler(this.affichage_resultat_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.supprimierToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(133, 98);
			// 
			// ajouterToolStripMenuItem
			// 
			this.ajouterToolStripMenuItem.Image = global::Projet_final_00.Properties.Resources.add1;
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
			// imprimerToolStripMenuItem
			// 
			this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeÉtudiantsToolStripMenuItem,
            this.certificatScolaritéToolStripMenuItem});
			this.imprimerToolStripMenuItem.Image = global::Projet_final_00.Properties.Resources.printer;
			this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
			this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.imprimerToolStripMenuItem.Text = "Imprimer";
			// 
			// listeÉtudiantsToolStripMenuItem
			// 
			this.listeÉtudiantsToolStripMenuItem.Name = "listeÉtudiantsToolStripMenuItem";
			this.listeÉtudiantsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.listeÉtudiantsToolStripMenuItem.Text = "Liste étudiants";
			this.listeÉtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeÉtudiantsToolStripMenuItem_Click);
			// 
			// certificatScolaritéToolStripMenuItem
			// 
			this.certificatScolaritéToolStripMenuItem.Name = "certificatScolaritéToolStripMenuItem";
			this.certificatScolaritéToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.certificatScolaritéToolStripMenuItem.Text = "Certificat scolarité";
			this.certificatScolaritéToolStripMenuItem.Click += new System.EventHandler(this.certificatScolaritéToolStripMenuItem_Click);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.bunifuFlatButton1);
			this.groupBox3.Controls.Add(this.btn_modifier);
			this.groupBox3.Controls.Add(this.btn_supprimer);
			this.groupBox3.Controls.Add(this.bunifuFlatButton4);
			this.groupBox3.Controls.Add(this.btn_add);
			this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
			this.groupBox3.Location = new System.Drawing.Point(12, 471);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1073, 117);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Opérations";
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "Impremier certificat scolarité.";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = global::Projet_final_00.Properties.Resources.printer;
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 60D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(866, 36);
			this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 58);
			this.bunifuFlatButton1.TabIndex = 3;
			this.bunifuFlatButton1.Text = "Impremier certificat scolarité.";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
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
			this.btn_modifier.IconZoom = 60D;
			this.btn_modifier.IsTab = false;
			this.btn_modifier.Location = new System.Drawing.Point(222, 36);
			this.btn_modifier.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
			this.btn_modifier.Name = "btn_modifier";
			this.btn_modifier.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_modifier.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_modifier.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_modifier.selected = false;
			this.btn_modifier.Size = new System.Drawing.Size(200, 58);
			this.btn_modifier.TabIndex = 2;
			this.btn_modifier.Text = "Modifier";
			this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_modifier.Textcolor = System.Drawing.Color.White;
			this.btn_modifier.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
			// 
			// btn_supprimer
			// 
			this.btn_supprimer.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_supprimer.BorderRadius = 0;
			this.btn_supprimer.ButtonText = "Supprimer";
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
			this.btn_supprimer.IconZoom = 60D;
			this.btn_supprimer.IsTab = false;
			this.btn_supprimer.Location = new System.Drawing.Point(437, 36);
			this.btn_supprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_supprimer.Name = "btn_supprimer";
			this.btn_supprimer.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_supprimer.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_supprimer.selected = false;
			this.btn_supprimer.Size = new System.Drawing.Size(200, 58);
			this.btn_supprimer.TabIndex = 1;
			this.btn_supprimer.Text = "Supprimer";
			this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_supprimer.Textcolor = System.Drawing.Color.White;
			this.btn_supprimer.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
			// 
			// bunifuFlatButton4
			// 
			this.bunifuFlatButton4.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton4.BorderRadius = 0;
			this.bunifuFlatButton4.ButtonText = "Impremier liste des Etudiants";
			this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton4.Iconimage = global::Projet_final_00.Properties.Resources.printer;
			this.bunifuFlatButton4.Iconimage_right = null;
			this.bunifuFlatButton4.Iconimage_right_Selected = null;
			this.bunifuFlatButton4.Iconimage_Selected = null;
			this.bunifuFlatButton4.IconMarginLeft = 0;
			this.bunifuFlatButton4.IconMarginRight = 0;
			this.bunifuFlatButton4.IconRightVisible = true;
			this.bunifuFlatButton4.IconRightZoom = 0D;
			this.bunifuFlatButton4.IconVisible = true;
			this.bunifuFlatButton4.IconZoom = 60D;
			this.bunifuFlatButton4.IsTab = false;
			this.bunifuFlatButton4.Location = new System.Drawing.Point(651, 36);
			this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
			this.bunifuFlatButton4.Name = "bunifuFlatButton4";
			this.bunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton4.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton4.selected = false;
			this.bunifuFlatButton4.Size = new System.Drawing.Size(200, 58);
			this.bunifuFlatButton4.TabIndex = 0;
			this.bunifuFlatButton4.Text = "Impremier liste des Etudiants";
			this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
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
			this.btn_add.IconZoom = 60D;
			this.btn_add.IsTab = false;
			this.btn_add.Location = new System.Drawing.Point(8, 36);
			this.btn_add.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_add.Name = "btn_add";
			this.btn_add.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_add.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
			this.btn_add.selected = false;
			this.btn_add.Size = new System.Drawing.Size(200, 58);
			this.btn_add.TabIndex = 0;
			this.btn_add.Text = "Ajouter";
			this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_add.Textcolor = System.Drawing.Color.White;
			this.btn_add.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txt_specialit);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.txt_niveau);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.txt_groupe);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 36);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(603, 87);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Affichage liste des etudiants";
			// 
			// txt_specialit
			// 
			this.txt_specialit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_specialit.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_specialit.FormattingEnabled = true;
			this.txt_specialit.Location = new System.Drawing.Point(241, 54);
			this.txt_specialit.Name = "txt_specialit";
			this.txt_specialit.Size = new System.Drawing.Size(150, 27);
			this.txt_specialit.TabIndex = 29;
			this.txt_specialit.SelectedIndexChanged += new System.EventHandler(this.txt_specialit_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(241, 23);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(150, 32);
			this.label1.TabIndex = 30;
			this.label1.Text = "Spécialité";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_niveau
			// 
			this.txt_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_niveau.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_niveau.FormattingEnabled = true;
			this.txt_niveau.Location = new System.Drawing.Point(85, 54);
			this.txt_niveau.Name = "txt_niveau";
			this.txt_niveau.Size = new System.Drawing.Size(150, 27);
			this.txt_niveau.TabIndex = 27;
			this.txt_niveau.SelectedIndexChanged += new System.EventHandler(this.txt_niveau_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(85, 23);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(3);
			this.label2.Size = new System.Drawing.Size(150, 32);
			this.label2.TabIndex = 28;
			this.label2.Text = "Niveau";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_groupe
			// 
			this.txt_groupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_groupe.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_groupe.FormattingEnabled = true;
			this.txt_groupe.Location = new System.Drawing.Point(397, 54);
			this.txt_groupe.Name = "txt_groupe";
			this.txt_groupe.Size = new System.Drawing.Size(150, 27);
			this.txt_groupe.TabIndex = 25;
			this.txt_groupe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_groupe_KeyDown);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label12.Location = new System.Drawing.Point(397, 23);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(3);
			this.label12.Size = new System.Drawing.Size(150, 32);
			this.label12.TabIndex = 26;
			this.label12.Text = "Groupe";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 8;
			this.bunifuElipse2.TargetControl = this.btn_add;
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 8;
			this.bunifuElipse3.TargetControl = this.btn_modifier;
			// 
			// bunifuElipse4
			// 
			this.bunifuElipse4.ElipseRadius = 8;
			this.bunifuElipse4.TargetControl = this.btn_supprimer;
			// 
			// bunifuElipse5
			// 
			this.bunifuElipse5.ElipseRadius = 8;
			this.bunifuElipse5.TargetControl = this.bunifuFlatButton1;
			// 
			// bunifuElipse6
			// 
			this.bunifuElipse6.ElipseRadius = 8;
			this.bunifuElipse6.TargetControl = this.bunifuFlatButton4;
			// 
			// Gestion_etudiant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Gestion_etudiant";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion_etudiant";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.affichage_resultat)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cherche;
        private Bunifu.Framework.UI.BunifuFlatButton btn_modifier;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        public Bunifu.Framework.UI.BunifuCustomDataGrid affichage_resultat;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txt_specialit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_niveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_groupe;
        private System.Windows.Forms.Label label12;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeÉtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatScolaritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supprimierToolStripMenuItem;
		private System.Windows.Forms.Label label22;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
	}
}