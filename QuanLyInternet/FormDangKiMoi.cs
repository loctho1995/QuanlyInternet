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
        }

        private void tbSoCMND_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoCMND.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");

                tbSoCMND.Text = "";
            }
        }

        private void tbDCCaidat_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSoDienThoai.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbSoDienThoai.Text = "";
            }
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            if (tbHoVaTen.Text == "" || tbNgheNghiep.Text == "" || tbDCThuongTru.Text == "" || tbDCThanhToan.Text == "" || tbHoVaTen.Text == "" || tbSoCMND.Text == "" || tbSoDienThoai.Text == "")
            {
                MessageBox.Show("Khong co truong nao duoc de trong!");
                return;
            }
            DataTable dt = Database.GetInstance.HopDong.getAllResult();
            int maKHindex = dt.Columns.IndexOf("MaHopDong");
            List<int> maKHindexes = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                maKHindexes.Add(Int32.Parse(row.ItemArray[maKHindex].ToString()));
            }

            int maKHmoi = 1;
            while (maKHindexes.Contains(maKHmoi))
            {
                maKHmoi++;
            }

            int cmnd = Int32.Parse(tbSoCMND.Text);
            //int stk = Int32.Parse(tbSoTaiKhoan.Text);

            int sdt = Int32.Parse(tbSoDienThoai.Text);
            try
            {
                //Database.GetInstance.HopDong.addKhachHang(maKHmoi,
                //                                        tbHoVaTen.Text,
                //                                        cmnd,
                //                                        tbNgheNghiep.Text,
                //                                        tbDCThuongTru.Text,
                //                                        tbDCCaidat.Text,
                //                                        tbDCThanhToan.Text,
                //                                        stk,
                //                                        sdt,
                //                                        1,
                //                                        cbbTrangThai.SelectedIndex + 1,
                //                                        1,
                //                                        1);
                MessageBox.Show("Thanh Cong");
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra");
            }
        }
    }




}
