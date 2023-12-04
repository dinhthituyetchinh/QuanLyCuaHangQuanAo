namespace DoAn.form
{
    partial class frm_Customer
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblLayout_Cus = new System.Windows.Forms.TableLayoutPanel();
            this.txtID_Cus = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close_Child_Sales = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.tblLayout_Cus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
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
            this.lbl_LapHD.Size = new System.Drawing.Size(276, 36);
            this.lbl_LapHD.TabIndex = 39;
            this.lbl_LapHD.Text = "Thêm Khách Hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(155, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 22);
            this.txtName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(510, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // tblLayout_Cus
            // 
            this.tblLayout_Cus.ColumnCount = 4;
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayout_Cus.Controls.Add(this.txtID_Cus, 3, 0);
            this.tblLayout_Cus.Controls.Add(this.label3, 0, 1);
            this.tblLayout_Cus.Controls.Add(this.txtName, 1, 0);
            this.tblLayout_Cus.Controls.Add(this.txtAddress, 1, 1);
            this.tblLayout_Cus.Controls.Add(this.label1, 2, 0);
            this.tblLayout_Cus.Controls.Add(this.label2, 0, 0);
            this.tblLayout_Cus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Cus.Location = new System.Drawing.Point(3, 2);
            this.tblLayout_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayout_Cus.Name = "tblLayout_Cus";
            this.tblLayout_Cus.RowCount = 2;
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.Size = new System.Drawing.Size(1015, 98);
            this.tblLayout_Cus.TabIndex = 4;
            // 
            // txtID_Cus
            // 
            this.txtID_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID_Cus.Location = new System.Drawing.Point(662, 2);
            this.txtID_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Cus.Name = "txtID_Cus";
            this.txtID_Cus.Size = new System.Drawing.Size(350, 22);
            this.txtID_Cus.TabIndex = 10;
            this.txtID_Cus.TextChanged += new System.EventHandler(this.txtID_Cus_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(155, 51);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(349, 22);
            this.txtAddress.TabIndex = 23;
            // 
            // btnSure
            // 
            this.btnSure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSure.Location = new System.Drawing.Point(1024, 2);
            this.btnSure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(250, 98);
            this.btnSure.TabIndex = 22;
            this.btnSure.Text = "Xác Nhận Thêm";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tblLayout_Cus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSure, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 87);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1277, 102);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // btn_Close_Child_Sales
            // 
            this.btn_Close_Child_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close_Child_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Close_Child_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Close_Child_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Child_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Child_Sales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Close_Child_Sales.Location = new System.Drawing.Point(1268, 28);
            this.btn_Close_Child_Sales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Child_Sales.Name = "btn_Close_Child_Sales";
            this.btn_Close_Child_Sales.Size = new System.Drawing.Size(35, 43);
            this.btn_Close_Child_Sales.TabIndex = 40;
            this.btn_Close_Child_Sales.Text = "X";
            this.btn_Close_Child_Sales.UseVisualStyleBackColor = true;
            this.btn_Close_Child_Sales.Click += new System.EventHandler(this.btn_Close_Child_Sales_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Customer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 196);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 446);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customer.Location = new System.Drawing.Point(3, 2);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.Size = new System.Drawing.Size(1275, 442);
            this.dgv_Customer.TabIndex = 2;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1319, 655);
            this.Controls.Add(this.lbl_LapHD);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_Close_Child_Sales);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.frm_Customer_Load);
            this.tblLayout_Cus.ResumeLayout(false);
            this.tblLayout_Cus.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LapHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Cus;
        private System.Windows.Forms.TextBox txtID_Cus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Close_Child_Sales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Customer;
    }
}