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
            this.dataGridView1.DataSource = Database.GetInstance.CTKM.getAllResult();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            FormCTKhuyenMai ctkm = new FormCTKhuyenMai();
            ctkm.Show();        
        }
    }
}
