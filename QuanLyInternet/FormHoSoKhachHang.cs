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
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            FormHienThiKhachHang form = new FormHienThiKhachHang();
            form.Show();
        }
    }
}
