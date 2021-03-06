﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyInternet
{
    public partial class FormHienThiKhachHang:Form
    {
        string maHD;

        
        public FormHienThiKhachHang()
        {
            InitializeComponent();
            cbbTT.Items.Clear();
            cbbGoiCuoc.Items.Clear();
            cbbDoiTuong.Items.Clear();

            DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
            int maDTindex = dt.Columns.IndexOf("MaDoiTuong");
            int MoTaDTIndex = dt.Columns.IndexOf("MoTa");
            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                cbbTT.Items.Add(item);
            }
            cbbTT.SelectedIndex = 0;

            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("MaGoiCuoc");

            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                cbbGoiCuoc.Items.Add(item);
            }

            cbbGoiCuoc.SelectedIndex = 0;

            DataTable maTT = Database.GetInstance.TinhTrang.getAllResult();
            int maTTindex = maTT.Columns.IndexOf("MaTinhTrang");
            int NoiDungmaTTIndex = maTT.Columns.IndexOf("NoiDung");
            foreach (DataRow row in maTT.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maTTindex].ToString();
                item.Text = row.ItemArray[NoiDungmaTTIndex].ToString();
                cbbTT.Items.Add(item);
            }
            cbbTT.SelectedIndex = 0;
        }
        public FormHienThiKhachHang(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            cbbTT.Items.Clear();
            cbbGoiCuoc.Items.Clear();
            cbbDoiTuong.Items.Clear();

            DataTable dt = Database.GetInstance.HopDong.getHopDongWith(maHD);

            int HoTenIndex              =dt.Columns.IndexOf("Ho Tên");
            int CMNDIndex = dt.Columns.IndexOf("CMND");
            int NgheNghiepIndex = dt.Columns.IndexOf("Nghề nghiệp");
            int DCNhaIndex = dt.Columns.IndexOf("Đia chỉ nhà");
            int DCCaiDatIndex = dt.Columns.IndexOf("Đia chỉ cài đăt");
            int DCThanhToanIndex = dt.Columns.IndexOf("Đia chỉ thanh toán");
            int SoDienThoaiIndex = dt.Columns.IndexOf("SDT");
            int NgayDangKyIndex = dt.Columns.IndexOf("Ngày Đăng Ký");
            int MaDoiTuongIndex = dt.Columns.IndexOf("Mã Đối Tượng");
            int MaGoiCuocIndex = dt.Columns.IndexOf("Mã Gói Cước");
            int NgayApDungGoiCuocIndex = dt.Columns.IndexOf("Ngày Áp Dụng");
            int PhiDangKyIndex = dt.Columns.IndexOf("Phí Đăng ký");
            int TinhTrangIndex = dt.Columns.IndexOf("Tình trạng");
            int UsernameIndex = dt.Columns.IndexOf("Username");
            int PasswordIndex = dt.Columns.IndexOf("Password");
            int EmailIndex = dt.Columns.IndexOf("Email");
            
           
            var KHRow = dt.Rows[0]; 

            tbHoVaTen.Text = KHRow.ItemArray[HoTenIndex].ToString();
            tbNgheNghiep.Text = KHRow.ItemArray[NgheNghiepIndex].ToString();
            tbDCThuongTru.Text = KHRow.ItemArray[DCNhaIndex].ToString();
            tbDCThanhToan.Text = KHRow.ItemArray[DCThanhToanIndex].ToString();
            tbUserName.Text = KHRow.ItemArray[DCNhaIndex].ToString();
            tbSoCMND.Text = KHRow.ItemArray[CMNDIndex].ToString();
            tbSoDienThoai.Text = KHRow.ItemArray[SoDienThoaiIndex].ToString();
            tbDCCaiDat.Text = KHRow.ItemArray[DCCaiDatIndex].ToString();
            tbEmail.Text = KHRow.ItemArray[EmailIndex].ToString();
            tbPassword.Text = KHRow.ItemArray[PasswordIndex].ToString();
            tbUserName.Text = KHRow.ItemArray[UsernameIndex].ToString();




            DataTable doituong = Database.GetInstance.DoiTuong.getAllResult();
            int maDTindex = doituong.Columns.IndexOf("Mã Đối Tượng");
            int MoTaDTIndex = doituong.Columns.IndexOf("Mô tả");


            int index = 0;
            foreach (DataRow row in doituong.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                cbbDoiTuong.Items.Add(item);

                if (item.Value.ToString() == KHRow.ItemArray[MaDoiTuongIndex].ToString())
                {
                    cbbDoiTuong.SelectedIndex = index;
                }
                index++;
            }
            

            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("Mã Gói Cước");

            index = 0;

            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                cbbGoiCuoc.Items.Add(item);
                if (item.Value.ToString() == KHRow.ItemArray[MaGoiCuocIndex].ToString())
                {
                    cbbGoiCuoc.SelectedIndex = index;
                }
                index++;
            }


            DataTable maTT = Database.GetInstance.TinhTrang.getAllResult();
            int maTTindex = maTT.Columns.IndexOf("Mã Tình Trạng");
            int NoiDungmaTTIndex = maTT.Columns.IndexOf("Nội Dung");
            index = 0;
            foreach (DataRow row in maTT.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maTTindex].ToString();
                item.Text = row.ItemArray[NoiDungmaTTIndex].ToString();
                cbbTT.Items.Add(item);
                if (item.Value.ToString() == KHRow.ItemArray[TinhTrangIndex].ToString())
                {
                    cbbTT.SelectedIndex = index;
                }
                index++;
            }
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(KHRow.ItemArray[NgayApDungGoiCuocIndex].ToString());
                dateTimePicker2.Value = Convert.ToDateTime(KHRow.ItemArray[NgayApDungGoiCuocIndex].ToString());
            }
            catch ( Exception e)
            {
 
            }
                
            
            
            
        }

        private void tbCloseAndNotSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCloseAndSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tbHoVaTen.Text == "" || tbNgheNghiep.Text == "" || tbDCThuongTru.Text == "" || tbDCThanhToan.Text == "" || tbHoVaTen.Text == "" || tbSoCMND.Text == "" || tbSoDienThoai.Text == "" ||
                tbPassword.Text == "" || tbUserName.Text == ""
                )
                {
                    MessageBox.Show("Không được trường nào để trống!");
                    return;
                }
                try
                {
                    Database.GetInstance.HopDong.editHopDong(this.maHD,
                                                            tbHoVaTen.Text,
                                                            (tbSoCMND.Text),
                                                            tbNgheNghiep.Text,
                                                            tbDCThuongTru.Text,
                                                            tbDCCaiDat.Text,
                                                            tbDCThanhToan.Text,
                                                            (tbSoDienThoai.Text),
                                                            dateTimePicker1.Value,
                                                            (cbbDoiTuong.SelectedItem as ComboboxItem).Value.ToString(),
                                                            (cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString(),
                                                            dateTimePicker1.Value,
                                                            1,
                                                            (cbbTT.SelectedItem as ComboboxItem).Value.ToString(),
                                                            tbUserName.Text,
                                                            tbPassword.Text,
                                                            tbEmail.Text
                                                            );
                    MessageBox.Show(" Thành Công");
                    this.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show(" Có lỗi xảy ra");
                }

            }
        }

        private void tbSoCMND_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoCMND.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");
                tbSoCMND.Text = tbSoCMND.Text.Substring(0, tbSoCMND.Text.Length - 1);
            }
        }

        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoDienThoai.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ điền số.");
                tbSoDienThoai.Text = tbSoDienThoai.Text.Substring(0, tbSoCMND.Text.Length - 1); ;
            }
        }

        private void tbDCCaiDat_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormHienThiKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void tbHoVaTen_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < (sender as Ambiance.Ambiance_TextBox).Text.Length;i++)
            {
                if(CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.UppercaseLetter
                    && CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.LowercaseLetter
                    && ((sender as Ambiance.Ambiance_TextBox).Text[i]) != ' ')
                {
                    MessageBox.Show("Vui lòng chỉ điền chữ: " + tbHoVaTen.Text);

                    (sender as Ambiance.Ambiance_TextBox).Text = "";
                }
            }
        }

        private void tbNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < (sender as Ambiance.Ambiance_TextBox).Text.Length;i++)
            {
                if(CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.UppercaseLetter
                    && CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.LowercaseLetter
                    && ((sender as Ambiance.Ambiance_TextBox).Text[i]) != ' ')
                {
                    MessageBox.Show("Vui lòng chỉ điền chữ!");

                    (sender as Ambiance.Ambiance_TextBox).Text = "";
                }
            }
        }
    }
}
