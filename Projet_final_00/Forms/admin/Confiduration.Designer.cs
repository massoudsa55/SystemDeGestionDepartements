namespace Projet_final_00.Forms.admin
{
	partial class Confiduration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confiduration));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.show = new System.Windows.Forms.CheckBox();
			this.txt_conferm_mot_passe = new System.Windows.Forms.TextBox();
			this.txt_nouv_mot_passe = new System.Windows.Forms.TextBox();
			this.txt_mot_passe = new System.Windows.Forms.TextBox();
			this.txt_nom_user = new System.Windows.Forms.TextBox();
			this.txt_type = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label2 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(345, 27);
			this.panel1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(318, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 27);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(3, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 20);
			this.label8.TabIndex = 0;
			this.label8.Text = "Configuration";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(58)))));
			this.panel2.Controls.Add(this.show);
			this.panel2.Controls.Add(this.txt_conferm_mot_passe);
			this.panel2.Controls.Add(this.txt_nouv_mot_passe);
			this.panel2.Controls.Add(this.txt_mot_passe);
			this.panel2.Controls.Add(this.txt_nom_user);
			this.panel2.Controls.Add(this.txt_type);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.ForeColor = System.Drawing.SystemColors.Window;
			this.panel2.Location = new System.Drawing.Point(6, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(335, 336);
			this.panel2.TabIndex = 0;
			// 
			// show
			// 
			this.show.AutoSize = true;
			this.show.BackColor = System.Drawing.Color.Transparent;
			this.show.Cursor = System.Windows.Forms.Cursors.Hand;
			this.show.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.show.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.show.Location = new System.Drawing.Point(152, 305);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(169, 21);
			this.show.TabIndex = 5;
			this.show.Text = "Affecher mote de passe";
			this.show.UseVisualStyleBackColor = false;
			this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
			// 
			// txt_conferm_mot_passe
			// 
			this.txt_conferm_mot_passe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_conferm_mot_passe.Location = new System.Drawing.Point(152, 213);
			this.txt_conferm_mot_passe.Name = "txt_conferm_mot_passe";
			this.txt_conferm_mot_passe.Size = new System.Drawing.Size(168, 27);
			this.txt_conferm_mot_passe.TabIndex = 3;
			this.txt_conferm_mot_passe.UseSystemPasswordChar = true;
			this.txt_conferm_mot_passe.Validated += new System.EventHandler(this.conferm);
			// 
			// txt_nouv_mot_passe
			// 
			this.txt_nouv_mot_passe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nouv_mot_passe.Location = new System.Drawing.Point(152, 161);
			this.txt_nouv_mot_passe.Name = "txt_nouv_mot_passe";
			this.txt_nouv_mot_passe.Size = new System.Drawing.Size(168, 27);
			this.txt_nouv_mot_passe.TabIndex = 2;
			this.txt_nouv_mot_passe.UseSystemPasswordChar = true;
			// 
			// txt_mot_passe
			// 
			this.txt_mot_passe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_mot_passe.Location = new System.Drawing.Point(152, 109);
			this.txt_mot_passe.Name = "txt_mot_passe";
			this.txt_mot_passe.Size = new System.Drawing.Size(168, 27);
			this.txt_mot_passe.TabIndex = 1;
			this.txt_mot_passe.UseSystemPasswordChar = true;
			// 
			// txt_nom_user
			// 
			this.txt_nom_user.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nom_user.Location = new System.Drawing.Point(152, 56);
			this.txt_nom_user.Name = "txt_nom_user";
			this.txt_nom_user.Size = new System.Drawing.Size(168, 27);
			this.txt_nom_user.TabIndex = 0;
			// 
			// txt_type
			// 
			this.txt_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.txt_type.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_type.FormattingEnabled = true;
			this.txt_type.Location = new System.Drawing.Point(152, 261);
			this.txt_type.Name = "txt_type";
			this.txt_type.Size = new System.Drawing.Size(168, 31);
			this.txt_type.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(13, 213);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Confermer :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label6.Location = new System.Drawing.Point(13, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Nouveau :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(13, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Mot de passe :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(13, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nom utilisateur :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(13, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Type utilisateur :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informations";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.bunifuFlatButton2);
			this.panel3.Controls.Add(this.bunifuFlatButton1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(6, 370);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(335, 71);
			this.panel3.TabIndex = 1;
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "Enregistrer";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = global::Projet_final_00.Properties.Resources.add;
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 50D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(15, 27);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(145, 37);
			this.bunifuFlatButton2.TabIndex = 0;
			this.bunifuFlatButton2.Text = "Enregistrer";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "Annuler";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = global::Projet_final_00.Properties.Resources.remove;
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 50D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(176, 27);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.HotTrack;
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(145, 37);
			this.bunifuFlatButton1.TabIndex = 1;
			this.bunifuFlatButton1.Text = "Annuler";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.annule);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Highlight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Opérations";
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
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 15;
			this.bunifuElipse2.TargetControl = this.panel2;
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 15;
			this.bunifuElipse3.TargetControl = this.panel3;
			// 
			// bunifuElipse4
			// 
			this.bunifuElipse4.ElipseRadius = 10;
			this.bunifuElipse4.TargetControl = this.bunifuFlatButton1;
			// 
			// bunifuElipse5
			// 
			this.bunifuElipse5.ElipseRadius = 10;
			this.bunifuElipse5.TargetControl = this.bunifuFlatButton2;
			// 
			// Confiduration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(345, 446);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Confiduration";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Confiduration";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_conferm_mot_passe;
		private System.Windows.Forms.TextBox txt_nouv_mot_passe;
		private System.Windows.Forms.TextBox txt_mot_passe;
		private System.Windows.Forms.TextBox txt_nom_user;
		private System.Windows.Forms.ComboBox txt_type;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private System.Windows.Forms.CheckBox show;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}