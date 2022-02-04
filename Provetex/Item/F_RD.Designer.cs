namespace Provetex.Item
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
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.shop = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btn_refresh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbox_searsh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_info_supItem = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_unity = new System.Windows.Forms.Label();
            this.label_articl = new System.Windows.Forms.Label();
            this.label_sup = new System.Windows.Forms.Label();
            this.comboBox_sup = new System.Windows.Forms.ComboBox();
            this.comboBox_unite = new Bunifu.Framework.UI.BunifuDropdown();
            this.Dropdown_list_article = new System.Windows.Forms.ComboBox();
            this.panel_choise = new System.Windows.Forms.Panel();
            this.radioButton_new = new System.Windows.Forms.RadioButton();
            this.radioButton_notNew = new System.Windows.Forms.RadioButton();
            this.Button_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Textbox_prix = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_artcle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_form.SuspendLayout();
            this.panel_info_supItem.SuspendLayout();
            this.panel_choise.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DataGrid_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.update,
            this.shop});
            this.DataGrid_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.DataGrid_list.Location = new System.Drawing.Point(16, 182);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(438, 388);
            this.DataGrid_list.TabIndex = 6;
            this.DataGrid_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_list_CellContentClick);
            // 
            // delete
            // 
            this.delete.FillWeight = 48.73096F;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // update
            // 
            this.update.FillWeight = 53.28913F;
            this.update.HeaderText = "";
            this.update.Image = global::Provetex.Properties.Resources.icons8_view_details_16;
            this.update.Name = "update";
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // shop
            // 
            this.shop.FillWeight = 197.9799F;
            this.shop.HeaderText = "";
            this.shop.Image = global::Provetex.Properties.Resources.icons8_shopping_cart_16;
            this.shop.Name = "shop";
            // 
            // Btn_refresh
            // 
            this.Btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refresh.Image")));
            this.Btn_refresh.Location = new System.Drawing.Point(421, 142);
            this.Btn_refresh.Name = "Btn_refresh";
            this.Btn_refresh.Size = new System.Drawing.Size(33, 33);
            this.Btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_refresh.TabIndex = 11;
            this.Btn_refresh.TabStop = false;
            this.Btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 146);
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
            this.Textbox_searsh.Location = new System.Drawing.Point(203, 142);
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
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Articels";
            // 
            // Button_add
            // 
            this.Button_add.Activecolor = System.Drawing.Color.Silver;
            this.Button_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_add.BorderRadius = 0;
            this.Button_add.ButtonText = "Ajouter un article ";
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
            this.Button_add.Location = new System.Drawing.Point(16, 142);
            this.Button_add.Name = "Button_add";
            this.Button_add.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_add.selected = false;
            this.Button_add.Size = new System.Drawing.Size(168, 33);
            this.Button_add.TabIndex = 12;
            this.Button_add.Text = "Ajouter un article ";
            this.Button_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_add.Textcolor = System.Drawing.Color.White;
            this.Button_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_form.Controls.Add(this.panel_info_supItem);
            this.panel_form.Controls.Add(this.comboBox_sup);
            this.panel_form.Controls.Add(this.comboBox_unite);
            this.panel_form.Controls.Add(this.Dropdown_list_article);
            this.panel_form.Controls.Add(this.panel_choise);
            this.panel_form.Controls.Add(this.Button_back);
            this.panel_form.Controls.Add(this.Button_save);
            this.panel_form.Controls.Add(this.Textbox_prix);
            this.panel_form.Controls.Add(this.Textbox_artcle);
            this.panel_form.Location = new System.Drawing.Point(460, 142);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(331, 426);
            this.panel_form.TabIndex = 16;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_form_Paint);
            // 
            // panel_info_supItem
            // 
            this.panel_info_supItem.Controls.Add(this.label2);
            this.panel_info_supItem.Controls.Add(this.label3);
            this.panel_info_supItem.Controls.Add(this.label4);
            this.panel_info_supItem.Controls.Add(this.label_unity);
            this.panel_info_supItem.Controls.Add(this.label_articl);
            this.panel_info_supItem.Controls.Add(this.label_sup);
            this.panel_info_supItem.Location = new System.Drawing.Point(3, 138);
            this.panel_info_supItem.Name = "panel_info_supItem";
            this.panel_info_supItem.Size = new System.Drawing.Size(325, 122);
            this.panel_info_supItem.TabIndex = 17;
            this.panel_info_supItem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Article";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fournisseur";
            // 
            // label_unity
            // 
            this.label_unity.AutoSize = true;
            this.label_unity.Location = new System.Drawing.Point(256, 80);
            this.label_unity.Name = "label_unity";
            this.label_unity.Size = new System.Drawing.Size(35, 13);
            this.label_unity.TabIndex = 2;
            this.label_unity.Text = "label4";
            // 
            // label_articl
            // 
            this.label_articl.AutoSize = true;
            this.label_articl.Location = new System.Drawing.Point(138, 80);
            this.label_articl.Name = "label_articl";
            this.label_articl.Size = new System.Drawing.Size(35, 13);
            this.label_articl.TabIndex = 1;
            this.label_articl.Text = "label3";
            // 
            // label_sup
            // 
            this.label_sup.AutoSize = true;
            this.label_sup.Location = new System.Drawing.Point(13, 80);
            this.label_sup.Name = "label_sup";
            this.label_sup.Size = new System.Drawing.Size(35, 13);
            this.label_sup.TabIndex = 0;
            this.label_sup.Text = "label2";
            // 
            // comboBox_sup
            // 
            this.comboBox_sup.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_sup.FormattingEnabled = true;
            this.comboBox_sup.Location = new System.Drawing.Point(33, 36);
            this.comboBox_sup.Name = "comboBox_sup";
            this.comboBox_sup.Size = new System.Drawing.Size(259, 21);
            this.comboBox_sup.TabIndex = 40;
            // 
            // comboBox_unite
            // 
            this.comboBox_unite.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_unite.BorderRadius = 3;
            this.comboBox_unite.DisabledColor = System.Drawing.Color.Gray;
            this.comboBox_unite.ForeColor = System.Drawing.Color.White;
            this.comboBox_unite.Items = new string[] {
        "Kg",
        "M^2",
        "Unity"};
            this.comboBox_unite.Location = new System.Drawing.Point(224, 174);
            this.comboBox_unite.Name = "comboBox_unite";
            this.comboBox_unite.NomalColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_unite.onHoverColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_unite.selectedIndex = 0;
            this.comboBox_unite.Size = new System.Drawing.Size(68, 21);
            this.comboBox_unite.TabIndex = 17;
            // 
            // Dropdown_list_article
            // 
            this.Dropdown_list_article.BackColor = System.Drawing.Color.RoyalBlue;
            this.Dropdown_list_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_list_article.FormattingEnabled = true;
            this.Dropdown_list_article.Location = new System.Drawing.Point(33, 174);
            this.Dropdown_list_article.Name = "Dropdown_list_article";
            this.Dropdown_list_article.Size = new System.Drawing.Size(184, 21);
            this.Dropdown_list_article.TabIndex = 16;
            // 
            // panel_choise
            // 
            this.panel_choise.Controls.Add(this.radioButton_new);
            this.panel_choise.Controls.Add(this.radioButton_notNew);
            this.panel_choise.Location = new System.Drawing.Point(33, 94);
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
            this.radioButton_notNew.Location = new System.Drawing.Point(145, 11);
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
            this.Button_back.Location = new System.Drawing.Point(179, 337);
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
            this.Button_save.Location = new System.Drawing.Point(33, 337);
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
            this.Textbox_prix.Location = new System.Drawing.Point(36, 261);
            this.Textbox_prix.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_prix.Name = "Textbox_prix";
            this.Textbox_prix.Size = new System.Drawing.Size(181, 33);
            this.Textbox_prix.TabIndex = 33;
            this.Textbox_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_prix.OnValueChanged += new System.EventHandler(this.Textbox_prix_OnValueChanged);
            this.Textbox_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_prix_KeyPress);
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
            this.Textbox_artcle.Location = new System.Drawing.Point(33, 168);
            this.Textbox_artcle.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_artcle.Name = "Textbox_artcle";
            this.Textbox_artcle.Size = new System.Drawing.Size(184, 33);
            this.Textbox_artcle.TabIndex = 32;
            this.Textbox_artcle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_artcle.Visible = false;
            this.Textbox_artcle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_artcle_KeyPress);
            // 
            // F_RD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.Btn_refresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_searsh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_RD";
            this.Text = "F_RD";
            this.Load += new System.EventHandler(this.F_RD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel_info_supItem.ResumeLayout(false);
            this.panel_info_supItem.PerformLayout();
            this.panel_choise.ResumeLayout(false);
            this.panel_choise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private System.Windows.Forms.PictureBox Btn_refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_searsh;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton Button_add;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.ComboBox Dropdown_list_article;
        private System.Windows.Forms.Panel panel_choise;
        private System.Windows.Forms.RadioButton radioButton_new;
        private System.Windows.Forms.RadioButton radioButton_notNew;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_back;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_save;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_prix;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_artcle;
        private System.Windows.Forms.ComboBox comboBox_sup;
        private Bunifu.Framework.UI.BunifuDropdown comboBox_unite;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn shop;
        private System.Windows.Forms.Panel panel_info_supItem;
        private System.Windows.Forms.Label label_unity;
        private System.Windows.Forms.Label label_articl;
        private System.Windows.Forms.Label label_sup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}