using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class CTKM_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã CTKM", typeof(string));
            dt.Columns.Add("Nội Dung", typeof(string));
            dt.Columns.Add("Từ Ngày", typeof(DateTime));
            dt.Columns.Add("Đến Ngày", typeof(DateTime));
            dt.Columns.Add("Mã Gói Cước KM", typeof(string));
            dt.Columns.Add("Phí Đăng Ký KM", typeof(float));

            var kh = SQLDataContext.SQLData.getCTKM();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã CTKM"] = i.MaCTKM;
                r["Nội Dung"] = i.NoiDung;
                r["Từ Ngày"] = i.TuNgay;
                r["Đến Ngày"] = i.DenNgay;
                r["Mã Gói Cước KM"] = i.MaGoiCuocKhuyenMai;
                r["Phí Đăng Ký KM"] = i.PhiDangKyKhuyenMai;
                dt.Rows.Add(r);
            }

            //if (dt.Rows.Count == 0)
            //    return null;
            return dt;
        }

        public DataTable getCTKMWith(string mactkm)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã CTKM", typeof(string));
            dt.Columns.Add("Nội Dung", typeof(string));
            dt.Columns.Add("Từ Ngày", typeof(DateTime));
            dt.Columns.Add("Đến Ngày", typeof(DateTime));
            dt.Columns.Add("Mã Gói Cước KM", typeof(string));
            dt.Columns.Add("Phí Đăng Ký KM", typeof(float));

            var kh = SQLDataContext.SQLData.getCTKMWith(mactkm);
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã CTKM"] = i.MaCTKM;
                r["Nội Dung"] = i.NoiDung;
                r["Từ Ngày"] = i.TuNgay;
                r["Đến Ngày"] = i.DenNgay;
                r["Mã Gói Cước KM"] = i.MaGoiCuocKhuyenMai;
                r["Phí Đăng Ký KM"] = i.PhiDangKyKhuyenMai;
                dt.Rows.Add(r);
            }

            //if (dt.Rows.Count == 0)
            //    return null;
            return dt;
        }

        public void addCTKM(string mactkm, string noidung, DateTime tungay, DateTime denngay, string magoicuockhuyenmai, float phidangkykhuyenmai)
        {
            SQLDataContext.SQLData.addCTKM(mactkm, noidung, tungay, denngay, magoicuockhuyenmai, phidangkykhuyenmai);
        }

        public void editCTKM(string mactkm, string noidung, DateTime tungay, DateTime denngay, string magoicuockhuyenmai, float phidangkykhuyenmai)
        {
            SQLDataContext.SQLData.editCTKM(mactkm, noidung, tungay, denngay, magoicuockhuyenmai, phidangkykhuyenmai);
        }

        public void deleteCTKM(string mactkm)
        {
            SQLDataContext.SQLData.deleteCTKM(mactkm);
        }
    }
}
