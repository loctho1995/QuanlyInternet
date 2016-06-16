using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyInternet
{
    public partial class FormHoaDon : Form
    {
        private string maHD;
        private PrintDocument printDocument1 = new PrintDocument();


        public FormHoaDon()
        {
            InitializeComponent();
        }

        public FormHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            cbbGoiCuoc.Items.Clear();

            DataTable dt = Database.GetInstance.HopDong.getHopDongWith(maHD);

            int HoTenIndex = dt.Columns.IndexOf("Ho Tên");
            int CMNDIndex = dt.Columns.IndexOf("CMND");
            int NgheNghiepIndex = dt.Columns.IndexOf("Nghề nghiệp");
            int DCNhaIndex = dt.Columns.IndexOf("Đia chỉ nhà");
            int DCCaiDatIndex = dt.Columns.IndexOf("Đia chỉ cài đăt");
            int DCThanhToanIndex = dt.Columns.IndexOf("Đia chỉ thanh toán");
            int SoDienThoaiIndex = dt.Columns.IndexOf("SDT");
            int NgayDangKyIndex = dt.Columns.IndexOf("Ngày Đăng Ký");
            int MaDoiTuongIndex = dt.Columns.IndexOf("Mã Đối Tượng");
            int MaGoiCuocIndex = dt.Columns.IndexOf("Mã Gói Cước");
            int NgayApDungGoiCuocIndex = dt.Columns.IndexOf("Ngày Áp Dụng");
            int PhiDangKyIndex = dt.Columns.IndexOf("Phí Đăng ký");
            int TinhTrangIndex = dt.Columns.IndexOf("Tình trạng");
            int UsernameIndex = dt.Columns.IndexOf("Username");
            int PasswordIndex = dt.Columns.IndexOf("Password");
            int EmailIndex = dt.Columns.IndexOf("Email");


            var KHRow = dt.Rows[0];

            tbHoVaTen.Text = KHRow.ItemArray[HoTenIndex].ToString();
            tbNgheNghiep.Text = KHRow.ItemArray[NgheNghiepIndex].ToString();
            tbDCThuongTru.Text = KHRow.ItemArray[DCNhaIndex].ToString();
            tbDCThanhToan.Text = KHRow.ItemArray[DCThanhToanIndex].ToString();

            tbSoDienThoai.Text = KHRow.ItemArray[SoDienThoaiIndex].ToString();
            tbDCCaiDat.Text = KHRow.ItemArray[DCCaiDatIndex].ToString();
            tbEmail.Text = KHRow.ItemArray[EmailIndex].ToString();
            tbPhiDK.Text = KHRow.ItemArray[PhiDangKyIndex].ToString();




            int index;


            DataTable maGC = Database.GetInstance.GoiCuoc.getAllResult();
            int maGCindex = maGC.Columns.IndexOf("Mã Gói Cước");

            index = 0;

            foreach (DataRow row in maGC.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row.ItemArray[maGCindex].ToString();
                item.Value = item.Text;
                cbbGoiCuoc.Items.Add(item);
                if (item.Value.ToString() == KHRow.ItemArray[MaGoiCuocIndex].ToString())
                {
                    cbbGoiCuoc.SelectedIndex = index;
                }
                index++;
            }

            tbHoVaTen.Enabled = false;
            tbHoVaTen.Enabled = false;
            tbNgheNghiep.Enabled = false;
            tbDCThuongTru.Enabled = false;
            tbDCThanhToan.Enabled = false;
            tbPhiDK.Enabled = false;
            tbSoDienThoai.Enabled = false;
            tbDCCaiDat.Enabled = false;
            tbEmail.Enabled = false;
            cbbGoiCuoc.Enabled = false;
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(KHRow.ItemArray[NgayApDungGoiCuocIndex].ToString());
            }
            catch (Exception e)
            {

            }
            dateTimePicker1.Enabled = false;


            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            
        }

        private void tbCloseAndNotSave_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            //printDocument1.Print();

            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        private void btCloseAndSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            s.Height -= 20 + 38;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            CaptureScreen();

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.Show();
        }


    }
}
