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
    public partial class FormHoSoKhachHang:Form
    {
        public FormHoSoKhachHang()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Database.GetInstance.HopDong.getAllResult();
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int maHDindex = dataGridView1.Columns["MaHopDong"].Index;
            //dataGridView1.SelectedRows;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string maHD = dataGridView1[maHDindex, rowIndex].Value.ToString();
            FormHienThiKhachHang hienThiKhachHang = new FormHienThiKhachHang(maHD);
            hienThiKhachHang.Show();

        }

        private void ambiance_Button_13_Click(object sender, EventArgs e)
        {
            int maHDindex = dataGridView1.Columns["MaHopDong"].Index;
            //dataGridView1.SelectedRows;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string maHD = dataGridView1[maHDindex, rowIndex].Value.ToString();
            FormHienThiKhachHang hienThiKhachHang = new FormHienThiKhachHang(maHD);
            hienThiKhachHang.Show();
        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            int maHDindex = dataGridView1.Columns["MaHopDong"].Index;
            //dataGridView1.SelectedRows;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string maHD = dataGridView1[maHDindex, rowIndex].Value.ToString();
            try
            {
                Database.GetInstance.HopDong.deleteHopDong(maHD);
                reload();
            }
            catch
            {
 
            }
            
        }

        private void reload()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Database.GetInstance.HopDong.getAllResult();
        }
    }
}
