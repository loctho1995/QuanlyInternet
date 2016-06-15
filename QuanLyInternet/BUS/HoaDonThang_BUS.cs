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
            dt.Columns.Add("Mã Hóa Đơn",typeof(string));
            dt.Columns.Add("Mã Hợp Đồng", typeof(string));
            dt.Columns.Add("Tháng",typeof(int));
            dt.Columns.Add("Năm",typeof(int));
            dt.Columns.Add("Ngày Thanh Toán",typeof(DateTime));
            dt.Columns.Add("Tổng Tiền", typeof(float));

            var hd = SQLDataContext.SQLData.getHoaDonThang();
            int stt = 1;
            foreach(var i in hd)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã Hóa Đơn"] = i.MaHoaDon;
                r["Mã Hợp Đồng"] = i.MaHopDong;
                r["Tháng"] = i.Thang;
                r["Năm"] = i.Nam;
                r["Tổng Tiền"] = i.TongTien;
                r["Ngày Thanh Toán"] = i.NgayThanhToan;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string mahoadon, string mahopdong, int thang, int nam, DateTime ngaythanhtoan, float tongtien)
        {
            SQLDataContext.SQLData.addHoaDonThang(mahoadon, mahopdong, thang, nam, ngaythanhtoan, tongtien);
        }

        public void edit(string mahoadon, string mahopdong, int thang, int nam, DateTime ngaythanhtoan, float tongtien)
        {
            SQLDataContext.SQLData.editHoaDonThang(mahoadon, mahopdong, thang, nam, ngaythanhtoan, tongtien);
        }

        public void delete(string mahoadon)
        {
            SQLDataContext.SQLData.deleteHoaDonThang(mahoadon);
        }
    }
}
