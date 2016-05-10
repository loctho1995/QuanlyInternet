using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class TTLuuThong_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaTT", typeof(int));
            dt.Columns.Add("TenTT", typeof(string));


            var lt = SQLDataContext.SQLData.getTTLuuThong();
            foreach (var i in lt)
            {
                DataRow r = dt.NewRow();
                r["MaTT"] = i.MaTT;
                r["TenTT"] = i.TenTT;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
