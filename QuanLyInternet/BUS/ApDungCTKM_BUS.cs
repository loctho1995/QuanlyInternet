using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class ApDungCTKM_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaCTKM", typeof(int));
            dt.Columns.Add("MaDoiTuong", typeof(int));
            dt.Columns.Add("MaGoiCuocKM", typeof(int));

            var kh = SQLDataContext.SQLData.getApDungCTKM();
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = i.STT;
                r["MaCTKM"] = i.MaCTKM;
                r["MaDoiTuong"] = i.MaDoiTuong;
                r["MaGoiCuocKM"] = i.MaGoiCuocKM;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
