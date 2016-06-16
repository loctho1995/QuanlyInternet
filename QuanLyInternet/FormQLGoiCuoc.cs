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
            cbbGoiCuoc.Items.Clear();
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

        private void LoadData()
        {
            DataTable CTKMDTB = Database.GetInstance.GoiCuoc.getGoiCuocWith((cbbGoiCuoc.SelectedItem as ComboboxItem).Value.ToString());



            int TocDoIndex = CTKMDTB.Columns.IndexOf("TocDo");
            int CuocThueBaoThangIndex = CTKMDTB.Columns.IndexOf("CuocThueBaoThang");
            int SoMBMienPhiIndex = CTKMDTB.Columns.IndexOf("SoMBMienPhi");

            var CTKMRow = CTKMDTB.Rows[0];

            tbTocDoc.Text = CTKMRow.ItemArray[TocDoIndex].ToString();
            tbCuocPhi.Text = CTKMRow.ItemArray[CuocThueBaoThangIndex].ToString();
            tbLuuLuongMienPhi.Text = CTKMRow.ItemArray[SoMBMienPhiIndex].ToString();

            groupBox.Text = (cbbGoiCuoc.SelectedItem as ComboboxItem).Text;

        }

        private void cbbGoiCuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {

        }
    }
}
