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
    public partial class HoSoKhachHang:Form
    {
        public HoSoKhachHang()
        {
            InitializeComponent();
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            HienThiKhachHang form = new HienThiKhachHang();
            form.Show();
        }
    }
}
