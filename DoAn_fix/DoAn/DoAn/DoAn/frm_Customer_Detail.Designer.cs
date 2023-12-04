namespace DoAn.form_Admin
{
    partial class frm_Customer_Detail
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
            this.tblLayout_Cus = new System.Windows.Forms.TableLayoutPanel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnAdd_Customer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btn_Close_Child_Sales = new System.Windows.Forms.Button();
            this.tblLayout_Cus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_LapHD.Size = new System.Drawing.Size(354, 36);
            this.lbl_LapHD.TabIndex = 34;
            this.lbl_LapHD.Text = "Danh Sách Khách Hàng";
            // 
            // tblLayout_Cus
            // 
            this.tblLayout_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_Cus.ColumnCount = 5;
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.38912F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.61088F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tblLayout_Cus.Controls.Add(this.txtSDT, 3, 0);
            this.tblLayout_Cus.Controls.Add(this.label1, 0, 0);
            this.tblLayout_Cus.Controls.Add(this.label2, 0, 1);
            this.tblLayout_Cus.Controls.Add(this.label3, 2, 0);
            this.tblLayout_Cus.Controls.Add(this.txtName, 1, 0);
            this.tblLayout_Cus.Controls.Add(this.txtAddress, 1, 1);
            this.tblLayout_Cus.Controls.Add(this.btnTim, 6, 0);
            this.tblLayout_Cus.Controls.Add(this.btnAdd_Customer, 6, 1);
            this.tblLayout_Cus.Location = new System.Drawing.Point(21, 62);
            this.tblLayout_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayout_Cus.Name = "tblLayout_Cus";
            this.tblLayout_Cus.RowCount = 2;
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout_Cus.Size = new System.Drawing.Size(1272, 89);
            this.tblLayout_Cus.TabIndex = 33;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(635, 2);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(389, 22);
            this.txtSDT.TabIndex = 10;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(542, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(75, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(461, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(75, 46);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(461, 22);
            this.txtAddress.TabIndex = 23;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(1030, 2);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(239, 38);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnAdd_Customer
            // 
            this.btnAdd_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd_Customer.Location = new System.Drawing.Point(1030, 46);
            this.btnAdd_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_Customer.Name = "btnAdd_Customer";
            this.btnAdd_Customer.Size = new System.Drawing.Size(239, 38);
            this.btnAdd_Customer.TabIndex = 22;
            this.btnAdd_Customer.Text = "Thêm Khách Hàng";
            this.btnAdd_Customer.UseVisualStyleBackColor = true;
            this.btnAdd_Customer.Click += new System.EventHandler(this.btnAdd_Customer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 155);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 481);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 2);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(1275, 477);
            this.dgvCustomer.TabIndex = 2;
            // 
            // btn_Close_Child_Sales
            // 
            this.btn_Close_Child_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close_Child_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Close_Child_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Close_Child_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Child_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Child_Sales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Close_Child_Sales.Location = new System.Drawing.Point(1257, 11);
            this.btn_Close_Child_Sales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Child_Sales.Name = "btn_Close_Child_Sales";
            this.btn_Close_Child_Sales.Size = new System.Drawing.Size(35, 43);
            this.btn_Close_Child_Sales.TabIndex = 35;
            this.btn_Close_Child_Sales.Text = "X";
            this.btn_Close_Child_Sales.UseVisualStyleBackColor = true;
            // 
            // frm_Customer_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1319, 655);
            this.Controls.Add(this.btn_Close_Child_Sales);
            this.Controls.Add(this.lbl_LapHD);
            this.Controls.Add(this.tblLayout_Cus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Customer_Detail";
            this.Text = "frm_Customer_Detail";
            this.Load += new System.EventHandler(this.frm_Customer_Detail_Load);
            this.tblLayout_Cus.ResumeLayout(false);
            this.tblLayout_Cus.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LapHD;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Cus;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnAdd_Customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btn_Close_Child_Sales;
    }
}