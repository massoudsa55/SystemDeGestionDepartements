namespace Projet_final_00
{
	partial class home
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_tm = new System.Windows.Forms.Label();
            this.sur = new System.Windows.Forms.Button();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.admin = new System.Windows.Forms.Button();
            this.prof = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.config_server = new System.Windows.Forms.Button();
            this.etudiant = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uC_0011 = new Projet_final_00.UC_file.UC_001();
            this.uC_0021 = new Projet_final_00.UC_file.UC_002();
            this.uC_0031 = new Projet_final_00.UC_file.UC_003();
            this.uC_0041 = new Projet_final_00.UC_file.UC_004();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sortir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.data_tm);
            this.panel2.Controls.Add(this.sur);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.admin);
            this.panel2.Controls.Add(this.prof);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.config_server);
            this.panel2.Controls.Add(this.etudiant);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 90);
            this.panel2.TabIndex = 0;
            // 
            // data_tm
            // 
            this.data_tm.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.data_tm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.data_tm, BunifuAnimatorNS.DecorationType.None);
            this.data_tm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_tm.Location = new System.Drawing.Point(624, 62);
            this.data_tm.Name = "data_tm";
            this.data_tm.Size = new System.Drawing.Size(56, 23);
            this.data_tm.TabIndex = 6;
            this.data_tm.Text = "label4";
            // 
            // sur
            // 
            this.sur.BackgroundImage = global::Projet_final_00.Properties.Resources.info;
            this.sur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.sur, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.sur, BunifuAnimatorNS.DecorationType.None);
            this.sur.FlatAppearance.BorderSize = 0;
            this.sur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sur.Location = new System.Drawing.Point(518, -1);
            this.sur.Name = "sur";
            this.sur.Size = new System.Drawing.Size(100, 86);
            this.sur.TabIndex = 5;
            this.toolTip1.SetToolTip(this.sur, "àpropose de");
            this.sur.UseVisualStyleBackColor = true;
            this.sur.Click += new System.EventHandler(this.sur_Click_1);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.circularProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.circularProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.MintCream;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(840, -1);
            this.circularProgressBar1.MarqueeAnimationSpeed = 5000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.circularProgressBar1.OuterMargin = -10;
            this.circularProgressBar1.OuterWidth = 10;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.circularProgressBar1.ProgressWidth = 8;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(90, 90);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(-35, 3, -10, -10);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Text = "00:00:00";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar1.Value = 12;
            // 
            // admin
            // 
            this.admin.BackgroundImage = global::Projet_final_00.Properties.Resources.man_1_;
            this.admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.admin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.admin, BunifuAnimatorNS.DecorationType.None);
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Location = new System.Drawing.Point(110, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(100, 90);
            this.admin.TabIndex = 0;
            this.toolTip1.SetToolTip(this.admin, "Administrations");
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // prof
            // 
            this.prof.BackgroundImage = global::Projet_final_00.Properties.Resources.team;
            this.prof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.prof, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.prof, BunifuAnimatorNS.DecorationType.None);
            this.prof.FlatAppearance.BorderSize = 0;
            this.prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof.Location = new System.Drawing.Point(210, 0);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(100, 90);
            this.prof.TabIndex = 0;
            this.toolTip1.SetToolTip(this.prof, "Enseignants");
            this.prof.UseVisualStyleBackColor = true;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Projet_final_00.Properties.Resources.house;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 90);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Page d\'accueil");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.home_Click);
            // 
            // config_server
            // 
            this.config_server.BackgroundImage = global::Projet_final_00.Properties.Resources.settings_1_;
            this.config_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.config_server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.config_server, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.config_server, BunifuAnimatorNS.DecorationType.None);
            this.config_server.FlatAppearance.BorderSize = 0;
            this.config_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_server.Location = new System.Drawing.Point(412, 3);
            this.config_server.Name = "config_server";
            this.config_server.Size = new System.Drawing.Size(100, 86);
            this.config_server.TabIndex = 0;
            this.toolTip1.SetToolTip(this.config_server, "Configuration de server");
            this.config_server.UseVisualStyleBackColor = true;
            this.config_server.Click += new System.EventHandler(this.sur_Click);
            // 
            // etudiant
            // 
            this.etudiant.BackgroundImage = global::Projet_final_00.Properties.Resources.team_1_;
            this.etudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.etudiant, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.etudiant, BunifuAnimatorNS.DecorationType.None);
            this.etudiant.FlatAppearance.BorderSize = 0;
            this.etudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.etudiant.Location = new System.Drawing.Point(310, 0);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(100, 90);
            this.etudiant.TabIndex = 0;
            this.toolTip1.SetToolTip(this.etudiant, "Etudiants");
            this.etudiant.UseVisualStyleBackColor = true;
            this.etudiant.Click += new System.EventHandler(this.etudiant_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 75);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "         جامعة زيان عاشور-الجلفة\r\n             كلية العلوم والتكنولوجيا\r\n  قسم ال" +
    "علوم الدقيقة والإعلام الآلي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Université Ziane achour-Djelfa\r\nFaculté de science et technologie\r\nDépartement de" +
    " Mathematique et informatique\r\n";
            // 
            // pictureBox2
            // 
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Projet_final_00.Properties.Resources.Logo_uzad;
            this.pictureBox2.Location = new System.Drawing.Point(857, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Projet_final_00.Properties.Resources.Logo_uzad;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uC_0011);
            this.panel4.Controls.Add(this.uC_0021);
            this.panel4.Controls.Add(this.uC_0031);
            this.panel4.Controls.Add(this.uC_0041);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 302);
            this.panel4.TabIndex = 1;
            // 
            // uC_0011
            // 
            this.uC_0011.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_0011.BackgroundImage")));
            this.uC_0011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.uC_0011, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uC_0011, BunifuAnimatorNS.DecorationType.None);
            this.uC_0011.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_0011.Location = new System.Drawing.Point(0, 0);
            this.uC_0011.Name = "uC_0011";
            this.uC_0011.Size = new System.Drawing.Size(934, 302);
            this.uC_0011.TabIndex = 3;
            // 
            // uC_0021
            // 
            this.uC_0021.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_0021.BackgroundImage")));
            this.uC_0021.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.uC_0021, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uC_0021, BunifuAnimatorNS.DecorationType.None);
            this.uC_0021.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_0021.Location = new System.Drawing.Point(0, 0);
            this.uC_0021.Name = "uC_0021";
            this.uC_0021.Size = new System.Drawing.Size(934, 302);
            this.uC_0021.TabIndex = 2;
            this.uC_0021.Visible = false;
            // 
            // uC_0031
            // 
            this.uC_0031.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_0031.BackgroundImage")));
            this.uC_0031.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.uC_0031, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uC_0031, BunifuAnimatorNS.DecorationType.None);
            this.uC_0031.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_0031.Location = new System.Drawing.Point(0, 0);
            this.uC_0031.Name = "uC_0031";
            this.uC_0031.Size = new System.Drawing.Size(934, 302);
            this.uC_0031.TabIndex = 1;
            this.uC_0031.Visible = false;
            // 
            // uC_0041
            // 
            this.uC_0041.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_0041.BackgroundImage")));
            this.uC_0041.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.uC_0041, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uC_0041, BunifuAnimatorNS.DecorationType.None);
            this.uC_0041.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_0041.Location = new System.Drawing.Point(0, 0);
            this.uC_0041.Name = "uC_0041";
            this.uC_0041.Size = new System.Drawing.Size(934, 302);
            this.uC_0041.TabIndex = 0;
            this.uC_0041.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sortir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 45);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.minus;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(860, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button2, "Minimise");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sortir
            // 
            this.sortir.BackgroundImage = global::Projet_final_00.Properties.Resources.close_cross_circular_interface_button;
            this.sortir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.sortir, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.sortir, BunifuAnimatorNS.DecorationType.None);
            this.sortir.FlatAppearance.BorderSize = 0;
            this.sortir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortir.Location = new System.Drawing.Point(894, 9);
            this.sortir.Name = "sortir";
            this.sortir.Size = new System.Drawing.Size(28, 28);
            this.sortir.TabIndex = 0;
            this.toolTip1.SetToolTip(this.sortir, "Exit");
            this.sortir.UseVisualStyleBackColor = true;
            this.sortir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page d\'accueil";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::Projet_final_00.Properties.Resources.facebook;
            this.pictureBox4.Location = new System.Drawing.Point(785, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Facebook");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Projet_final_00.Properties.Resources.worldwide;
            this.pictureBox3.Location = new System.Drawing.Point(743, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Site web");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'accueil";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button sortir;
		private System.Windows.Forms.Panel panel4;
		private UC_file.UC_004 uC_0041;
		private UC_file.UC_001 uC_0011;
		private UC_file.UC_002 uC_0021;
		private UC_file.UC_003 uC_0031;
		private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
		private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button config_server;
        public System.Windows.Forms.Button admin;
        public System.Windows.Forms.Button prof;
        public System.Windows.Forms.Button etudiant;
		private CircularProgressBar.CircularProgressBar circularProgressBar1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button sur;
		private System.Windows.Forms.Label data_tm;
	}
}

