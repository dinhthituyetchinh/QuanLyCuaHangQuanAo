namespace DoAn.form
{
    partial class frm_Report_Sales
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
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblLayout_Cus = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Close_Child_Sales = new System.Windows.Forms.Button();
            this.lbl_LapHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLayout_Cus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Report
            // 
            this.dgv_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Report.Location = new System.Drawing.Point(3, 2);
            this.dgv_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.RowHeadersWidth = 51;
            this.dgv_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Report.Size = new System.Drawing.Size(1143, 515);
            this.dgv_Report.TabIndex = 2;
            this.dgv_Report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Report_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Report, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 180);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 519);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(342, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(681, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thực Hiện";
            // 
            // tblLayout_Cus
            // 
            this.tblLayout_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout_Cus.ColumnCount = 4;
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tblLayout_Cus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Cus.Controls.Add(this.dateTimePickerEnd, 1, 1);
            this.tblLayout_Cus.Controls.Add(this.dateTimePickerStart, 0, 1);
            this.tblLayout_Cus.Controls.Add(this.label1, 0, 0);
            this.tblLayout_Cus.Controls.Add(this.label7, 1, 0);
            this.tblLayout_Cus.Controls.Add(this.label5, 2, 0);
            this.tblLayout_Cus.Controls.Add(this.dgv_Customer, 3, 0);
            this.tblLayout_Cus.Controls.Add(this.button1, 3, 1);
            this.tblLayout_Cus.Location = new System.Drawing.Point(29, 51);
            this.tblLayout_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayout_Cus.Name = "tblLayout_Cus";
            this.tblLayout_Cus.RowCount = 2;
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Cus.Size = new System.Drawing.Size(1149, 119);
            this.tblLayout_Cus.TabIndex = 37;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(342, 61);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(315, 27);
            this.dateTimePickerEnd.TabIndex = 37;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 61);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(305, 27);
            this.dateTimePickerStart.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Từ ngày ";
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Customer.Location = new System.Drawing.Point(812, 2);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.Size = new System.Drawing.Size(334, 55);
            this.dgv_Customer.TabIndex = 25;
            this.dgv_Customer.Text = "Tìm";
            this.dgv_Customer.UseVisualStyleBackColor = true;
            this.dgv_Customer.Click += new System.EventHandler(this.dgv_Customer_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(812, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "Chi tiết hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Close_Child_Sales
            // 
            this.btn_Close_Child_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close_Child_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Close_Child_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Close_Child_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close_Child_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Child_Sales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Close_Child_Sales.Location = new System.Drawing.Point(1155, 12);
            this.btn_Close_Child_Sales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Child_Sales.Name = "btn_Close_Child_Sales";
            this.btn_Close_Child_Sales.Size = new System.Drawing.Size(35, 43);
            this.btn_Close_Child_Sales.TabIndex = 39;
            this.btn_Close_Child_Sales.Text = "X";
            this.btn_Close_Child_Sales.UseVisualStyleBackColor = true;
            this.btn_Close_Child_Sales.Click += new System.EventHandler(this.btn_Close_Child_Sales_Click_2);
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
            this.lbl_LapHD.Size = new System.Drawing.Size(249, 36);
            this.lbl_LapHD.TabIndex = 38;
            this.lbl_LapHD.Text = "Hóa Đơn Đã Lập";
            // 
            // frm_Report_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1197, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tblLayout_Cus);
            this.Controls.Add(this.btn_Close_Child_Sales);
            this.Controls.Add(this.lbl_LapHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Report_Sales";
            this.Text = "Report_Sales";
            this.Load += new System.EventHandler(this.frm_Report_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLayout_Cus.ResumeLayout(false);
            this.tblLayout_Cus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Report;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Cus;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dgv_Customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Close_Child_Sales;
        private System.Windows.Forms.Label lbl_LapHD;
    }
}