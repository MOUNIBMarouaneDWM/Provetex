namespace Provetex.Supplier
{
    partial class F_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Details));
            this.DataGrid_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delet = new System.Windows.Forms.DataGridViewImageColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbox_searsh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_titel = new System.Windows.Forms.Label();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.Button_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.Dropdown_list_article = new System.Windows.Forms.ComboBox();
            this.panel_choise = new System.Windows.Forms.Panel();
            this.radioButton_new = new System.Windows.Forms.RadioButton();
            this.radioButton_notNew = new System.Windows.Forms.RadioButton();
            this.Button_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Textbox_prix = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_artcle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.panel_form.SuspendLayout();
            this.panel_choise.SuspendLayout();
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
            this.delet,
            this.detail});
            this.DataGrid_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.DataGrid_list.Location = new System.Drawing.Point(16, 182);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(434, 388);
            this.DataGrid_list.TabIndex = 6;
            this.DataGrid_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_list_CellContentClick);
            // 
            // delet
            // 
            this.delet.HeaderText = "";
            this.delet.Image = ((System.Drawing.Image)(resources.GetObject("delet.Image")));
            this.delet.Name = "delet";
            this.delet.Width = 32;
            // 
            // detail
            // 
            this.detail.HeaderText = "";
            this.detail.Image = ((System.Drawing.Image)(resources.GetObject("detail.Image")));
            this.detail.Name = "detail";
            this.detail.Width = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.Textbox_searsh.Location = new System.Drawing.Point(16, 142);
            this.Textbox_searsh.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_searsh.Name = "Textbox_searsh";
            this.Textbox_searsh.Size = new System.Drawing.Size(194, 33);
            this.Textbox_searsh.TabIndex = 8;
            this.Textbox_searsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_searsh.OnValueChanged += new System.EventHandler(this.Textbox_searsh_OnValueChanged);
            // 
            // label_titel
            // 
            this.label_titel.AutoSize = true;
            this.label_titel.Font = new System.Drawing.Font("Sunshine", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titel.Location = new System.Drawing.Point(97, 7);
            this.label_titel.Name = "label_titel";
            this.label_titel.Size = new System.Drawing.Size(164, 43);
            this.label_titel.TabIndex = 7;
            this.label_titel.Text = "Fournisseurs";
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_back.Image")));
            this.pictureBox_back.Location = new System.Drawing.Point(16, 12);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(33, 33);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_back.TabIndex = 13;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // Button_add
            // 
            this.Button_add.Activecolor = System.Drawing.Color.Silver;
            this.Button_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_add.BorderRadius = 0;
            this.Button_add.ButtonText = "Ajouter un article";
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_add.DisabledColor = System.Drawing.Color.RoyalBlue;
            this.Button_add.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_add.Iconimage")));
            this.Button_add.Iconimage_right = null;
            this.Button_add.Iconimage_right_Selected = null;
            this.Button_add.Iconimage_Selected = null;
            this.Button_add.IconMarginLeft = 0;
            this.Button_add.IconMarginRight = 0;
            this.Button_add.IconRightVisible = true;
            this.Button_add.IconRightZoom = 0D;
            this.Button_add.IconVisible = true;
            this.Button_add.IconZoom = 50D;
            this.Button_add.IsTab = false;
            this.Button_add.Location = new System.Drawing.Point(525, 146);
            this.Button_add.Name = "Button_add";
            this.Button_add.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_add.selected = false;
            this.Button_add.Size = new System.Drawing.Size(194, 33);
            this.Button_add.TabIndex = 14;
            this.Button_add.Text = "Ajouter un article";
            this.Button_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_add.Textcolor = System.Drawing.Color.White;
            this.Button_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_form.Controls.Add(this.Dropdown_list_article);
            this.panel_form.Controls.Add(this.panel_choise);
            this.panel_form.Controls.Add(this.Button_back);
            this.panel_form.Controls.Add(this.Button_save);
            this.panel_form.Controls.Add(this.Textbox_prix);
            this.panel_form.Controls.Add(this.Textbox_artcle);
            this.panel_form.Location = new System.Drawing.Point(457, 182);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(331, 347);
            this.panel_form.TabIndex = 15;
            // 
            // Dropdown_list_article
            // 
            this.Dropdown_list_article.BackColor = System.Drawing.Color.RoyalBlue;
            this.Dropdown_list_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_list_article.FormattingEnabled = true;
            this.Dropdown_list_article.Location = new System.Drawing.Point(36, 72);
            this.Dropdown_list_article.Name = "Dropdown_list_article";
            this.Dropdown_list_article.Size = new System.Drawing.Size(259, 21);
            this.Dropdown_list_article.TabIndex = 16;
            // 
            // panel_choise
            // 
            this.panel_choise.Controls.Add(this.radioButton_new);
            this.panel_choise.Controls.Add(this.radioButton_notNew);
            this.panel_choise.Location = new System.Drawing.Point(36, 3);
            this.panel_choise.Name = "panel_choise";
            this.panel_choise.Size = new System.Drawing.Size(259, 38);
            this.panel_choise.TabIndex = 39;
            // 
            // radioButton_new
            // 
            this.radioButton_new.AutoSize = true;
            this.radioButton_new.Location = new System.Drawing.Point(3, 11);
            this.radioButton_new.Name = "radioButton_new";
            this.radioButton_new.Size = new System.Drawing.Size(83, 17);
            this.radioButton_new.TabIndex = 37;
            this.radioButton_new.TabStop = true;
            this.radioButton_new.Text = "New articles";
            this.radioButton_new.UseVisualStyleBackColor = true;
            this.radioButton_new.CheckedChanged += new System.EventHandler(this.radioButton_new_CheckedChanged);
            // 
            // radioButton_notNew
            // 
            this.radioButton_notNew.AutoSize = true;
            this.radioButton_notNew.Location = new System.Drawing.Point(146, 11);
            this.radioButton_notNew.Name = "radioButton_notNew";
            this.radioButton_notNew.Size = new System.Drawing.Size(110, 17);
            this.radioButton_notNew.TabIndex = 38;
            this.radioButton_notNew.TabStop = true;
            this.radioButton_notNew.Text = "Article alredy exict";
            this.radioButton_notNew.UseVisualStyleBackColor = true;
            this.radioButton_notNew.CheckedChanged += new System.EventHandler(this.radioButton_notNew_CheckedChanged);
            // 
            // Button_back
            // 
            this.Button_back.ActiveBorderThickness = 1;
            this.Button_back.ActiveCornerRadius = 20;
            this.Button_back.ActiveFillColor = System.Drawing.Color.Gray;
            this.Button_back.ActiveForecolor = System.Drawing.Color.White;
            this.Button_back.ActiveLineColor = System.Drawing.Color.Gray;
            this.Button_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_back.BackgroundImage")));
            this.Button_back.ButtonText = "Annuler";
            this.Button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_back.ForeColor = System.Drawing.Color.Gray;
            this.Button_back.IdleBorderThickness = 1;
            this.Button_back.IdleCornerRadius = 20;
            this.Button_back.IdleFillColor = System.Drawing.Color.White;
            this.Button_back.IdleForecolor = System.Drawing.Color.Gray;
            this.Button_back.IdleLineColor = System.Drawing.Color.Gray;
            this.Button_back.Location = new System.Drawing.Point(182, 254);
            this.Button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(113, 46);
            this.Button_back.TabIndex = 35;
            this.Button_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // Button_save
            // 
            this.Button_save.ActiveBorderThickness = 1;
            this.Button_save.ActiveCornerRadius = 20;
            this.Button_save.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.ActiveForecolor = System.Drawing.Color.White;
            this.Button_save.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_save.BackgroundImage")));
            this.Button_save.ButtonText = "Enregistrer";
            this.Button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.IdleBorderThickness = 1;
            this.Button_save.IdleCornerRadius = 20;
            this.Button_save.IdleFillColor = System.Drawing.Color.White;
            this.Button_save.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Button_save.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.Location = new System.Drawing.Point(36, 254);
            this.Button_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(113, 46);
            this.Button_save.TabIndex = 34;
            this.Button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // Textbox_prix
            // 
            this.Textbox_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_prix.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_prix.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_prix.HintText = "Prix";
            this.Textbox_prix.isPassword = false;
            this.Textbox_prix.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_prix.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_prix.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_prix.LineThickness = 3;
            this.Textbox_prix.Location = new System.Drawing.Point(36, 157);
            this.Textbox_prix.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_prix.Name = "Textbox_prix";
            this.Textbox_prix.Size = new System.Drawing.Size(181, 33);
            this.Textbox_prix.TabIndex = 33;
            this.Textbox_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox_artcle
            // 
            this.Textbox_artcle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_artcle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_artcle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_artcle.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_artcle.HintText = "Nom d\'article";
            this.Textbox_artcle.isPassword = false;
            this.Textbox_artcle.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_artcle.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_artcle.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_artcle.LineThickness = 3;
            this.Textbox_artcle.Location = new System.Drawing.Point(36, 100);
            this.Textbox_artcle.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_artcle.Name = "Textbox_artcle";
            this.Textbox_artcle.Size = new System.Drawing.Size(259, 33);
            this.Textbox_artcle.TabIndex = 32;
            this.Textbox_artcle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_artcle.Visible = false;
            // 
            // F_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_searsh);
            this.Controls.Add(this.label_titel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Details";
            this.Text = "F_Details";
            this.Load += new System.EventHandler(this.F_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel_choise.ResumeLayout(false);
            this.panel_choise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_searsh;
        private System.Windows.Forms.Label label_titel;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.DataGridViewImageColumn delet;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private Bunifu.Framework.UI.BunifuFlatButton Button_add;
        private System.Windows.Forms.Panel panel_form;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_back;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_save;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_prix;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_artcle;
        private System.Windows.Forms.RadioButton radioButton_notNew;
        private System.Windows.Forms.RadioButton radioButton_new;
        private System.Windows.Forms.Panel panel_choise;
        private System.Windows.Forms.ComboBox Dropdown_list_article;
    }
}