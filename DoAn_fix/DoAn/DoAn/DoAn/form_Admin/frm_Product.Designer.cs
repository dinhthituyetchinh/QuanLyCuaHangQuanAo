namespace DoAn.form
{
    partial class frm_Product
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
            this.lbl_LapHD = new System.Windows.Forms.Label();
            this.btn_Close_Child_Sales = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSP = new System.Windows.Forms.Button();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.lblTenMau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.cmbMau = new System.Windows.Forms.ComboBox();
            this.cmbChatLieu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LapHD
            // 
            this.lbl_LapHD.AutoSize = true;
            this.lbl_LapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LapHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl_LapHD.Location = new System.Drawing.Point(3, 9);
            this.lbl_LapHD.Name = "lbl_LapHD";
            this.lbl_LapHD.Size = new System.Drawing.Size(263, 29);
            this.lbl_LapHD.TabIndex = 30;
            this.lbl_LapHD.Text = "Danh Sách Sản Phẩm";
            this.lbl_LapHD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Close_Child_Sales
            // 
            this.btn_Close_Child_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close_Child_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Close_Child_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Close_Child_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Child_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Child_Sales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Close_Child_Sales.Location = new System.Drawing.Point(962, 11);
            this.btn_Close_Child_Sales.Name = "btn_Close_Child_Sales";
            this.btn_Close_Child_Sales.Size = new System.Drawing.Size(26, 35);
            this.btn_Close_Child_Sales.TabIndex = 36;
            this.btn_Close_Child_Sales.Text = "X";
            this.btn_Close_Child_Sales.UseVisualStyleBackColor = true;
            this.btn_Close_Child_Sales.Click += new System.EventHandler(this.btn_Close_Child_Sales_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSP.Location = new System.Drawing.Point(893, 66);
            this.btnAddSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(95, 31);
            this.btnAddSP.TabIndex = 22;
            this.btnAddSP.Text = "Thêm sản phẩm";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(98, 160);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(168, 20);
            this.txtTenSP.TabIndex = 23;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(98, 84);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(168, 20);
            this.txtMaSP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btnEditSP
            // 
            this.btnEditSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSP.Location = new System.Drawing.Point(893, 141);
            this.btnEditSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSP.Name = "btnEditSP";
            this.btnEditSP.Size = new System.Drawing.Size(95, 31);
            this.btnEditSP.TabIndex = 25;
            this.btnEditSP.Text = "Sửa sản phẩm";
            this.btnEditSP.UseVisualStyleBackColor = true;
            this.btnEditSP.Click += new System.EventHandler(this.btnEditSP_Click);
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(0, 233);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSP.Size = new System.Drawing.Size(1013, 313);
            this.dgvDSSP.TabIndex = 37;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            this.dgvDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellContentClick);
            // 
            // lblTenMau
            // 
            this.lblTenMau.AutoSize = true;
            this.lblTenMau.ForeColor = System.Drawing.Color.White;
            this.lblTenMau.Location = new System.Drawing.Point(295, 87);
            this.lblTenMau.Name = "lblTenMau";
            this.lblTenMau.Size = new System.Drawing.Size(49, 13);
            this.lblTenMau.TabIndex = 38;
            this.lblTenMau.Text = "Tên màu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Loại chất liệu";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(801, 81);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 79);
            this.btnTim.TabIndex = 42;
            this.btnTim.Text = "Tìm sản phẩm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSP.Location = new System.Drawing.Point(893, 101);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(95, 31);
            this.btnXoaSP.TabIndex = 43;
            this.btnXoaSP.Text = "Xoá sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // cmbMau
            // 
            this.cmbMau.FormattingEnabled = true;
            this.cmbMau.Location = new System.Drawing.Point(414, 81);
            this.cmbMau.Name = "cmbMau";
            this.cmbMau.Size = new System.Drawing.Size(169, 21);
            this.cmbMau.TabIndex = 44;
            this.cmbMau.SelectedIndexChanged += new System.EventHandler(this.cmbMau_SelectedIndexChanged);
            // 
            // cmbChatLieu
            // 
            this.cmbChatLieu.FormattingEnabled = true;
            this.cmbChatLieu.Location = new System.Drawing.Point(414, 160);
            this.cmbChatLieu.Name = "cmbChatLieu";
            this.cmbChatLieu.Size = new System.Drawing.Size(169, 21);
            this.cmbChatLieu.TabIndex = 45;
            this.cmbChatLieu.SelectedIndexChanged += new System.EventHandler(this.cmbChatLieu_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(612, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbChatLieu);
            this.Controls.Add(this.cmbMau);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenMau);
            this.Controls.Add(this.dgvDSSP);
            this.Controls.Add(this.btnAddSP);
            this.Controls.Add(this.btnEditSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close_Child_Sales);
            this.Controls.Add(this.lbl_LapHD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Product";
            this.Text = "frm_Product";
            this.Load += new System.EventHandler(this.frm_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_LapHD;
        private System.Windows.Forms.Button btn_Close_Child_Sales;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSP;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label lblTenMau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.ComboBox cmbMau;
        private System.Windows.Forms.ComboBox cmbChatLieu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}