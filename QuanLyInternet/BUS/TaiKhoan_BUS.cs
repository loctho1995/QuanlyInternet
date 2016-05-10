using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class TaiKhoan_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaKH", typeof(int));
            dt.Columns.Add("MaTK", typeof(int));
            dt.Columns.Add("MatKhau", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            var tk = SQLDataContext.SQLData.getTaiKhoan();
            int stt = 1;
            foreach (var i in tk)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaKH"] = i.MaKH;
                r["MaTK"] = i.MaTK;
                r["MatKhau"] = i.MatKhau;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
