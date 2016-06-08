using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class HoaDonThang_BUS
    {
        public DataTable getALLResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaHoaDon",typeof(string));
            dt.Columns.Add("MaHopDong", typeof(string));
            dt.Columns.Add("Thang",typeof(int));
            dt.Columns.Add("Nam",typeof(int));
            dt.Columns.Add("NgayThanhToan",typeof(DateTime));
            dt.Columns.Add("TongTien", typeof(float));

            var hd = SQLDataContext.SQLData.getHoaDonThang();
            int stt = 1;
            foreach(var i in hd)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaHoaDon"] = i.MaHoaDon;
                r["MaHopDong"] = i.MaHopDong;
                r["Thang"] = i.Thang;
                r["Nam"] = i.Nam;
                r["TongTien"] = i.TongTien;
                r["NgayThanhToan"] = i.NgayThanhToan;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
