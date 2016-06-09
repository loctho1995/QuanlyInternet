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
            int maDTindex = dt.Columns.IndexOf("MaDoiTuong");
            int MoTaDTIndex = dt.Columns.IndexOf("MoTa");
            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                ambiance_ComboBox3.Items.Add(item);
            }
            ambiance_ComboBox3.SelectedIndex = 0;

            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("MaGoiCuoc");

            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text =  row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                ambiance_ComboBox2.Items.Add(item);
            }

            ambiance_ComboBox2.SelectedIndex = 0;

            DataTable maTT = Database.GetInstance.TinhTrang.getAllResult();
            int maTTindex = maTT.Columns.IndexOf("MaTinhTrang");
            int NoiDungmaTTIndex = maTT.Columns.IndexOf("NoiDung");
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
            int maHDindex = dt.Columns.IndexOf("MaHopDong");
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

            int cmnd = Int32.Parse(tbSoCMND.Text);
            //int stk = Int32.Parse(tbSoTaiKhoan.Text);

            int sdt = Int32.Parse(tbSoDienThoai.Text);
            try
            {
                Database.GetInstance.HopDong.addHopDong(maHDmoi.ToString(),
                                                        tbHoVaTen.Text,
                                                        cmnd,
                                                        tbNgheNghiep.Text,
                                                        tbDCThuongTru.Text,
                                                        tbDCCaidat.Text,
                                                        tbDCThanhToan.Text,
                                                        sdt,
                                                        dateTimePicker1.Value,
                                                        (ambiance_ComboBox3.SelectedItem as ComboboxItem).Value.ToString(),
                                                        (ambiance_ComboBox2.SelectedItem as ComboboxItem).Value.ToString(),
                                                        dateTimePicker1.Value,
                                                        1,
                                                        (ambiance_ComboBox1.SelectedItem as ComboboxItem).Value.ToString(),
                                                        "user",
                                                        "password",
                                                        "@email"
                                                        );
                
                MessageBox.Show("Thanh Cong");
                this.Close();

            }
            catch (System.Data.SqlClient.SqlException exc)
            {
                MessageBox.Show("Co loi xay ra" + exc.Source);
            }
        }
    }




}
