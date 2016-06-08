using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class DoiTuongApDungKM_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaCTKM", typeof(int));
            dt.Columns.Add("MaDoiTuong", typeof(int));

            var km = SQLDataContext.SQLData.getDoiTuongApDungKM();
            int stt = 1;
            foreach (var i in km)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaCTKM"] = i.MaCTKM;
                r["MaDoiTuong"] = i.MaDoiTuong;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
