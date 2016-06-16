using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyInternet
{
    public partial class FormSuaThongTin:Form
    {
        public FormSuaThongTin()
        {
            InitializeComponent();
        }

        private void tbHoVaTen_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < (sender as Ambiance.Ambiance_TextBox).Text.Length;i++)
            {
                if(CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.UppercaseLetter
                    && CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.LowercaseLetter)
                {
                    MessageBox.Show("Vui lòng chỉ điền chữ!");

                    tbHoVaTen.Text = "";
                }
            }
        }

        private void tbNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < (sender as Ambiance.Ambiance_TextBox).Text.Length;i++)
            {
                if(CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.UppercaseLetter
                    && CharUnicodeInfo.GetUnicodeCategory((sender as Ambiance.Ambiance_TextBox).Text[i]) != UnicodeCategory.LowercaseLetter)
                {
                    MessageBox.Show("Vui lòng chỉ điền chữ!");

                    tbHoVaTen.Text = "";
                }
            }
        }
        private void btOK_Click(object sender, EventArgs e)
        {


        }
    }
}
