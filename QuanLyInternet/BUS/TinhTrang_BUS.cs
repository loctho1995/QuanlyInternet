using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class TinhTrang_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaTinhTrang", typeof(string));
            dt.Columns.Add("NoiDung", typeof(string));

            var tt = SQLDataContext.SQLData.getTinhTrang();
            int stt = 1;
            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaTinhTrang"] = i.MaTinhTrang;
                r["NoiDung"] = i.NoiDung;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string matinhtrang, string tentinhtrang)
        {
            SQLDataContext.SQLData.addTinhtrang(matinhtrang, tentinhtrang);
        }

        public void edit(string matinhtrang, string tentinhtrang)
        {
            SQLDataContext.SQLData.editTinhtrang(matinhtrang, tentinhtrang);
        }

        public void delete(string matinhtrang)
        {
            SQLDataContext.SQLData.deleteTinhtrang(matinhtrang);
        }
    }
}
