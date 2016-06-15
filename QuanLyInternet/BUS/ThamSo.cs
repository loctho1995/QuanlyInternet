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
            dt.Columns.Add("Phí Đăng ký", typeof(float));
            dt.Columns.Add("Ngày Bắt đầu thu phí", typeof(int));
            dt.Columns.Add("Ngày kết thúc thu phí", typeof(int));

            var tt = SQLDataContext.SQLData.getThamSo();

            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["Phí Đăng ký"] = i.PhiDangKy;
                r["Ngày Bắt đầu thu phí"] = i.NgayBatDauThuPhi;
                r["Ngày kết thúc thu phí"] = i.NgayKetThucThuPhi;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void edit(float phidangky, int ngaybatdauthuphi, int ngayketthucthuphi)
        {
            SQLDataContext.SQLData.editThamSo(phidangky, ngaybatdauthuphi, ngayketthucthuphi);
        }
    }
}
