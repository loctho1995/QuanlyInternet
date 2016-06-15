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
    public partial class FormCTKhuyenMai:Form
    {
        private string maCTKM;
        private bool editing = false;
        public FormCTKhuyenMai()
        {
            InitializeComponent();
            cbbGoiCuoc.Items.Clear();
            try
            {
                DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
                int maDTindex = dt.Columns.IndexOf("Mã Đối Tượng");
                int MoTaDTIndex = dt.Columns.IndexOf("Mô Tả");


                DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
                int maGCindex = maGC.Columns.IndexOf("Mã Gói Cước");

                foreach (DataRow row in maGC.Rows)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = row.ItemArray[maGCindex].ToString();
                    item.Value = item.Text;
                    cbbGoiCuoc.Items.Add(item);
                }

                cbbGoiCuoc.SelectedIndex = 0;
            }
            catch
            {
 
            }
            
        }

        public FormCTKhuyenMai(string maCTKM)
        {
            InitializeComponent();
            this.maCTKM = maCTKM;
            editing = true;
            
            cbbGoiCuoc.Items.Clear();

            DataTable CTKMDTB = Database.GetInstance.CTKM.getCTKMWith(maCTKM);


            int NoiDungIndex = CTKMDTB.Columns.IndexOf("Nội Dung");
            int TuNgayIndex = CTKMDTB.Columns.IndexOf("Từ Ngày");
            int DenNgayIndex = CTKMDTB.Columns.IndexOf("Đến Ngày");
            int MaGoiCuocKhuyenMaiIndex = CTKMDTB.Columns.IndexOf("Mã Gói Cước KM");
            int PhiDangKyKhuyenMaiIndex = CTKMDTB.Columns.IndexOf("Phí Đăng Ký KM");

            var CTKMRow = CTKMDTB.Rows[0];

            ambiance_TextBox1.Text = CTKMRow.ItemArray[NoiDungIndex].ToString();
            ambiance_TextBox2.Text = CTKMRow.ItemArray[PhiDangKyKhuyenMaiIndex].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(CTKMRow.ItemArray[TuNgayIndex].ToString());
            dateTimePicker2.Value = Convert.ToDateTime(CTKMRow.ItemArray[DenNgayIndex].ToString());





            DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
    

            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("Mã Gói Cước");

            int index = 0;
            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                cbbGoiCuoc.Items.Add(item);
                if (item.Value.ToString() == CTKMRow.ItemArray[MaGoiCuocKhuyenMaiIndex].ToString())
                {
                    cbbGoiCuoc.SelectedIndex = index;
                }
                    index++;
            }

            



        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if( ambiance_TextBox1.Text == "" || ambiance_TextBox2.Text == "")
            {
                MessageBox.Show ( " Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (dateTimePicker1.Value.CompareTo(dateTimePicker2.Value) > 0)
            {
                MessageBox.Show("Ngày bắt đầu chương trình phải sớm hơn ngày kết thúc");
                return;
            }
            if (!editing)
            {
                DataTable dt = Database.GetInstance.CTKM.getAllResult();
                int maCTKMindex = dt.Columns.IndexOf("Mã CTKM");
                List<int> maCTKMindexes = new List<int>();
                foreach (DataRow row in dt.Rows)
                {
                    maCTKMindexes.Add(Int32.Parse(row.ItemArray[maCTKMindex].ToString()));
                }

                int maHDmoi = 1;
                while (maCTKMindexes.Contains(maHDmoi))
                {
                    maHDmoi++;
                }
                try
                {
                    Database.GetInstance.CTKM.addCTKM(maHDmoi.ToString(), ambiance_TextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, (cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString(), float.Parse(ambiance_TextBox2.Text));
                    MessageBox.Show("Thành công!");
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn chỉnh sửa?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Database.GetInstance.CTKM.editCTKM(maCTKM, ambiance_TextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, (cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString(), float.Parse(ambiance_TextBox2.Text));
                        MessageBox.Show("Thành công");
                        this.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            


            
        }

        private void ambiance_TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ambiance_TextBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");

                ambiance_TextBox2.Text = "";
            }
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTKhuyenMai_Load(object sender, EventArgs e)
        {

        }
    }
}
