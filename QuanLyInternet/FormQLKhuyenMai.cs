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

            int maHDindex = dataGridView1.Columns["MaCTKM"].Index;
            //dataGridView1.SelectedRows;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string maCTKM = dataGridView1[maHDindex, rowIndex].Value.ToString();
            try
            {
                Database.GetInstance.CTKM.deleteCTKM(maCTKM);
                LoadData();
                MessageBox.Show("Thanh Cong");
            }
            catch
            {
                MessageBox.Show("Co loi xay ra");
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

        private void ambiance_Button_13_Click(object sender, EventArgs e)
        {
            int maHDindex = dataGridView1.Columns["MaCTKM"].Index;
            //dataGridView1.SelectedRows;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string maCTKM = dataGridView1[maHDindex, rowIndex].Value.ToString();


        }

        private void ambiance_Button_14_Click(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}
