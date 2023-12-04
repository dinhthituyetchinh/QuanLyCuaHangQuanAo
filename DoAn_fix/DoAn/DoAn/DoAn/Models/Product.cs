using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class Product
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaChatLieu { get; set; }
        public int MaMau { get; set; }
        public string TenMau { get; set; }
        public string KichThuoc { get; set; }
        public int SoLuong { get; set; }
        public float DonGiaNhap { get; set; }
        public float DonGiaBan { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public Product()
        {

        }

    }
}
