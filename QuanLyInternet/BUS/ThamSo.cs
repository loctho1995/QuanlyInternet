using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class ThamSo
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PhiDangKy", typeof(float));
            dt.Columns.Add("NgayBatDauThuPhi", typeof(int));
            dt.Columns.Add("NgayKetThucThuPhi", typeof(int));

            var tt = SQLDataContext.SQLData.getThamSo();

            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["PhiDangKy"] = i.PhiDangKy;
                r["NgayBatDauThuPhi"] = i.NgayBatDauThuPhi;
                r["NgayKetThucThuPhi"] = i.NgayKetThucThuPhi;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
