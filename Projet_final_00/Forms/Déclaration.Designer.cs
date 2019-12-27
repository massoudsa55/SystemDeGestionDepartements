namespace Projet_final_00.Forms
{
	partial class Déclaration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Déclaration));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_objet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_message = new System.Windows.Forms.RichTextBox();
			this.btn_envoyer = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.show = new System.Windows.Forms.CheckBox();
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 27);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "Déclaration";
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::Projet_final_00.Properties.Resources.minimize;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.Dock = System.Windows.Forms.DockStyle.Right;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(323, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(27, 27);
			this.button5.TabIndex = 11;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Dock = System.Windows.Forms.DockStyle.Right;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(350, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(27, 27);
			this.button3.TabIndex = 12;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 528);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(377, 27);
			this.panel2.TabIndex = 0;
			// 
			// txt_email
			// 
			this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_email.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_email.ForeColor = System.Drawing.Color.Silver;
			this.txt_email.HintForeColor = System.Drawing.Color.Silver;
			this.txt_email.HintText = "";
			this.txt_email.isPassword = false;
			this.txt_email.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
			this.txt_email.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_email.LineMouseHoverColor = System.Drawing.SystemColors.HotTrack;
			this.txt_email.LineThickness = 3;
			this.txt_email.Location = new System.Drawing.Point(27, 34);
			this.txt_email.Margin = new System.Windows.Forms.Padding(4);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(323, 49);
			this.txt_email.TabIndex = 1;
			this.txt_email.Text = "Adresse email";
			this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
			this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
			// 
			// txt_objet
			// 
			this.txt_objet.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_objet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_objet.ForeColor = System.Drawing.Color.Silver;
			this.txt_objet.HintForeColor = System.Drawing.Color.Silver;
			this.txt_objet.HintText = "";
			this.txt_objet.isPassword = false;
			this.txt_objet.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
			this.txt_objet.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_objet.LineMouseHoverColor = System.Drawing.SystemColors.HotTrack;
			this.txt_objet.LineThickness = 3;
			this.txt_objet.Location = new System.Drawing.Point(27, 169);
			this.txt_objet.Margin = new System.Windows.Forms.Padding(4);
			this.txt_objet.Name = "txt_objet";
			this.txt_objet.Size = new System.Drawing.Size(323, 49);
			this.txt_objet.TabIndex = 3;
			this.txt_objet.Text = "Objet";
			this.txt_objet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_objet.Enter += new System.EventHandler(this.txt_objet_Enter);
			this.txt_objet.Leave += new System.EventHandler(this.txt_objet_Leave);
			// 
			// txt_message
			// 
			this.txt_message.BackColor = System.Drawing.SystemColors.Menu;
			this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_message.Location = new System.Drawing.Point(27, 225);
			this.txt_message.Name = "txt_message";
			this.txt_message.Size = new System.Drawing.Size(323, 272);
			this.txt_message.TabIndex = 4;
			this.txt_message.Text = "";
			// 
			// btn_envoyer
			// 
			this.btn_envoyer.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btn_envoyer.FlatAppearance.BorderSize = 0;
			this.btn_envoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_envoyer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_envoyer.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_envoyer.Location = new System.Drawing.Point(27, 500);
			this.btn_envoyer.Name = "btn_envoyer";
			this.btn_envoyer.Size = new System.Drawing.Size(150, 25);
			this.btn_envoyer.TabIndex = 5;
			this.btn_envoyer.Text = "Envoyer";
			this.btn_envoyer.UseVisualStyleBackColor = false;
			this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btn_close.FlatAppearance.BorderSize = 0;
			this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_close.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_close.Location = new System.Drawing.Point(200, 500);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(150, 25);
			this.btn_close.TabIndex = 5;
			this.btn_close.Text = "Fermer";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.button3_Click);
			// 
			// show
			// 
			this.show.AutoSize = true;
			this.show.BackColor = System.Drawing.Color.Transparent;
			this.show.Cursor = System.Windows.Forms.Cursors.Hand;
			this.show.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.show.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.show.Location = new System.Drawing.Point(181, 154);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(169, 21);
			this.show.TabIndex = 6;
			this.show.Text = "Affecher mote de passe";
			this.show.UseVisualStyleBackColor = false;
			this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 6;
			this.bunifuElipse2.TargetControl = this.btn_close;
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 6;
			this.bunifuElipse3.TargetControl = this.btn_envoyer;
			// 
			// txt_pass
			// 
			this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
			this.txt_pass.ForeColor = System.Drawing.Color.Silver;
			this.txt_pass.HintForeColor = System.Drawing.Color.Empty;
			this.txt_pass.HintText = "";
			this.txt_pass.isPassword = false;
			this.txt_pass.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
			this.txt_pass.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_pass.LineMouseHoverColor = System.Drawing.SystemColors.HotTrack;
			this.txt_pass.LineThickness = 3;
			this.txt_pass.Location = new System.Drawing.Point(30, 91);
			this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(320, 44);
			this.txt_pass.TabIndex = 7;
			this.txt_pass.Text = "Mot de passe";
			this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
			this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
			// 
			// Déclaration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(377, 555);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.show);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_envoyer);
			this.Controls.Add(this.txt_message);
			this.Controls.Add(this.txt_objet);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Déclaration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Déclaration";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txt_email;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txt_objet;
		private System.Windows.Forms.RichTextBox txt_message;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_envoyer;
		private System.Windows.Forms.CheckBox show;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
	}
}