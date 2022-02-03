namespace Provetex.Purchase
{
    partial class F_RD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RD));
            this.DataGrid_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Textbox_searsh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_list.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.add});
            this.DataGrid_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.DataGrid_list.Location = new System.Drawing.Point(16, 182);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(776, 388);
            this.DataGrid_list.TabIndex = 6;
            this.DataGrid_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_list_CellContentClick);
            // 
            // Textbox_searsh
            // 
            this.Textbox_searsh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_searsh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_searsh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_searsh.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_searsh.HintText = "Rechercher ...";
            this.Textbox_searsh.isPassword = false;
            this.Textbox_searsh.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_searsh.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_searsh.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_searsh.LineThickness = 3;
            this.Textbox_searsh.Location = new System.Drawing.Point(541, 142);
            this.Textbox_searsh.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_searsh.Name = "Textbox_searsh";
            this.Textbox_searsh.Size = new System.Drawing.Size(211, 33);
            this.Textbox_searsh.TabIndex = 8;
            this.Textbox_searsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_searsh.OnValueChanged += new System.EventHandler(this.Textbox_searsh_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sunshine", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Achat";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 32;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 32;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Bon";
            this.dataGridViewImageColumn3.Image = global::Provetex.Properties.Resources.icons8_add_dollar_16;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Provetex.Properties.Resources.icons8_refresh_64;
            this.pictureBox2.Location = new System.Drawing.Point(759, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 32;
            // 
            // add
            // 
            this.add.HeaderText = "Bon";
            this.add.Image = global::Provetex.Properties.Resources.icons8_add_dollar_16;
            this.add.Name = "add";
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.add.Width = 32;
            // 
            // F_RD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_searsh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_RD";
            this.Text = "F_RD";
            this.Load += new System.EventHandler(this.F_RD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_searsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn add;
    }
}