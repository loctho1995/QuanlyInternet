using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyInternet
{
    public partial class FormDangKiMoi:Form
    {
        public FormDangKiMoi()
        {
            InitializeComponent();
            ambiance_ComboBox1.Items.Clear();
            ambiance_ComboBox2.Items.Clear();
            ambiance_ComboBox3.Items.Clear();
            DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
            int maDTindex = dt.Columns.IndexOf("Mã Đối Tượng");
            int MoTaDTIndex = dt.Columns.IndexOf("Mô tả");
            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                ambiance_ComboBox3.Items.Add(item);
            }
            ambiance_ComboBox3.SelectedIndex = 0;

            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("Mã Gói Cước");

            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text =  row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                ambiance_ComboBox2.Items.Add(item);
            }

            ambiance_ComboBox2.SelectedIndex = 0;

            DataTable maTT = Database.GetInstance.TinhTrang.getAllResult();
            int maTTindex = maTT.Columns.IndexOf("Mã Tình Trạng");
            int NoiDungmaTTIndex = maTT.Columns.IndexOf("Nội Dung");
            foreach (DataRow row in maTT.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maTTindex].ToString();
                item.Text = row.ItemArray[NoiDungmaTTIndex].ToString();
                ambiance_ComboBox1.Items.Add(item);
            }
            ambiance_ComboBox1.SelectedIndex = 0;
        }

        private void tbSoCMND_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoCMND.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số!");

                tbSoCMND.Text = tbSoCMND.Text.Substring(0, tbSoCMND.Text.Length - 1);
            }
        }

        private void tbDCCaidat_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoDienThoai.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");
                tbSoDienThoai.Text = tbSoDienThoai.Text.Substring(0, tbSoCMND.Text.Length - 1);
            }
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            if (tbHoVaTen.Text == "" || tbNgheNghiep.Text == "" || tbDCThuongTru.Text == "" || tbDCThanhToan.Text == "" || tbHoVaTen.Text == "" || tbSoCMND.Text == "" || tbSoDienThoai.Text == "")
            {
                MessageBox.Show("Không trường nào được để trống!");
                return;
            }
            DataTable dt = Database.GetInstance.HopDong.getAllResult();
            int maHDindex = dt.Columns.IndexOf("Mã Hợp Đồng");
            List<int> maHDindexes = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                maHDindexes.Add(Int32.Parse(row.ItemArray[maHDindex].ToString()));
            }

            int maHDmoi = 1;
            while (maHDindexes.Contains(maHDmoi))
            {
                maHDmoi++;
            }
            var GC = Database.GetInstance.GoiCuoc.getGoiCuocWith((ambiance_ComboBox2.SelectedItem as ComboboxItem).Value.ToString());
            int cuocphiindex = GC.Columns.IndexOf("Cước Thuê Bao Tháng");
            var KHRow = dt.Rows[0];
            string cuocphi = KHRow.ItemArray[cuocphiindex].ToString();
            //int stk = Int32.Parse(tbSoTaiKhoan.Text);

            int sdt = Int32.Parse(tbSoDienThoai.Text);
            try
            {
                Database.GetInstance.HopDong.addHopDong(maHDmoi.ToString(),
                                                        tbHoVaTen.Text,
                                                        tbSoCMND.Text,
                                                        tbNgheNghiep.Text,
                                                        tbDCThuongTru.Text,
                                                        tbDCCaidat.Text,
                                                        tbDCThanhToan.Text,
                                                        tbSoDienThoai.Text,
                                                        DateTime.Now,
                                                        (ambiance_ComboBox3.SelectedItem as ComboboxItem).Value.ToString(),
                                                        (ambiance_ComboBox2.SelectedItem as ComboboxItem).Value.ToString(),
                                                        DateTime.Now,
                                                        float.Parse(cuocphi),
                                                        (ambiance_ComboBox1.SelectedItem as ComboboxItem).Value.ToString(),
                                                        "user",
                                                        "password",
                                                        tbEmail.Text
                                                        );
                
                MessageBox.Show("Thành Công");
                new FormHoaDon(maHDmoi.ToString()).Show();
                this.Close();


            }
            catch (System.Data.SqlClient.SqlException exc)
            {
                MessageBox.Show("Có lỗi xảy ra" + exc.Source);
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
