using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class HopDong_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaHopDong", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("CMND", typeof(int));
            dt.Columns.Add("NgheNghiep", typeof(string));
            dt.Columns.Add("DCNha", typeof(string));
            dt.Columns.Add("DCCaiDat", typeof(string));
            dt.Columns.Add("DCThanhToan", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(int));
            dt.Columns.Add("NgayDangKy", typeof(DateTime));
            dt.Columns.Add("MaDoiTuong", typeof(string));
            dt.Columns.Add("MaGoiCuoc", typeof(string));
            dt.Columns.Add("NgayApDungGoiCuoc", typeof(DateTime));
            dt.Columns.Add("PhiDangKy", typeof(float));
            dt.Columns.Add("TinhTrang", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Email", typeof(string));


            var kh = SQLDataContext.SQLData.getHopDong();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaHopDong"] = i.MaHopDong;
                r["HoTen"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["NgheNghiep"] = i.NgheNghiep;
                r["DCNha"] = i.DCNha;
                r["DCCaiDat"] = i.DCCaiDat;
                r["DCThanhToan"] = i.DCThanhToan;
                r["SoDienThoai"] = i.SoDienThoai;
                r["NgayDangKy"] = i.NgayDangKy;
                r["MaDoiTuong"] = i.MaDoiTuong;
                r["MaGoiCuoc"] = i.MaGoiCuoc;
                r["NgayApDungGoiCuoc"] = i.NgayApDungGoiCuoc;
                r["PhiDangKy"] = i.PhiDangKy;
                r["TinhTrang"] = i.TinhTrang;
                r["Username"] = i.Username;
                r["Password"] = i.Password;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public DataTable getHopDongWith(string mahopdong)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaHopDong", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("CMND", typeof(int));
            dt.Columns.Add("NgheNghiep", typeof(string));
            dt.Columns.Add("DCNha", typeof(string));
            dt.Columns.Add("DCCaiDat", typeof(string));
            dt.Columns.Add("DCThanhToan", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(int));
            dt.Columns.Add("NgayDangKy", typeof(DateTime));
            dt.Columns.Add("MaDoiTuong", typeof(string));
            dt.Columns.Add("MaGoiCuoc", typeof(string));
            dt.Columns.Add("NgayApDungGoiCuoc", typeof(DateTime));
            dt.Columns.Add("PhiDangKy", typeof(float));
            dt.Columns.Add("TinhTrang", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Email", typeof(string));


            var kh = SQLDataContext.SQLData.searchHopDong(mahopdong, "", "", "", "", "", "", "", "", "", "");
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaHopDong"] = i.MaHopDong;
                r["HoTen"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["NgheNghiep"] = i.NgheNghiep;
                r["DCNha"] = i.DCNha;
                r["DCCaiDat"] = i.DCCaiDat;
                r["DCThanhToan"] = i.DCThanhToan;
                r["SoDienThoai"] = i.SoDienThoai;
                r["NgayDangKy"] = i.NgayDangKy;
                r["MaDoiTuong"] = i.MaDoiTuong;
                r["MaGoiCuoc"] = i.MaGoiCuoc;
                r["NgayApDungGoiCuoc"] = i.NgayApDungGoiCuoc;
                r["PhiDangKy"] = i.PhiDangKy;
                r["TinhTrang"] = i.TinhTrang;
                r["Username"] = i.Username;
                r["Password"] = i.Password;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void addHopDong(string mahopdong, string hoten, int cmnd, string nghenghiep, string dcnha, string dccaidat, string dcthanhtoan, int sodienthoai, DateTime ngaydangky, string madoituong, string magoicuoc, DateTime ngayapdunggoicuoc, float phidangky, string tinhtrang, string username, string password, string email)
        {
            SQLDataContext.SQLData.addHopDong(mahopdong, hoten, cmnd.ToString(), nghenghiep, dcnha, dccaidat, dcthanhtoan, sodienthoai.ToString(), ngaydangky, madoituong, magoicuoc, ngayapdunggoicuoc, phidangky, tinhtrang, username, password, email);
        }

        public void editHopDong(string mahopdong, string hoten, int cmnd, string nghenghiep, string dcnha, string dccaidat, string dcthanhtoan, int sodienthoai, DateTime ngaydangky, string madoituong, string magoicuoc, DateTime ngayapdunggoicuoc, float phidangky, string tinhtrang, string username, string password, string email)
        {
            SQLDataContext.SQLData.editHopDong(mahopdong, hoten, cmnd.ToString(), nghenghiep, dcnha, dccaidat, dcthanhtoan, sodienthoai.ToString(), ngaydangky, madoituong, magoicuoc, ngayapdunggoicuoc, phidangky, tinhtrang, username, password, email);
        }

        public void deleteHopDong(string mahopdong)
        {
            SQLDataContext.SQLData.deleteHopDong(mahopdong);
        }
    }
}
