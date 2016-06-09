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
    public partial class FormQLKhuyenMai:Form
    {
        public FormQLKhuyenMai()
        {
            InitializeComponent();
            LoadData();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            FormCTKhuyenMai ctkm = new FormCTKhuyenMai();
            ctkm.Show();

        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int maHDindex = dataGridView1.Columns["MaCTKM"].Index;
                //dataGridView1.SelectedRows;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string maCTKM = dataGridView1[maHDindex, rowIndex].Value.ToString();
                try
                {
                    Database.GetInstance.CTKM.deleteCTKM(maCTKM);
                    LoadData();
                    MessageBox.Show("Thành Công");
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

        private void LoadData()
        {
            this.dataGridView1.DataSource = Database.GetInstance.CTKM.getAllResult();
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ambiance_Button_14_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ambiance_Button_13_Click_1(object sender, EventArgs e)
        {
            try
            {
                int maHDindex = dataGridView1.Columns["MaCTKM"].Index;
                //dataGridView1.SelectedRows;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string maCTKM = dataGridView1[maHDindex, rowIndex].Value.ToString();

                //DataTable dt = Database.GetInstance.CTKM.getCTKMWith(maCTKM);

                FormCTKhuyenMai ctkm = new FormCTKhuyenMai(maCTKM);
                ctkm.Show();
            }
            catch
            {
 
            }
            


        }


    }
}
