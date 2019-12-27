namespace Projet_final_00.Forms.admin
{
	partial class Ajouter_ensiegnant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_ensiegnant));
            this.btn_anneler = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_date_naissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address_enseignant = new System.Windows.Forms.TextBox();
            this.txt_lien_naissance = new System.Windows.Forms.TextBox();
            this.txt_penom_enseignant = new System.Windows.Forms.TextBox();
            this.txt_nom_enseignant = new System.Windows.Forms.TextBox();
            this.txt_id_enseignant = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_modifier = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_anneler
            // 
            this.btn_anneler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_anneler.FlatAppearance.BorderSize = 0;
            this.btn_anneler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anneler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anneler.ForeColor = System.Drawing.Color.White;
            this.btn_anneler.Image = global::Projet_final_00.Properties.Resources.remove;
            this.btn_anneler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anneler.Location = new System.Drawing.Point(208, 543);
            this.btn_anneler.Name = "btn_anneler";
            this.btn_anneler.Size = new System.Drawing.Size(170, 32);
            this.btn_anneler.TabIndex = 14;
            this.btn_anneler.Text = "Anneler";
            this.btn_anneler.UseVisualStyleBackColor = false;
            this.btn_anneler.Click += new System.EventHandler(this.btn_anneler_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_enregistrer.FlatAppearance.BorderSize = 0;
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Image = global::Projet_final_00.Properties.Resources.add;
            this.btn_enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enregistrer.Location = new System.Drawing.Point(10, 543);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(170, 32);
            this.btn_enregistrer.TabIndex = 10;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txt_date_naissance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_telephone);
            this.panel3.Controls.Add(this.txt_grade);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.txt_address_enseignant);
            this.panel3.Controls.Add(this.txt_lien_naissance);
            this.panel3.Controls.Add(this.txt_penom_enseignant);
            this.panel3.Controls.Add(this.txt_nom_enseignant);
            this.panel3.Controls.Add(this.txt_id_enseignant);
            this.panel3.Location = new System.Drawing.Point(8, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 483);
            this.panel3.TabIndex = 13;
            // 
            // txt_date_naissance
            // 
            this.txt_date_naissance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date_naissance.Location = new System.Drawing.Point(169, 174);
            this.txt_date_naissance.Name = "txt_date_naissance";
            this.txt_date_naissance.Size = new System.Drawing.Size(179, 26);
            this.txt_date_naissance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Lien De Naissance :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade Ensiegnant :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email Ensiegnant :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address Ensiegnant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date De Naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prénom Ensiegnant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom Ensiegnant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numiro d\'inscrit :";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(169, 377);
            this.txt_telephone.MaxLength = 10;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(179, 26);
            this.txt_telephone.TabIndex = 7;
            // 
            // txt_grade
            // 
            this.txt_grade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grade.Location = new System.Drawing.Point(168, 422);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(179, 26);
            this.txt_grade.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(168, 333);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(179, 26);
            this.txt_email.TabIndex = 6;
            // 
            // txt_address_enseignant
            // 
            this.txt_address_enseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_enseignant.Location = new System.Drawing.Point(169, 255);
            this.txt_address_enseignant.Multiline = true;
            this.txt_address_enseignant.Name = "txt_address_enseignant";
            this.txt_address_enseignant.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_address_enseignant.Size = new System.Drawing.Size(179, 63);
            this.txt_address_enseignant.TabIndex = 5;
            // 
            // txt_lien_naissance
            // 
            this.txt_lien_naissance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lien_naissance.Location = new System.Drawing.Point(169, 213);
            this.txt_lien_naissance.Name = "txt_lien_naissance";
            this.txt_lien_naissance.Size = new System.Drawing.Size(179, 26);
            this.txt_lien_naissance.TabIndex = 4;
            // 
            // txt_penom_enseignant
            // 
            this.txt_penom_enseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penom_enseignant.Location = new System.Drawing.Point(169, 130);
            this.txt_penom_enseignant.Name = "txt_penom_enseignant";
            this.txt_penom_enseignant.Size = new System.Drawing.Size(179, 26);
            this.txt_penom_enseignant.TabIndex = 2;
            // 
            // txt_nom_enseignant
            // 
            this.txt_nom_enseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_enseignant.Location = new System.Drawing.Point(168, 87);
            this.txt_nom_enseignant.Name = "txt_nom_enseignant";
            this.txt_nom_enseignant.Size = new System.Drawing.Size(179, 26);
            this.txt_nom_enseignant.TabIndex = 1;
            // 
            // txt_id_enseignant
            // 
            this.txt_id_enseignant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_enseignant.Location = new System.Drawing.Point(168, 48);
            this.txt_id_enseignant.Name = "txt_id_enseignant";
            this.txt_id_enseignant.Size = new System.Drawing.Size(179, 26);
            this.txt_id_enseignant.TabIndex = 0;
            this.txt_id_enseignant.Validated += new System.EventHandler(this.txt_id_enseignant_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txt_modifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 44);
            this.panel1.TabIndex = 12;
            // 
            // txt_modifier
            // 
            this.txt_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modifier.ForeColor = System.Drawing.Color.White;
            this.txt_modifier.Location = new System.Drawing.Point(13, 9);
            this.txt_modifier.Name = "txt_modifier";
            this.txt_modifier.Size = new System.Drawing.Size(160, 27);
            this.txt_modifier.TabIndex = 0;
            this.txt_modifier.Text = "Ajoute Ensiegnant";
            this.txt_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.btn_anneler;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.btn_enregistrer;
            // 
            // Ajouter_ensiegnant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(388, 584);
            this.Controls.Add(this.btn_anneler);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajouter_ensiegnant";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_ensiegnant";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_anneler;
		private System.Windows.Forms.Button btn_enregistrer;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.DateTimePicker txt_date_naissance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txt_telephone;
		public System.Windows.Forms.TextBox txt_email;
		public System.Windows.Forms.TextBox txt_address_enseignant;
		public System.Windows.Forms.TextBox txt_lien_naissance;
		public System.Windows.Forms.TextBox txt_penom_enseignant;
		public System.Windows.Forms.TextBox txt_nom_enseignant;
		public System.Windows.Forms.TextBox txt_id_enseignant;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label txt_modifier;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txt_grade;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
	}
}