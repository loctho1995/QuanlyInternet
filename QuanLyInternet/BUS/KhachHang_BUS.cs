using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class KhachHang_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaKH", typeof(int));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("CMND", typeof(int));
            dt.Columns.Add("NgheNghiep", typeof(string));
            dt.Columns.Add("DCNha", typeof(string));
            dt.Columns.Add("DCCaiDat", typeof(string));
            dt.Columns.Add("DCThanhToan", typeof(string));
            dt.Columns.Add("SLTaiKhoan", typeof(int));
            dt.Columns.Add("SoDienThoai", typeof(int));
            dt.Columns.Add("TTLuuThong", typeof(int));
            dt.Columns.Add("TTThanhToan", typeof(int));

            var kh = SQLDataContext.SQLData.getKhachHang();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaKH"] = i.MaKH;
                r["HoTen"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["NgheNghiep"] = i.NgheNghiep;
                r["DCNha"] = i.DCNha;
                r["DCCaiDat"] = i.DCCaiDat;
                r["DCThanhToan"] = i.DCThanhToan;
                r["SLTaiKhoan"] = i.SLTaiKhoan;
                r["SoDienThoai"] = i.SoDienThoai;
                r["TTLuuThong"] = i.TTLuuThong;
                r["TTThanhToan"] = i.TTThanhToan;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
