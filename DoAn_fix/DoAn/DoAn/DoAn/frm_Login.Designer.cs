namespace DoAn
{
    partial class frm_Login
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
            this.Login_panel = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.linklbl_Exit = new System.Windows.Forms.LinkLabel();
            this.lblNV_id = new System.Windows.Forms.Label();
            this.btn_Login = new CustomControls.RJControls.buttonCustom();
            this.linklbl_Forgot = new System.Windows.Forms.LinkLabel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_panel.BackColor = System.Drawing.Color.Silver;
            this.Login_panel.Controls.Add(this.lbl_Login);
            this.Login_panel.Controls.Add(this.linklbl_Exit);
            this.Login_panel.Controls.Add(this.lblNV_id);
            this.Login_panel.Controls.Add(this.btn_Login);
            this.Login_panel.Controls.Add(this.linklbl_Forgot);
            this.Login_panel.Controls.Add(this.lbl_Password);
            this.Login_panel.Controls.Add(this.txt_Pass);
            this.Login_panel.Controls.Add(this.txt_UserName);
            this.Login_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Login_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_panel.Location = new System.Drawing.Point(12, 12);
            this.Login_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(644, 629);
            this.Login_panel.TabIndex = 0;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Login.Location = new System.Drawing.Point(3, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(635, 162);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "Đăng Nhập";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklbl_Exit
            // 
            this.linklbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linklbl_Exit.AutoSize = true;
            this.linklbl_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linklbl_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linklbl_Exit.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linklbl_Exit.Location = new System.Drawing.Point(53, 588);
            this.linklbl_Exit.Name = "linklbl_Exit";
            this.linklbl_Exit.Size = new System.Drawing.Size(51, 20);
            this.linklbl_Exit.TabIndex = 11;
            this.linklbl_Exit.TabStop = true;
            this.linklbl_Exit.Text = "Thoát";
            this.linklbl_Exit.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklbl_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Exit_LinkClicked);
            // 
            // lblNV_id
            // 
            this.lblNV_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNV_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNV_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNV_id.Location = new System.Drawing.Point(141, 176);
            this.lblNV_id.Name = "lblNV_id";
            this.lblNV_id.Size = new System.Drawing.Size(361, 51);
            this.lblNV_id.TabIndex = 10;
            this.lblNV_id.Text = "UserName";
            this.lblNV_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_Login.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Login.BorderRadius = 15;
            this.btn_Login.BorderSize = 2;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Login.Location = new System.Drawing.Point(147, 489);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(356, 64);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.TextColor = System.Drawing.SystemColors.Control;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linklbl_Forgot
            // 
            this.linklbl_Forgot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linklbl_Forgot.AutoSize = true;
            this.linklbl_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linklbl_Forgot.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linklbl_Forgot.Location = new System.Drawing.Point(448, 588);
            this.linklbl_Forgot.Name = "linklbl_Forgot";
            this.linklbl_Forgot.Size = new System.Drawing.Size(134, 20);
            this.linklbl_Forgot.TabIndex = 7;
            this.linklbl_Forgot.TabStop = true;
            this.linklbl_Forgot.Text = "Quên Mật Khẩu?";
            this.linklbl_Forgot.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklbl_Forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Forgot_LinkClicked);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Password.Location = new System.Drawing.Point(141, 334);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(361, 51);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật Khẩu";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pass.Location = new System.Drawing.Point(57, 402);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(525, 46);
            this.txt_Pass.TabIndex = 1;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.Location = new System.Drawing.Point(57, 250);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(525, 46);
            this.txt_UserName.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAn.Properties.Resources.clothes_shop;
            this.pictureBox2.Location = new System.Drawing.Point(661, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(608, 629);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1283, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Login_FormClosing);
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.LinkLabel linklbl_Forgot;
        private CustomControls.RJControls.buttonCustom btn_Login;
        private System.Windows.Forms.Label lblNV_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linklbl_Exit;
        private System.Windows.Forms.Label lbl_Login;
    }
}

