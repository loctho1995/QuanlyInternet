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
            cbbDoiTuong.Items.Clear();
            cbbGoiCuoc.Items.Clear();
            DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
            int maDTindex = dt.Columns.IndexOf("MaDoiTuong");
            int MoTaDTIndex = dt.Columns.IndexOf("MoTa");
            
            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                cbbDoiTuong.Items.Add(item);
            }
            cbbDoiTuong.SelectedIndex = 0;

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
        }

        public FormCTKhuyenMai(string maCTKM)
        {
            InitializeComponent();
            this.maCTKM = maCTKM;
            editing = true;
            cbbDoiTuong.Items.Clear();
            cbbGoiCuoc.Items.Clear();

            //DataTable dt = Database.GetInstance.CTKM.get(maHD);

            //ambiance_TextBox1.Text = 















            DataTable dt = Database.GetInstance.DoiTuong.getAllResult();
            int maDTindex = dt.Columns.IndexOf("MaDoiTuong");
            int MoTaDTIndex = dt.Columns.IndexOf("MoTa");

            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = row.ItemArray[maDTindex].ToString();
                item.Text = row.ItemArray[MoTaDTIndex].ToString();
                cbbDoiTuong.Items.Add(item);
            }
            cbbDoiTuong.SelectedIndex = 0;

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



        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if( ambiance_TextBox1.Text == "" || ambiance_TextBox2.Text == "")
            {
                MessageBox.Show ( " Vui long dien day du thong tin dumbass");
                return;
            }
            if (!editing)
            {
                DataTable dt = Database.GetInstance.CTKM.getAllResult();
                int maCTKMindex = dt.Columns.IndexOf("MaCTKM");
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
                    MessageBox.Show("Thanh cong");
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Co loi xay ra");
                }
            }
            else
            {
 
            }
            


            
        }

        private void ambiance_TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ambiance_TextBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");

                ambiance_TextBox2.Text = "";
            }
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
