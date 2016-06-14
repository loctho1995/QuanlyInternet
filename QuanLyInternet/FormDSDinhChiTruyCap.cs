using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection;






namespace QuanLyInternet
{
    public partial class FormDSDinhChiTruyCap:Form
    {
        public FormDSDinhChiTruyCap()
        {
            InitializeComponent();
            this.dataGridView.DataSource = Database.GetInstance.HopDong.getHopDongWithTinhTrang("4");
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateTable);

            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.Show();
        }



        public void CreateTable(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView.Width, this.dataGridView.Height);
            this.dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView.Width, this.dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateTable);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        private void ambiance_Button_13_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xls) |*.xls | All Files (*.*) |*.*";
            save.ShowDialog();

            string path = save.FileName.ToString();
            if (path != "")
            {
                DataTable dataTable = new DataTable();
                dataTable = (DataTable)dataGridView.DataSource;
                try
                {
                    ExpEcel(dataTable, path);
                    MessageBox.Show("Thành công");

                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!!");

                }
            }
        }

        void ExpEcel(DataTable data, string path)
        {
            
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


            for (int i = 0; i < data.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = data.Columns[i].ColumnName;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                }
            }
            ws.Name = "Báo cáo danh sách đình chỉ truy cập";
            wb.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            wb.Close(true, misValue, misValue);
            app.Quit();
        }




    }
}
