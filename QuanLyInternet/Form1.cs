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
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
                chartCustomerStatus co 3 truong:
                    + Abandoning: Bi treo do thanh toan  tre
                    + Using: dang su dung
                    + Waiting: dang cho de cap so dien thoai
             */

            /*
                chartPayment co 3 truong, nhung chi su dung 2 truong:
                    + Abandoning: KHONG SU DUNG
                    + Using: tuong ung la Paid (tuc la da thanh toan cuoc phi)
                    + Waiting: tuong ung la Unpaid (tuc la chua thanh toan cuoc phi)
            */

            btPercentAbandoning.PressedColor = btPercentAbandoning.InactiveColor = chartCustomerStatus.ColorAbandoning;
            btPercentUsing.PressedColor = btPercentUsing.InactiveColor = chartCustomerStatus.ColorUsing;
            btPercentWaiting.PressedColor = btPercentWaiting.InactiveColor = chartCustomerStatus.ColorWaiting;

            lbPercentAbandoning.Text = String.Format("Bị treo ({0} %)", chartCustomerStatus.PercentageInAbandoning);
            lbPercentUsing.Text = String.Format("Đang sử dụng ({0} %)", chartCustomerStatus.PercentageUsing);
            lbPercentWaiting.Text = String.Format("Đang đợi ({0} %)", chartCustomerStatus.PercentageWaiting);

            lbPercentPaid.Text = String.Format("Đã thanh toán ({0} %)", chartPayment.PercentageUsing);
            lbPercentUnpaid.Text = String.Format("Chưa thanh toán ({0} %)", chartPayment.PercentageWaiting);

            btPercentPaid.PressedColor = btPercentPaid.InactiveColor = chartPayment.ColorUsing;
            btPercentUnpaid.PressedColor = btPercentUnpaid.InactiveColor = chartPayment.ColorWaiting;

            chartPayment.RefreshDataAndPaint();
            chartCustomerStatus.RefreshDataAndPaint();
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            FormDangKiMoi form = new FormDangKiMoi();
            form.ShowDialog();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            FormHoSoKhachHang form = new FormHoSoKhachHang();
            form.ShowDialog();
        }

        private void monoFlat_Button7_Click(object sender, EventArgs e)
        {
            FormQLGoiCuoc fr = new FormQLGoiCuoc();
            fr.ShowDialog();
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            FormQLKhuyenMai km = new FormQLKhuyenMai();
            km.ShowDialog();
        }

        private void monoFlat_Button6_Click(object sender, EventArgs e)
        {
            FormDSDinhChiTruyCap dsDinhChi = new FormDSDinhChiTruyCap();
            dsDinhChi.ShowDialog();
        }
    }
}
