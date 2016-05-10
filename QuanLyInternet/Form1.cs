﻿using System;
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
            DangKiMoi form = new DangKiMoi();
            form.Show();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            HoSoKhachHang form = new HoSoKhachHang();
            form.Show();
        }
    }
}