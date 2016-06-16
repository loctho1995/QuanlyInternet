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
            dt.Columns.Add("Số thứ tự", typeof(int));
            dt.Columns.Add("Mã Hợp Đồng", typeof(string));
            dt.Columns.Add("Ho Tên", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Nghề nghiệp", typeof(string));
            dt.Columns.Add("Đia chỉ nhà", typeof(string));
            dt.Columns.Add("Đia chỉ cài đăt", typeof(string));
            dt.Columns.Add("Đia chỉ thanh toán", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Ngày Đăng Ký", typeof(DateTime));
            dt.Columns.Add("Mã Đối Tượng", typeof(string));
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Ngày Áp Dụng", typeof(DateTime));
            dt.Columns.Add("Phí Đăng ký", typeof(float));
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Email", typeof(string));


            var kh = SQLDataContext.SQLData.getHopDong();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["Số thứ tự"] = stt++;
                r["Mã Hợp Đồng"] = i.MaHopDong;
                r["Ho Tên"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["Nghề nghiệp"] = i.NgheNghiep;
                r["Đia chỉ nhà"] = i.DCNha;
                r["Đia chỉ cài đăt"] = i.DCCaiDat;
                r["Đia chỉ thanh toán"] = i.DCThanhToan;
                r["SDT"] = i.SoDienThoai;
                r["Ngày Đăng Ký"] = i.NgayDangKy;
                r["Mã Đối Tượng"] = i.MaDoiTuong;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Ngày Áp Dụng"] = i.NgayApDungGoiCuoc;
                r["Phí Đăng ký"] = i.PhiDangKy;
                r["Tình trạng"] = i.TinhTrang;
                r["Username"] = i.Username;
                r["Password"] = i.Password;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            //if (dt.Rows.Count == 0)
            //    return null;
            return dt;
        }

        public DataTable getHopDongWith(string mahopdong)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Số thứ tự", typeof(int));
            dt.Columns.Add("Mã Hợp Đồng", typeof(string));
            dt.Columns.Add("Ho Tên", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Nghề nghiệp", typeof(string));
            dt.Columns.Add("Đia chỉ nhà", typeof(string));
            dt.Columns.Add("Đia chỉ cài đăt", typeof(string));
            dt.Columns.Add("Đia chỉ thanh toán", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Ngày Đăng Ký", typeof(DateTime));
            dt.Columns.Add("Mã Đối Tượng", typeof(string));
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Ngày Áp Dụng", typeof(DateTime));
            dt.Columns.Add("Phí Đăng ký", typeof(float));
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Email", typeof(string));


            var kh = SQLDataContext.SQLData.searchHopDong(mahopdong, "", "", "", "", "", "", "", "", "", "");
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["Số thứ tự"] = stt++;
                r["Mã Hợp Đồng"] = i.MaHopDong;
                r["Ho Tên"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["Nghề nghiệp"] = i.NgheNghiep;
                r["Đia chỉ nhà"] = i.DCNha;
                r["Đia chỉ cài đăt"] = i.DCCaiDat;
                r["Đia chỉ thanh toán"] = i.DCThanhToan;
                r["SDT"] = i.SoDienThoai;
                r["Ngày Đăng Ký"] = i.NgayDangKy;
                r["Mã Đối Tượng"] = i.MaDoiTuong;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Ngày Áp Dụng"] = i.NgayApDungGoiCuoc;
                r["Phí Đăng ký"] = i.PhiDangKy;
                r["Tình trạng"] = i.TinhTrang;
                r["Username"] = i.Username;
                r["Password"] = i.Password;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public DataTable getHopDongWithTinhTrang(string matinhtrang)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Số thứ tự", typeof(int));
            dt.Columns.Add("Mã Hợp Đồng", typeof(string));
            dt.Columns.Add("Ho Tên", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Nghề nghiệp", typeof(string));
            dt.Columns.Add("Đia chỉ nhà", typeof(string));
            dt.Columns.Add("Đia chỉ cài đăt", typeof(string));
            dt.Columns.Add("Đia chỉ thanh toán", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Ngày Đăng Ký", typeof(DateTime));
            dt.Columns.Add("Mã Đối Tượng", typeof(string));
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Ngày Áp Dụng", typeof(DateTime));
            dt.Columns.Add("Phí Đăng ký", typeof(float));
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Email", typeof(string));


            var kh = SQLDataContext.SQLData.searchHopDong("", "", "", "", "", "", "", "", "", "", matinhtrang);
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["Số thứ tự"] = stt++;
                r["Mã Hợp Đồng"] = i.MaHopDong;
                r["Ho Tên"] = i.HoTen;
                r["CMND"] = i.CMND;
                r["Nghề nghiệp"] = i.NgheNghiep;
                r["Đia chỉ nhà"] = i.DCNha;
                r["Đia chỉ cài đăt"] = i.DCCaiDat;
                r["Đia chỉ thanh toán"] = i.DCThanhToan;
                r["SDT"] = i.SoDienThoai;
                r["Ngày Đăng Ký"] = i.NgayDangKy;
                r["Mã Đối Tượng"] = i.MaDoiTuong;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Ngày Áp Dụng"] = i.NgayApDungGoiCuoc;
                r["Phí Đăng ký"] = i.PhiDangKy;
                r["Tình trạng"] = i.TinhTrang;
                r["Username"] = i.Username;
                r["Password"] = i.Password;
                r["Email"] = i.Email;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void addHopDong(string mahopdong, string hoten, string cmnd, string nghenghiep, string dcnha, string dccaidat, string dcthanhtoan, string sodienthoai, DateTime ngaydangky, string madoituong, string magoicuoc, DateTime ngayapdunggoicuoc, float phidangky, string tinhtrang, string username, string password, string email)
        {
            SQLDataContext.SQLData.addHopDong(mahopdong, hoten, cmnd, nghenghiep, dcnha, dccaidat, dcthanhtoan, sodienthoai, ngaydangky, madoituong, magoicuoc, ngayapdunggoicuoc, phidangky, tinhtrang, username, password, email);
        }

        public void editHopDong(string mahopdong, string hoten, string cmnd, string nghenghiep, string dcnha, string dccaidat, string dcthanhtoan, string sodienthoai, DateTime ngaydangky, string madoituong, string magoicuoc, DateTime ngayapdunggoicuoc, float phidangky, string tinhtrang, string username, string password, string email)
        {
            SQLDataContext.SQLData.editHopDong(mahopdong, hoten, cmnd, nghenghiep, dcnha, dccaidat, dcthanhtoan, sodienthoai, ngaydangky, madoituong, magoicuoc, ngayapdunggoicuoc, phidangky, tinhtrang, username, password, email);
        }

        public void deleteHopDong(string mahopdong)
        {
            SQLDataContext.SQLData.deleteHopDong(mahopdong);
        }
    }
}
