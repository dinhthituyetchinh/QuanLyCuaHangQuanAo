using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Report
{
    public partial class Frm_ChiTietHoaDon : Form
    {
        public Frm_ChiTietHoaDon()
        {
            InitializeComponent();
        }
        // Thuộc tính MaHoaDon để nhận giá trị từ form chính
        public string MaHoaDon { get; set; }


        private void Frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            Report_ChiTietHoaDon hihi = new Report_ChiTietHoaDon();
            hihi.SetDatabaseLogon("sa", "123", "ANVYNEHIHI", "QL_CUAHANGQUANAO");

            crystalReportViewer1.ReportSource = hihi;
            crystalReportViewer1.Refresh();
        }
    }
}
