namespace Projet_final_00.Forms.admin
{
	partial class Print
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mod = new System.Windows.Forms.Label();
            this.txt_print = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_group = new System.Windows.Forms.ComboBox();
            this.txt_spec = new System.Windows.Forms.ComboBox();
            this.txt_niveau = new System.Windows.Forms.ComboBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(148, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Imprémier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spécialité :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Niveau :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Groupe :";
            // 
            // txt_mod
            // 
            this.txt_mod.AutoSize = true;
            this.txt_mod.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mod.ForeColor = System.Drawing.Color.White;
            this.txt_mod.Location = new System.Drawing.Point(19, 211);
            this.txt_mod.Name = "txt_mod";
            this.txt_mod.Size = new System.Drawing.Size(58, 16);
            this.txt_mod.TabIndex = 2;
            this.txt_mod.Text = "Model :";
            // 
            // txt_print
            // 
            this.txt_print.AutoSize = true;
            this.txt_print.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_print.ForeColor = System.Drawing.Color.White;
            this.txt_print.Location = new System.Drawing.Point(12, 14);
            this.txt_print.Name = "txt_print";
            this.txt_print.Size = new System.Drawing.Size(63, 21);
            this.txt_print.TabIndex = 4;
            this.txt_print.Text = "label5";
            // 
            // txt_Model
            // 
            this.txt_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_Model.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model.FormattingEnabled = true;
            this.txt_Model.Location = new System.Drawing.Point(95, 208);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(149, 22);
            this.txt_Model.TabIndex = 3;
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
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(255, 316);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 243;
            this.lineShape2.Y1 = 52;
            this.lineShape2.Y2 = 52;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 240;
            this.lineShape1.Y1 = 260;
            this.lineShape1.Y2 = 260;
            // 
            // txt_group
            // 
            this.txt_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_group.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txt_group.FormattingEnabled = true;
            this.txt_group.Location = new System.Drawing.Point(108, 163);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(120, 27);
            this.txt_group.TabIndex = 2;
            // 
            // txt_spec
            // 
            this.txt_spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_spec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_spec.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txt_spec.FormattingEnabled = true;
            this.txt_spec.Location = new System.Drawing.Point(108, 116);
            this.txt_spec.Name = "txt_spec";
            this.txt_spec.Size = new System.Drawing.Size(120, 27);
            this.txt_spec.TabIndex = 1;
            this.txt_spec.SelectedIndexChanged += new System.EventHandler(this.txt_spec_SelectedIndexChanged);
            // 
            // txt_niveau
            // 
            this.txt_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_niveau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_niveau.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txt_niveau.FormattingEnabled = true;
            this.txt_niveau.Location = new System.Drawing.Point(108, 68);
            this.txt_niveau.Name = "txt_niveau";
            this.txt_niveau.Size = new System.Drawing.Size(120, 27);
            this.txt_niveau.TabIndex = 0;
            this.txt_niveau.SelectedIndexChanged += new System.EventHandler(this.txt_niveau_SelectedIndexChanged);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.button1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.button2;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(255, 316);
            this.Controls.Add(this.txt_niveau);
            this.Controls.Add(this.txt_spec);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_print);
            this.Controls.Add(this.txt_mod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Print";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		public System.Windows.Forms.Label txt_mod;
		public System.Windows.Forms.Label txt_print;
		public System.Windows.Forms.ComboBox txt_Model;
		public System.Windows.Forms.ComboBox txt_niveau;
		public System.Windows.Forms.ComboBox txt_spec;
		public System.Windows.Forms.ComboBox txt_group;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}