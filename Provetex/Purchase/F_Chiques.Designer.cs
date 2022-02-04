namespace Provetex.Purchase
{
    partial class F_Chiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Chiques));
            this.DataGrid_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Textbox_searsh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_sup = new System.Windows.Forms.RadioButton();
            this.radioButton_num = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.DataGrid_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.DataGrid_list.Location = new System.Drawing.Point(12, 183);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(776, 388);
            this.DataGrid_list.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sunshine", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chiques";
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
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(762, 147);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(25, 25);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
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
            this.Textbox_searsh.Location = new System.Drawing.Point(576, 143);
            this.Textbox_searsh.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_searsh.Name = "Textbox_searsh";
            this.Textbox_searsh.Size = new System.Drawing.Size(211, 33);
            this.Textbox_searsh.TabIndex = 14;
            this.Textbox_searsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_searsh.OnValueChanged += new System.EventHandler(this.Textbox_searsh_OnValueChanged);
            this.Textbox_searsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_searsh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rcherche avec :";
            // 
            // radioButton_sup
            // 
            this.radioButton_sup.AutoSize = true;
            this.radioButton_sup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_sup.Location = new System.Drawing.Point(479, 151);
            this.radioButton_sup.Name = "radioButton_sup";
            this.radioButton_sup.Size = new System.Drawing.Size(89, 19);
            this.radioButton_sup.TabIndex = 17;
            this.radioButton_sup.TabStop = true;
            this.radioButton_sup.Text = "Fournisseur";
            this.radioButton_sup.UseVisualStyleBackColor = true;
            // 
            // radioButton_num
            // 
            this.radioButton_num.AutoSize = true;
            this.radioButton_num.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_num.Location = new System.Drawing.Point(353, 151);
            this.radioButton_num.Name = "radioButton_num";
            this.radioButton_num.Size = new System.Drawing.Size(116, 19);
            this.radioButton_num.TabIndex = 18;
            this.radioButton_num.TabStop = true;
            this.radioButton_num.Text = "Numero Cheque";
            this.radioButton_num.UseVisualStyleBackColor = true;
            // 
            // F_Chiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.radioButton_num);
            this.Controls.Add(this.radioButton_sup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Textbox_searsh);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 580);
            this.Name = "F_Chiques";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "F_Chiques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Chiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_searsh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_sup;
        private System.Windows.Forms.RadioButton radioButton_num;
    }
}