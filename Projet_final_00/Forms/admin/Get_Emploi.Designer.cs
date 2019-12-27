namespace Projet_final_00.Forms.admin
{
    partial class Get_Emploi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_Emploi));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dgv_get_emploi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_get_emploi)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(673, 27);
			this.panel1.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(251, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 25);
			this.label8.TabIndex = 8;
			this.label8.Text = "Listes d\'emplois";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Projet_final_00.Properties.Resources.power_button;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(646, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 27);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dgv_get_emploi
			// 
			this.dgv_get_emploi.AllowUserToAddRows = false;
			this.dgv_get_emploi.AllowUserToDeleteRows = false;
			this.dgv_get_emploi.AllowUserToResizeColumns = false;
			this.dgv_get_emploi.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgv_get_emploi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_get_emploi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_get_emploi.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgv_get_emploi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_get_emploi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_get_emploi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_get_emploi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_get_emploi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_get_emploi.DoubleBuffered = true;
			this.dgv_get_emploi.EnableHeadersVisualStyles = false;
			this.dgv_get_emploi.HeaderBgColor = System.Drawing.Color.DarkTurquoise;
			this.dgv_get_emploi.HeaderForeColor = System.Drawing.SystemColors.WindowText;
			this.dgv_get_emploi.Location = new System.Drawing.Point(0, 27);
			this.dgv_get_emploi.MultiSelect = false;
			this.dgv_get_emploi.Name = "dgv_get_emploi";
			this.dgv_get_emploi.ReadOnly = true;
			this.dgv_get_emploi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_get_emploi.RowHeadersVisible = false;
			this.dgv_get_emploi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_get_emploi.Size = new System.Drawing.Size(673, 392);
			this.dgv_get_emploi.TabIndex = 3;
			this.dgv_get_emploi.DoubleClick += new System.EventHandler(this.dgv_get_emploi_DoubleClick);
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
			// Get_Emploi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 419);
			this.Controls.Add(this.dgv_get_emploi);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Get_Emploi";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Get_Emploi";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_get_emploi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_get_emploi;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label8;
    }
}