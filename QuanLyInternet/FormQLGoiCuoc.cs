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
    public partial class FormQLGoiCuoc:Form
    {
        public FormQLGoiCuoc()
        {
            InitializeComponent();
        }

        private void FormQLGoiCuoc_Load(object sender, EventArgs e)
        {
            try
            {
                cbbGoiCuoc.Items.Clear();
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

        private void LoadData()
        {
            DataTable CTKMDTB = Database.GetInstance.GoiCuoc.getGoiCuocWith((cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString());


            try
            {
                int TocDoIndex = CTKMDTB.Columns.IndexOf("Tốc Độ");
                int CuocThueBaoThangIndex = CTKMDTB.Columns.IndexOf("Cước Thuê Bao Tháng");
                int SoMBMienPhiIndex = CTKMDTB.Columns.IndexOf("Số MB miễn phí");

                var CTKMRow = CTKMDTB.Rows[0];

                tbTocDoc.Text = CTKMRow.ItemArray[TocDoIndex].ToString();
                tbCuocPhi.Text = CTKMRow.ItemArray[CuocThueBaoThangIndex].ToString();
                tbLuuLuongMienPhi.Text = CTKMRow.ItemArray[SoMBMienPhiIndex].ToString();

                groupBox.Text = (cbbGoiCuoc.SelectedItem as ComboboxItem).Text;
            }
            catch
            {

            }
            

        }

        private void cbbGoiCuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (tbCuocPhi.Text == "" || tbLuuLuongMienPhi.Text == "" || tbTocDoc.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }

                    DataTable CTKMDTB = Database.GetInstance.GoiCuoc.getGoiCuocWith((cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString());
                    Database.GetInstance.GoiCuoc.editGoiCuoc((cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString(),
                                                            (float)Int32.Parse(tbTocDoc.Text),
                                                            (float)Int32.Parse(tbCuocPhi.Text),
                                                            (float)Int32.Parse(tbLuuLuongMienPhi.Text)
                                                                        );
                }
                LoadData();
                MessageBox.Show("Thành Công");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (tbCuocPhi.Text == "" || tbLuuLuongMienPhi.Text == "" || tbTocDoc.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                        return;
                    }

                   
                    Database.GetInstance.GoiCuoc.deleteGoiCuoc((cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString());
                }
                cbbGoiCuoc.Items.Remove(cbbGoiCuoc.SelectedItem);
                LoadData();
                MessageBox.Show("Thành Công");
            }
            catch 
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void tbTocDoc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTocDoc.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");
                tbTocDoc.Text = tbTocDoc.Text.Substring(0, tbTocDoc.Text.Length - 1);
            }
        }

        private void tbLuuLuongMienPhi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbLuuLuongMienPhi.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");
                tbLuuLuongMienPhi.Text = tbTocDoc.Text.Substring(0, tbLuuLuongMienPhi.Text.Length - 1);
            }
        }

        private void tbCuocPhi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCuocPhi.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ điền chữ số.");
                tbCuocPhi.Text = tbTocDoc.Text.Substring(0, tbCuocPhi.Text.Length - 1);
            }
        }
    }
}
