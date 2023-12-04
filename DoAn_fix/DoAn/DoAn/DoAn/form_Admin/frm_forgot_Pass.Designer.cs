namespace DoAn
{
    partial class frm_forgot_Pass
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNV_id = new System.Windows.Forms.Label();
            this.btn_Login = new CustomControls.RJControls.buttonCustom();
            this.linklbl_Back_Login = new System.Windows.Forms.LinkLabel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThoat = new System.Windows.Forms.LinkLabel();
            this.Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_panel.BackColor = System.Drawing.Color.Silver;
            this.Login_panel.Controls.Add(this.lblThoat);
            this.Login_panel.Controls.Add(this.label1);
            this.Login_panel.Controls.Add(this.lblNV_id);
            this.Login_panel.Controls.Add(this.btn_Login);
            this.Login_panel.Controls.Add(this.linklbl_Back_Login);
            this.Login_panel.Controls.Add(this.lbl_Password);
            this.Login_panel.Controls.Add(this.txt_sdt);
            this.Login_panel.Controls.Add(this.txt_UserName);
            this.Login_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Login_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_panel.Location = new System.Drawing.Point(9, 10);
            this.Login_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(496, 511);
            this.Login_panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 132);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quên Mật Khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNV_id
            // 
            this.lblNV_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNV_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNV_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNV_id.Location = new System.Drawing.Point(104, 149);
            this.lblNV_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNV_id.Name = "lblNV_id";
            this.lblNV_id.Size = new System.Drawing.Size(284, 42);
            this.lblNV_id.TabIndex = 10;
            this.lblNV_id.Text = "Mã Nhân Viên";
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
            this.btn_Login.Location = new System.Drawing.Point(107, 377);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(280, 52);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Gửi";
            this.btn_Login.TextColor = System.Drawing.SystemColors.Control;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linklbl_Back_Login
            // 
            this.linklbl_Back_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linklbl_Back_Login.AutoSize = true;
            this.linklbl_Back_Login.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_Back_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linklbl_Back_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linklbl_Back_Login.LinkColor = System.Drawing.SystemColors.Desktop;
            this.linklbl_Back_Login.Location = new System.Drawing.Point(40, 469);
            this.linklbl_Back_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklbl_Back_Login.Name = "linklbl_Back_Login";
            this.linklbl_Back_Login.Size = new System.Drawing.Size(141, 17);
            this.linklbl_Back_Login.TabIndex = 7;
            this.linklbl_Back_Login.TabStop = true;
            this.linklbl_Back_Login.Text = "Quay Lại Đăng Nhập";
            this.linklbl_Back_Login.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklbl_Back_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_Back_Login_LinkClicked);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Password.Location = new System.Drawing.Point(104, 262);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(284, 42);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Số Điện Thoại";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sdt.Location = new System.Drawing.Point(43, 318);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(408, 38);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.Location = new System.Drawing.Point(43, 204);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(408, 38);
            this.txt_UserName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DoAn.Properties.Resources.forgot_pass;
            this.pictureBox1.Location = new System.Drawing.Point(509, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblThoat
            // 
            this.lblThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Transparent;
            this.lblThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblThoat.LinkColor = System.Drawing.SystemColors.Desktop;
            this.lblThoat.Location = new System.Drawing.Point(367, 469);
            this.lblThoat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(45, 17);
            this.lblThoat.TabIndex = 12;
            this.lblThoat.TabStop = true;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblThoat_LinkClicked);
            // 
            // frm_forgot_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 531);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_forgot_Pass";
            this.Text = "Quên Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_forgot_Pass_FormClosing);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Label lblNV_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.buttonCustom btn_Login;
        private System.Windows.Forms.LinkLabel linklbl_Back_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblThoat;
    }
}