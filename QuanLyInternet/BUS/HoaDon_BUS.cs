using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class HoaDon_BUS
    {
        public DataTable getALLResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaKH",typeof(int));
            dt.Columns.Add("Thang",typeof(int));
            dt.Columns.Add("Nam",typeof(int));
            dt.Columns.Add("TongTien",typeof(float));
            dt.Columns.Add("HanThanhToan",typeof(DateTime));
            dt.Columns.Add("NgayThanhToan",typeof(DateTime));

            var hd = SQLDataContext.SQLData.getHoaDon();
            int stt = 1;
            foreach(var i in hd)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaKH"] = i.MaKH;
                r["Thang"] = i.Thang;
                r["Nam"] = i.Nam;
                r["TongTien"] = i.TongTien;
                r["HanThanhToan"] = i.HanThanhToan;
                r["NgayThanhToan"] = i.NgayThanhToan;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
