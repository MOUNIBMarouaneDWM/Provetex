namespace Provetex.Auth
{
    partial class F_forgot_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_forgot_password));
            this.Card_check = new Bunifu.Framework.UI.BunifuCards();
            this.Button_confirme = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datepicker_favorit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Textbox_answer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Card_reset_pass = new Bunifu.Framework.UI.BunifuCards();
            this.Textbox_newPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_reset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Textbox_confirme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon_back = new System.Windows.Forms.PictureBox();
            this.Card_check.SuspendLayout();
            this.Card_reset_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).BeginInit();
            this.SuspendLayout();
            // 
            // Card_check
            // 
            this.Card_check.BackColor = System.Drawing.Color.Lavender;
            this.Card_check.BorderRadius = 5;
            this.Card_check.BottomSahddow = true;
            this.Card_check.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Card_check.Controls.Add(this.Button_confirme);
            this.Card_check.Controls.Add(this.label_question);
            this.Card_check.Controls.Add(this.label2);
            this.Card_check.Controls.Add(this.Datepicker_favorit);
            this.Card_check.Controls.Add(this.Textbox_answer);
            this.Card_check.LeftSahddow = false;
            this.Card_check.Location = new System.Drawing.Point(356, 61);
            this.Card_check.Name = "Card_check";
            this.Card_check.RightSahddow = true;
            this.Card_check.ShadowDepth = 20;
            this.Card_check.Size = new System.Drawing.Size(318, 265);
            this.Card_check.TabIndex = 16;
            // 
            // Button_confirme
            // 
            this.Button_confirme.ActiveBorderThickness = 1;
            this.Button_confirme.ActiveCornerRadius = 20;
            this.Button_confirme.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Button_confirme.ActiveForecolor = System.Drawing.Color.White;
            this.Button_confirme.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_confirme.BackColor = System.Drawing.Color.Lavender;
            this.Button_confirme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_confirme.BackgroundImage")));
            this.Button_confirme.ButtonText = "Confirmer";
            this.Button_confirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_confirme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_confirme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_confirme.IdleBorderThickness = 1;
            this.Button_confirme.IdleCornerRadius = 20;
            this.Button_confirme.IdleFillColor = System.Drawing.Color.White;
            this.Button_confirme.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Button_confirme.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_confirme.Location = new System.Drawing.Point(63, 201);
            this.Button_confirme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_confirme.Name = "Button_confirme";
            this.Button_confirme.Size = new System.Drawing.Size(166, 46);
            this.Button_confirme.TabIndex = 13;
            this.Button_confirme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_confirme.Click += new System.EventHandler(this.Button_confirme_Click);
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.label_question.Location = new System.Drawing.Point(60, 115);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(0, 17);
            this.label_question.TabIndex = 12;
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(60, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "YOUR FAVORIT DATE";
            // 
            // Datepicker_favorit
            // 
            this.Datepicker_favorit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Datepicker_favorit.BorderRadius = 0;
            this.Datepicker_favorit.ForeColor = System.Drawing.Color.White;
            this.Datepicker_favorit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datepicker_favorit.FormatCustom = null;
            this.Datepicker_favorit.Location = new System.Drawing.Point(63, 64);
            this.Datepicker_favorit.Name = "Datepicker_favorit";
            this.Datepicker_favorit.Size = new System.Drawing.Size(166, 33);
            this.Datepicker_favorit.TabIndex = 10;
            this.Datepicker_favorit.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // Textbox_answer
            // 
            this.Textbox_answer.BackColor = System.Drawing.Color.White;
            this.Textbox_answer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_answer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_answer.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_answer.HintText = "Votre Reponse";
            this.Textbox_answer.isPassword = false;
            this.Textbox_answer.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_answer.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_answer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_answer.LineThickness = 3;
            this.Textbox_answer.Location = new System.Drawing.Point(63, 150);
            this.Textbox_answer.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_answer.Name = "Textbox_answer";
            this.Textbox_answer.Size = new System.Drawing.Size(166, 33);
            this.Textbox_answer.TabIndex = 10;
            this.Textbox_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_answer_KeyPress);
            // 
            // Card_reset_pass
            // 
            this.Card_reset_pass.BackColor = System.Drawing.Color.Lavender;
            this.Card_reset_pass.BorderRadius = 5;
            this.Card_reset_pass.BottomSahddow = true;
            this.Card_reset_pass.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Card_reset_pass.Controls.Add(this.Textbox_newPass);
            this.Card_reset_pass.Controls.Add(this.Button_reset);
            this.Card_reset_pass.Controls.Add(this.Textbox_confirme);
            this.Card_reset_pass.Enabled = false;
            this.Card_reset_pass.LeftSahddow = false;
            this.Card_reset_pass.Location = new System.Drawing.Point(680, 61);
            this.Card_reset_pass.Name = "Card_reset_pass";
            this.Card_reset_pass.RightSahddow = true;
            this.Card_reset_pass.ShadowDepth = 20;
            this.Card_reset_pass.Size = new System.Drawing.Size(294, 265);
            this.Card_reset_pass.TabIndex = 18;
            this.Card_reset_pass.Visible = false;
            // 
            // Textbox_newPass
            // 
            this.Textbox_newPass.BackColor = System.Drawing.Color.White;
            this.Textbox_newPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_newPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_newPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_newPass.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_newPass.HintText = "nouveau mot de passe";
            this.Textbox_newPass.isPassword = false;
            this.Textbox_newPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_newPass.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_newPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_newPass.LineThickness = 3;
            this.Textbox_newPass.Location = new System.Drawing.Point(52, 64);
            this.Textbox_newPass.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_newPass.Name = "Textbox_newPass";
            this.Textbox_newPass.Size = new System.Drawing.Size(188, 33);
            this.Textbox_newPass.TabIndex = 14;
            this.Textbox_newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_newPass.OnValueChanged += new System.EventHandler(this.Textbox_newPass_OnValueChanged);
            // 
            // Button_reset
            // 
            this.Button_reset.ActiveBorderThickness = 1;
            this.Button_reset.ActiveCornerRadius = 20;
            this.Button_reset.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Button_reset.ActiveForecolor = System.Drawing.Color.White;
            this.Button_reset.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_reset.BackColor = System.Drawing.Color.Lavender;
            this.Button_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_reset.BackgroundImage")));
            this.Button_reset.ButtonText = "Réinitialiser";
            this.Button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_reset.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_reset.IdleBorderThickness = 1;
            this.Button_reset.IdleCornerRadius = 20;
            this.Button_reset.IdleFillColor = System.Drawing.Color.White;
            this.Button_reset.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Button_reset.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_reset.Location = new System.Drawing.Point(63, 200);
            this.Button_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_reset.Name = "Button_reset";
            this.Button_reset.Size = new System.Drawing.Size(166, 46);
            this.Button_reset.TabIndex = 13;
            this.Button_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // Textbox_confirme
            // 
            this.Textbox_confirme.BackColor = System.Drawing.Color.White;
            this.Textbox_confirme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_confirme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_confirme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_confirme.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_confirme.HintText = "Confirmer";
            this.Textbox_confirme.isPassword = false;
            this.Textbox_confirme.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_confirme.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_confirme.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_confirme.LineThickness = 3;
            this.Textbox_confirme.Location = new System.Drawing.Point(52, 132);
            this.Textbox_confirme.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_confirme.Name = "Textbox_confirme";
            this.Textbox_confirme.Size = new System.Drawing.Size(188, 33);
            this.Textbox_confirme.TabIndex = 10;
            this.Textbox_confirme.Text = "Confirme le mot de passe";
            this.Textbox_confirme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_confirme.OnValueChanged += new System.EventHandler(this.Textbox_confirme_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // icon_back
            // 
            this.icon_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_back.Image = ((System.Drawing.Image)(resources.GetObject("icon_back.Image")));
            this.icon_back.Location = new System.Drawing.Point(356, 12);
            this.icon_back.Name = "icon_back";
            this.icon_back.Size = new System.Drawing.Size(31, 31);
            this.icon_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_back.TabIndex = 19;
            this.icon_back.TabStop = false;
            this.icon_back.Click += new System.EventHandler(this.Icon_back_Click);
            // 
            // F_forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.Card_check);
            this.Controls.Add(this.Card_reset_pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icon_back);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_forgot_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_forgot_password";
            this.Load += new System.EventHandler(this.F_forgot_password_Load);
            this.Card_check.ResumeLayout(false);
            this.Card_check.PerformLayout();
            this.Card_reset_pass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards Card_check;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_confirme;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker_favorit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_answer;
        private Bunifu.Framework.UI.BunifuCards Card_reset_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_newPass;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_reset;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_confirme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icon_back;
    }
}