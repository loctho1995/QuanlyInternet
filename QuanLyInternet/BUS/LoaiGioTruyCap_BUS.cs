using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class LoaiGioTruyCap_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaLoaiGioTruyCap", typeof(string));
            dt.Columns.Add("KhoangThoiGian", typeof(string));

            var tt = SQLDataContext.SQLData.getLoaiGioTruyCap();
            int stt = 1;
            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaLoaiGioTruyCap"] = i.MaLoaiGioTruyCap;
                r["KhoangThoiGian"] = i.KhoangThoiGian;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string maloaigiotruycap, string khoangthoigian)
        {
            SQLDataContext.SQLData.addLoaiGioTruyCap(maloaigiotruycap, khoangthoigian);
        }

        public void edit(string maloaigiotruycap, string khoangthoigian)
        {
            SQLDataContext.SQLData.editLoaiGioTruyCap(maloaigiotruycap, khoangthoigian);
        }

        public void delete(string maloaigiotruycap)
        {
            SQLDataContext.SQLData.deleteLoaiGioTruyCap(maloaigiotruycap);
        }
    }
}
