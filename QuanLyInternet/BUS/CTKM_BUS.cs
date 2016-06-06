using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class CTKM_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaCTKM", typeof(int));
            dt.Columns.Add("NoiDung", typeof(string));
            dt.Columns.Add("TuNgay", typeof(DateTime));
            dt.Columns.Add("DenNgay", typeof(DateTime));
            dt.Columns.Add("MaGoiCuocKhuyenMai", typeof(string));
            dt.Columns.Add("PhiDangKyKhuyenMai", typeof(float));

            var kh = SQLDataContext.SQLData.getCTKM();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaCTKM"] = i.MaCTKM;
                r["NoiDung"] = i.NoiDung;
                r["TuNgay"] = i.TuNgay;
                r["DenNgay"] = i.DenNgay;
                r["MaGoiCuocKhuyenMai"] = i.MaGoiCuocKhuyenMai;
                r["PhiDangKyKhuyenMai"] = i.PhiDangKyKhuyenMai;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
