using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class TinhTrang_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã Tình Trạng", typeof(string));
            dt.Columns.Add("Nội Dung", typeof(string));

            var tt = SQLDataContext.SQLData.getTinhTrang();
            int stt = 1;
            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã Tình Trạng"] = i.MaTinhTrang;
                r["Nội Dung"] = i.NoiDung;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string matinhtrang, string tentinhtrang)
        {
            SQLDataContext.SQLData.addTinhTrang(matinhtrang, tentinhtrang);
        }

        public void edit(string matinhtrang, string tentinhtrang)
        {
            SQLDataContext.SQLData.editTinhTrang(matinhtrang, tentinhtrang);
        }

        public void delete(string matinhtrang)
        {
            SQLDataContext.SQLData.deleteTinhTrang(matinhtrang);
        }
    }
}
