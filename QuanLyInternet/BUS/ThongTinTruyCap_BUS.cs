using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class ThongTinTruyCap_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã Hợp Đồng", typeof(string));
            dt.Columns.Add("Ngày Truy Cập", typeof(DateTime));
            dt.Columns.Add("Thời Điểm Truy Cập", typeof(TimeSpan));
            dt.Columns.Add("Địa Chỉ Truy Cập", typeof(string));
            dt.Columns.Add("Dung Lượng Sử Dụng", typeof(float));

            var tt = SQLDataContext.SQLData.getThongTinTruyCap();

            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = i.STT;
                r["Mã Hợp Đồng"] = i.MaHopDong;
                r["Ngày Truy Cập"] = i.NgayTruyCap;
                r["Thời Điểm Truy Cập"] = i.ThoiDiemTruyCap;
                r["Địa Chỉ Truy Cập"] = i.DiaChiTruyCap;
                r["Dung Lượng Sử Dụng"] = i.DungLuongSuDung;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string mahopdong, DateTime ngaytruycap, TimeSpan thoidiemtruycap, string diachitruycap, float dungluongsudung)
        {
            SQLDataContext.SQLData.addThongTinTruyCap(mahopdong, ngaytruycap, thoidiemtruycap, diachitruycap, dungluongsudung);
        }

        public DataTable getThongTinTruyCapWith(string mahopdong)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaHopDong", typeof(string));
            dt.Columns.Add("NgayTruyCap", typeof(DateTime));
            dt.Columns.Add("ThoiDiemTruyCap", typeof(TimeSpan));
            dt.Columns.Add("DiaChiTruyCap", typeof(string));
            dt.Columns.Add("DungLuongSuDung", typeof(float));

            var tt = SQLDataContext.SQLData.searchThongTinTruyCap(mahopdong);
            int stt = 1;
            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaHopDong"] = i.MaHopDong;
                r["NgayTruyCap"] = i.NgayTruyCap;
                r["ThoiDiemTruyCap"] = i.ThoiDiemTruyCap;
                r["DiaChiTruyCap"] = i.DiaChiTruyCap;
                r["DungLuongSuDung"] = i.DungLuongSuDung;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
