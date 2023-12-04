namespace DoAn
{
    partial class frm_sales
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
            this.btn_LapHoaDon = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.bth_ThemSP = new System.Windows.Forms.Button();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txt_SdtKH = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_SP = new System.Windows.Forms.GroupBox();
            this.dgv_LapHoaDon = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_KH = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_LapHD = new System.Windows.Forms.Label();
            this.btn_Close_Child_Sales = new System.Windows.Forms.Button();
            this.tableLayoutPanel6.SuspendLayout();
            this.grp_SP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LapHoaDon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grp_KH.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LapHoaDon.Location = new System.Drawing.Point(3, 2);
            this.btn_LapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.Size = new System.Drawing.Size(247, 62);
            this.btn_LapHoaDon.TabIndex = 13;
            this.btn_LapHoaDon.Text = "Lập Hóa Đơn";
            this.btn_LapHoaDon.UseVisualStyleBackColor = true;
            this.btn_LapHoaDon.Click += new System.EventHandler(this.btn_LapHoaDon_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(277, 137);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(351, 22);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Location = new System.Drawing.Point(277, 87);
            this.txt_HoTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(351, 22);
            this.txt_HoTenKH.TabIndex = 13;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSDT.Location = new System.Drawing.Point(107, 39);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 20);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiaChi.Location = new System.Drawing.Point(107, 138);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTenKH.Location = new System.Drawing.Point(107, 89);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(134, 20);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(244, 137);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(351, 22);
            this.txt_SoLuong.TabIndex = 23;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoLuong.Location = new System.Drawing.Point(71, 138);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(74, 20);
            this.lblSoLuong.TabIndex = 22;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaSP.Location = new System.Drawing.Point(461, 182);
            this.btn_XoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(139, 60);
            this.btn_XoaSP.TabIndex = 21;
            this.btn_XoaSP.Text = "Xóa";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // bth_ThemSP
            // 
            this.bth_ThemSP.ForeColor = System.Drawing.Color.Black;
            this.bth_ThemSP.Location = new System.Drawing.Point(244, 182);
            this.bth_ThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bth_ThemSP.Name = "bth_ThemSP";
            this.bth_ThemSP.Size = new System.Drawing.Size(139, 60);
            this.bth_ThemSP.TabIndex = 20;
            this.bth_ThemSP.Text = "Thêm";
            this.bth_ThemSP.UseVisualStyleBackColor = true;
            this.bth_ThemSP.Click += new System.EventHandler(this.bth_ThemSP_Click);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(244, 39);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(351, 22);
            this.txt_MaSP.TabIndex = 16;
            this.txt_MaSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSP_KeyDown);
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(244, 89);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(351, 22);
            this.txt_TenSP.TabIndex = 13;
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemKH.Location = new System.Drawing.Point(493, 182);
            this.btn_ThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(139, 60);
            this.btn_ThemKH.TabIndex = 20;
            this.btn_ThemKH.Text = "Thêm KH";
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.ForeColor = System.Drawing.Color.Black;
            this.btnTimKH.Location = new System.Drawing.Point(277, 182);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(139, 60);
            this.btnTimKH.TabIndex = 19;
            this.btnTimKH.Text = "Tìm KH";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txt_SdtKH
            // 
            this.txt_SdtKH.Location = new System.Drawing.Point(277, 38);
            this.txt_SdtKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SdtKH.Name = "txt_SdtKH";
            this.txt_SdtKH.Size = new System.Drawing.Size(351, 22);
            this.txt_SdtKH.TabIndex = 18;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaSP.Location = new System.Drawing.Point(71, 39);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(114, 20);
            this.lblMaSP.TabIndex = 13;
            this.lblMaSP.Text = "Mã Sản Phẩm";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTenSP.Location = new System.Drawing.Point(71, 89);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(119, 20);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.btn_LapHoaDon, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1115, 602);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(253, 66);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // grp_SP
            // 
            this.grp_SP.Controls.Add(this.txt_SoLuong);
            this.grp_SP.Controls.Add(this.lblSoLuong);
            this.grp_SP.Controls.Add(this.btn_XoaSP);
            this.grp_SP.Controls.Add(this.bth_ThemSP);
            this.grp_SP.Controls.Add(this.txt_MaSP);
            this.grp_SP.Controls.Add(this.txt_TenSP);
            this.grp_SP.Controls.Add(this.lblMaSP);
            this.grp_SP.Controls.Add(this.lblTenSP);
            this.grp_SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_SP.ForeColor = System.Drawing.Color.White;
            this.grp_SP.Location = new System.Drawing.Point(686, 2);
            this.grp_SP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_SP.Name = "grp_SP";
            this.grp_SP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_SP.Size = new System.Drawing.Size(676, 263);
            this.grp_SP.TabIndex = 4;
            this.grp_SP.TabStop = false;
            this.grp_SP.Text = "Sản phẩm";
            // 
            // dgv_LapHoaDon
            // 
            this.dgv_LapHoaDon.AllowUserToOrderColumns = true;
            this.dgv_LapHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LapHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LapHoaDon.Location = new System.Drawing.Point(3, 279);
            this.dgv_LapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LapHoaDon.Name = "dgv_LapHoaDon";
            this.dgv_LapHoaDon.RowHeadersWidth = 51;
            this.dgv_LapHoaDon.RowTemplate.Height = 24;
            this.dgv_LapHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LapHoaDon.Size = new System.Drawing.Size(1365, 319);
            this.dgv_LapHoaDon.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03928F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.96072F));
            this.tableLayoutPanel2.Controls.Add(this.grp_SP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grp_KH, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1365, 267);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // grp_KH
            // 
            this.grp_KH.Controls.Add(this.btn_ThemKH);
            this.grp_KH.Controls.Add(this.btnTimKH);
            this.grp_KH.Controls.Add(this.txt_SdtKH);
            this.grp_KH.Controls.Add(this.txt_DiaChi);
            this.grp_KH.Controls.Add(this.txt_HoTenKH);
            this.grp_KH.Controls.Add(this.lblSDT);
            this.grp_KH.Controls.Add(this.lblDiaChi);
            this.grp_KH.Controls.Add(this.lblTenKH);
            this.grp_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_KH.ForeColor = System.Drawing.Color.White;
            this.grp_KH.Location = new System.Drawing.Point(3, 2);
            this.grp_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_KH.Name = "grp_KH";
            this.grp_KH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_KH.Size = new System.Drawing.Size(677, 263);
            this.grp_KH.TabIndex = 3;
            this.grp_KH.TabStop = false;
            this.grp_KH.Text = "Khác hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_LapHoaDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.18518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.96296F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 675);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // lbl_LapHD
            // 
            this.lbl_LapHD.AutoSize = true;
            this.lbl_LapHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_LapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LapHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_LapHD.Location = new System.Drawing.Point(0, 0);
            this.lbl_LapHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LapHD.Name = "lbl_LapHD";
            this.lbl_LapHD.Size = new System.Drawing.Size(201, 36);
            this.lbl_LapHD.TabIndex = 41;
            this.lbl_LapHD.Text = "Lập Hóa Đơn";
            // 
            // btn_Close_Child_Sales
            // 
            this.btn_Close_Child_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close_Child_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Close_Child_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Close_Child_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Child_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Child_Sales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Close_Child_Sales.Location = new System.Drawing.Point(1415, 0);
            this.btn_Close_Child_Sales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Child_Sales.Name = "btn_Close_Child_Sales";
            this.btn_Close_Child_Sales.Size = new System.Drawing.Size(35, 43);
            this.btn_Close_Child_Sales.TabIndex = 42;
            this.btn_Close_Child_Sales.Text = "X";
            this.btn_Close_Child_Sales.UseVisualStyleBackColor = true;
            // 
            // frm_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1371, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_LapHD);
            this.Controls.Add(this.btn_Close_Child_Sales);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_sales";
            this.Text = "frm_sales";
            this.Load += new System.EventHandler(this.frm_sales_Load);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.grp_SP.ResumeLayout(false);
            this.grp_SP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LapHoaDon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grp_KH.ResumeLayout(false);
            this.grp_KH.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LapHoaDon;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.Button bth_ThemSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txt_SdtKH;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox grp_SP;
        private System.Windows.Forms.DataGridView dgv_LapHoaDon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grp_KH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_LapHD;
        private System.Windows.Forms.Button btn_Close_Child_Sales;
    }
}