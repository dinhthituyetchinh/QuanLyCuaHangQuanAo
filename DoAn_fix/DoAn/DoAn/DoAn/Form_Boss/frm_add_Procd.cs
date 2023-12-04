using DoAn.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;

namespace DoAn.Form_Boss
{
    public partial class frm_add_Procd : Form
    {
        public string masp;
        ProductService productService = new ProductService();
        public static bool isOpen = true;
        public frm_add_Procd(string masp)
        {
            this.masp = masp;
            InitializeComponent();
        }
       
        private void frm_add_Procd_Load(object sender, EventArgs e)
        {

            if (masp != null)
            {
                productService.loadChatLieu(cmbChatLieuSP);
                productService.loadMau(cmbMauSac);

                btnThemSP.Text = "Sửa";

                // Load
                Product product = productService.GetProductByMaSP(masp);
                
                txtMaSP.Text = product.MaSanPham;
                txtMaSP.Enabled = false;
                txtTenSP.Text = product.TenSanPham;
                txtKichThuoc.Text =product.KichThuoc;
                txtSL.Text = product.SoLuong.ToString();
                txtDonGiaNhap.Text =  product.DonGiaNhap.ToString();
                txtDonGiaBan.Text = product.DonGiaBan.ToString();
                rtbMoTa.Text = product.MoTa;
                // Update
               


            } else
            {
                txtMaSP.Enabled = false;
                productService.loadChatLieu(cmbChatLieuSP);
                productService.loadMau(cmbMauSac);
                txtMaSP.Text = productService.xuLyMaLoai();
                //////fake data
                //txtTenSP.Text = "asd";
                //txtKichThuoc.Text = "L";
                //txtSL.Text = "100";
                //txtDonGiaNhap.Text = "245000";
                //txtDonGiaBan.Text = "500000";
                //rtbMoTa.Text = "aaa123";
            }

            
        }

        public static bool isClose = false;

        private void btn_Close_Child_Sales_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return;
            }
            if (txtKichThuoc.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập kích thước");
                return;
            }
            if (txtSL.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng số lượng");
                return;
            }

            if (txtDonGiaNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đơn giá nhập");
                return;
            }
            if (txtDonGiaBan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đơn giá bán");
                return;
            }
            if (rtbMoTa.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mô tả");
                return;
            }

            int sl = int.Parse(txtSL.Text);
            float giaNhap = float.Parse(txtDonGiaNhap.Text);
            float giaBan = float.Parse(txtDonGiaBan.Text);
            string img = "default-product.png";
            if (imgName == null)
            {
                imgName = img;
            }
            if(sl == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }    
            if(giaNhap > giaBan)
            {
                MessageBox.Show("Đơn giá nhập phải nhỏ hơn đơn giá bán vui lòng kiểm tra lại");
                txtDonGiaNhap.Focus();
                return;
            }    

            if (cmbMauSac.Text == "All")
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
                return;
            }
            if (cmbChatLieuSP.Text == "All")
            {
                MessageBox.Show("Vui lòng chọn chất liệu");
                return;
            }

            if (masp != null)
            {
                Product updatedProduct = new Product();
                updatedProduct.MaSanPham = txtMaSP.Text.Trim();
                updatedProduct.TenSanPham = txtTenSP.Text;
                updatedProduct.KichThuoc = txtKichThuoc.Text;
                updatedProduct.DonGiaNhap = giaNhap;
                updatedProduct.DonGiaBan = giaBan;
                updatedProduct.SoLuong = sl;
                updatedProduct.MoTa = rtbMoTa.Text;
                updatedProduct.HinhAnh = imgName;


                productService.UpdateProductByMaSP(updatedProduct);
                productService.UpdateProductColor(txtMaSP.Text.Trim(), int.Parse(cmbMauSac.SelectedValue.ToString()), cmbChatLieuSP.SelectedValue.ToString().Trim());
                MessageBox.Show("Update sản phẩm thành công");

            }
            else
            {
               
                DBConnect.addData("SANPHAM", txtMaSP.Text, txtTenSP.Text, txtKichThuoc.Text, sl, giaNhap, giaBan, rtbMoTa.Text, imgName);
                DBConnect.addData("SANPHAM_MAU_CHATLIEU", txtMaSP.Text, cmbMauSac.SelectedValue, cmbChatLieuSP.SelectedValue.ToString());
                MessageBox.Show("Thêm sản phẩm thành công");

            }


            txtTenSP.Clear();
            txtKichThuoc.Clear();
            txtSL.Clear();
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            rtbMoTa.Clear();
        }
        public string imgName;
        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string directoryPath = Path.GetDirectoryName(file);
                imgName = file;
                pictureBox1.ImageLocation = file;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số");
            }
        }
    }
}
