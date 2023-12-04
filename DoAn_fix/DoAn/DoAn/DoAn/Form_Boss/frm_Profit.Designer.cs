namespace DoAn.form
{
    partial class frm_Profit
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
            this.lbl_TenUser = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_DenNgay = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.lbl_TuNgay = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_ThongKe = new System.Windows.Forms.GroupBox();
            this.btn_CTHD = new System.Windows.Forms.Button();
            this.lbl_TongDoanhThu = new System.Windows.Forms.Label();
            this.txt_ChiPhi = new System.Windows.Forms.TextBox();
            this.lbl_ChiPhi = new System.Windows.Forms.Label();
            this.txt_LoiNhuan = new System.Windows.Forms.TextBox();
            this.lbl_LoiNhuan = new System.Windows.Forms.Label();
            this.txt_TongDoanhThu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grp_ThongKe.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TenUser
            // 
            this.lbl_TenUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_TenUser.Location = new System.Drawing.Point(89, 134);
            this.lbl_TenUser.Name = "lbl_TenUser";
            this.lbl_TenUser.Size = new System.Drawing.Size(201, 50);
            this.lbl_TenUser.TabIndex = 1;
            this.lbl_TenUser.Text = "Boss";
            this.lbl_TenUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.pictureBox2);
            this.panel_Info.Controls.Add(this.lbl_TenUser);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Info.Location = new System.Drawing.Point(3, 2);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(372, 212);
            this.panel_Info.TabIndex = 47;
            this.panel_Info.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Info_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(101, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(369, 153);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(279, 27);
            this.dateTimePickerEnd.TabIndex = 61;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(369, 66);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(279, 27);
            this.dateTimePickerStart.TabIndex = 60;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Back.Location = new System.Drawing.Point(944, 11);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(43, 43);
            this.btn_Back.TabIndex = 50;
            this.btn_Back.Text = "X";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_DenNgay
            // 
            this.lbl_DenNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DenNgay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_DenNgay.Location = new System.Drawing.Point(355, 110);
            this.lbl_DenNgay.Name = "lbl_DenNgay";
            this.lbl_DenNgay.Size = new System.Drawing.Size(283, 30);
            this.lbl_DenNgay.TabIndex = 59;
            this.lbl_DenNgay.Text = "Đến Ngày";
            this.lbl_DenNgay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Tinh.Location = new System.Drawing.Point(678, 66);
            this.btn_Tinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(121, 113);
            this.btn_Tinh.TabIndex = 57;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // lbl_TuNgay
            // 
            this.lbl_TuNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TuNgay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_TuNgay.Location = new System.Drawing.Point(359, 23);
            this.lbl_TuNgay.Name = "lbl_TuNgay";
            this.lbl_TuNgay.Size = new System.Drawing.Size(277, 30);
            this.lbl_TuNgay.TabIndex = 55;
            this.lbl_TuNgay.Text = "Từ Ngày";
            this.lbl_TuNgay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HoaDon.Location = new System.Drawing.Point(3, 222);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1393, 517);
            this.dgv_HoaDon.TabIndex = 48;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.19946F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.80054F));
            this.tableLayoutPanel2.Controls.Add(this.grp_ThongKe, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_Info, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1393, 216);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grp_ThongKe
            // 
            this.grp_ThongKe.Controls.Add(this.dateTimePickerEnd);
            this.grp_ThongKe.Controls.Add(this.dateTimePickerStart);
            this.grp_ThongKe.Controls.Add(this.btn_Back);
            this.grp_ThongKe.Controls.Add(this.lbl_DenNgay);
            this.grp_ThongKe.Controls.Add(this.btn_Tinh);
            this.grp_ThongKe.Controls.Add(this.lbl_TuNgay);
            this.grp_ThongKe.Controls.Add(this.btn_CTHD);
            this.grp_ThongKe.Controls.Add(this.lbl_TongDoanhThu);
            this.grp_ThongKe.Controls.Add(this.txt_ChiPhi);
            this.grp_ThongKe.Controls.Add(this.lbl_ChiPhi);
            this.grp_ThongKe.Controls.Add(this.txt_LoiNhuan);
            this.grp_ThongKe.Controls.Add(this.lbl_LoiNhuan);
            this.grp_ThongKe.Controls.Add(this.txt_TongDoanhThu);
            this.grp_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKe.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_ThongKe.Location = new System.Drawing.Point(381, 2);
            this.grp_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_ThongKe.Name = "grp_ThongKe";
            this.grp_ThongKe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_ThongKe.Size = new System.Drawing.Size(988, 212);
            this.grp_ThongKe.TabIndex = 49;
            this.grp_ThongKe.TabStop = false;
            this.grp_ThongKe.Text = "Thống Kê";
            // 
            // btn_CTHD
            // 
            this.btn_CTHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CTHD.Location = new System.Drawing.Point(836, 66);
            this.btn_CTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CTHD.Name = "btn_CTHD";
            this.btn_CTHD.Size = new System.Drawing.Size(121, 113);
            this.btn_CTHD.TabIndex = 47;
            this.btn_CTHD.Text = "Chi Tiết Hóa Đơn";
            this.btn_CTHD.UseVisualStyleBackColor = true;
            this.btn_CTHD.Click += new System.EventHandler(this.btn_CTHD_Click);
            // 
            // lbl_TongDoanhThu
            // 
            this.lbl_TongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongDoanhThu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_TongDoanhThu.Location = new System.Drawing.Point(11, 31);
            this.lbl_TongDoanhThu.Name = "lbl_TongDoanhThu";
            this.lbl_TongDoanhThu.Size = new System.Drawing.Size(299, 30);
            this.lbl_TongDoanhThu.TabIndex = 46;
            this.lbl_TongDoanhThu.Text = "Tổng Doanh Thu";
            this.lbl_TongDoanhThu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ChiPhi
            // 
            this.txt_ChiPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChiPhi.Location = new System.Drawing.Point(11, 179);
            this.txt_ChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ChiPhi.Name = "txt_ChiPhi";
            this.txt_ChiPhi.Size = new System.Drawing.Size(297, 24);
            this.txt_ChiPhi.TabIndex = 45;
            // 
            // lbl_ChiPhi
            // 
            this.lbl_ChiPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChiPhi.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ChiPhi.Location = new System.Drawing.Point(11, 152);
            this.lbl_ChiPhi.Name = "lbl_ChiPhi";
            this.lbl_ChiPhi.Size = new System.Drawing.Size(299, 30);
            this.lbl_ChiPhi.TabIndex = 44;
            this.lbl_ChiPhi.Text = "Chi Phí";
            this.lbl_ChiPhi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_LoiNhuan
            // 
            this.txt_LoiNhuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoiNhuan.Location = new System.Drawing.Point(11, 117);
            this.txt_LoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LoiNhuan.Name = "txt_LoiNhuan";
            this.txt_LoiNhuan.Size = new System.Drawing.Size(297, 24);
            this.txt_LoiNhuan.TabIndex = 43;
            // 
            // lbl_LoiNhuan
            // 
            this.lbl_LoiNhuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_LoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LoiNhuan.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_LoiNhuan.Location = new System.Drawing.Point(11, 89);
            this.lbl_LoiNhuan.Name = "lbl_LoiNhuan";
            this.lbl_LoiNhuan.Size = new System.Drawing.Size(299, 30);
            this.lbl_LoiNhuan.TabIndex = 42;
            this.lbl_LoiNhuan.Text = "Lợi Nhuận";
            this.lbl_LoiNhuan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_TongDoanhThu
            // 
            this.txt_TongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongDoanhThu.Location = new System.Drawing.Point(11, 57);
            this.txt_TongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongDoanhThu.Name = "txt_TongDoanhThu";
            this.txt_TongDoanhThu.Size = new System.Drawing.Size(297, 24);
            this.txt_TongDoanhThu.TabIndex = 41;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_HoaDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.76501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.23499F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1399, 741);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.tableLayoutPanel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1399, 741);
            this.panelChildForm.TabIndex = 9;
            // 
            // frm_Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 741);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Profit";
            this.Text = "frm_Report_Inventory";
            this.Load += new System.EventHandler(this.frm_Profit_Load);
            this.panel_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grp_ThongKe.ResumeLayout(false);
            this.grp_ThongKe.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenUser;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_DenNgay;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Label lbl_TuNgay;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grp_ThongKe;
        private System.Windows.Forms.Button btn_CTHD;
        private System.Windows.Forms.Label lbl_TongDoanhThu;
        private System.Windows.Forms.TextBox txt_ChiPhi;
        private System.Windows.Forms.Label lbl_ChiPhi;
        private System.Windows.Forms.TextBox txt_LoiNhuan;
        private System.Windows.Forms.Label lbl_LoiNhuan;
        private System.Windows.Forms.TextBox txt_TongDoanhThu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}