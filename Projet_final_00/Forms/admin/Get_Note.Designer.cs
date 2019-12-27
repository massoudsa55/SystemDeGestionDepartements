namespace Projet_final_00.Forms.admin
{
    partial class Get_Note
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_Note));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_specialit = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_niveau = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_groupe = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_note = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_note)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(918, 27);
			this.panel1.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(381, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 25);
			this.label8.TabIndex = 6;
			this.label8.Text = "Listes des notes";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(891, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 27);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Controls.Add(this.txt_specialit);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txt_niveau);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txt_groupe);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(918, 92);
			this.panel2.TabIndex = 1;
			// 
			// txt_specialit
			// 
			this.txt_specialit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_specialit.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_specialit.FormattingEnabled = true;
			this.txt_specialit.Location = new System.Drawing.Point(397, 47);
			this.txt_specialit.Name = "txt_specialit";
			this.txt_specialit.Size = new System.Drawing.Size(150, 27);
			this.txt_specialit.TabIndex = 23;
			this.txt_specialit.SelectedIndexChanged += new System.EventHandler(this.txt_specialit_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(397, 16);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(3);
			this.label3.Size = new System.Drawing.Size(150, 32);
			this.label3.TabIndex = 24;
			this.label3.Text = "Spécialité";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_niveau
			// 
			this.txt_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_niveau.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_niveau.FormattingEnabled = true;
			this.txt_niveau.Location = new System.Drawing.Point(247, 47);
			this.txt_niveau.Name = "txt_niveau";
			this.txt_niveau.Size = new System.Drawing.Size(150, 27);
			this.txt_niveau.TabIndex = 21;
			this.txt_niveau.SelectedIndexChanged += new System.EventHandler(this.txt_niveau_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(247, 16);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(150, 32);
			this.label1.TabIndex = 22;
			this.label1.Text = "Niveau";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_groupe
			// 
			this.txt_groupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_groupe.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txt_groupe.FormattingEnabled = true;
			this.txt_groupe.Location = new System.Drawing.Point(547, 47);
			this.txt_groupe.Name = "txt_groupe";
			this.txt_groupe.Size = new System.Drawing.Size(150, 27);
			this.txt_groupe.TabIndex = 19;
			this.txt_groupe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_groupe_KeyPress);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label12.Location = new System.Drawing.Point(547, 16);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(3);
			this.label12.Size = new System.Drawing.Size(150, 32);
			this.label12.TabIndex = 20;
			this.label12.Text = "Groupe";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "Informations";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgv_note
			// 
			this.dgv_note.AllowUserToAddRows = false;
			this.dgv_note.AllowUserToDeleteRows = false;
			this.dgv_note.AllowUserToResizeColumns = false;
			this.dgv_note.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgv_note.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_note.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgv_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_note.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_note.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_note.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_note.DoubleBuffered = true;
			this.dgv_note.EnableHeadersVisualStyles = false;
			this.dgv_note.HeaderBgColor = System.Drawing.Color.DarkTurquoise;
			this.dgv_note.HeaderForeColor = System.Drawing.Color.White;
			this.dgv_note.Location = new System.Drawing.Point(0, 119);
			this.dgv_note.MultiSelect = false;
			this.dgv_note.Name = "dgv_note";
			this.dgv_note.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_note.RowHeadersVisible = false;
			this.dgv_note.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_note.Size = new System.Drawing.Size(918, 327);
			this.dgv_note.TabIndex = 2;
			this.dgv_note.DoubleClick += new System.EventHandler(this.dgv_note_DoubleClick);
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
			// Get_Note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 446);
			this.Controls.Add(this.dgv_note);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Get_Note";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get_Note";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_note)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox txt_specialit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox txt_niveau;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox txt_groupe;
		private System.Windows.Forms.Label label12;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_note;
        private System.Windows.Forms.Button button2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label8;
    }
}