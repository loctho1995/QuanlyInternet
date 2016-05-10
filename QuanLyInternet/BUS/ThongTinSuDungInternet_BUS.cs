using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class ThongTinSuDungInternet_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaKH", typeof(int));
            dt.Columns.Add("MaTK", typeof(int));
            dt.Columns.Add("ThoiGianBatDau", typeof(DateTime));
            dt.Columns.Add("ThoiGianKetThuc", typeof(DateTime));
            dt.Columns.Add("DungLuongSuDung", typeof(float));

            var tt = SQLDataContext.SQLData.getTTSuDungInternet();
            int stt = 1;

            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaKH"] = i.MaKH;
                r["MaTK"] = i.MaTK;
                r["ThoiGianBatDau"] = i.ThoiGianBatDau;
                r["ThoiGianKetThuc"] = i.ThoiGianKetThuc;
                r["DungLuongSuDung"] = i.DungLuongSuDung;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
