using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class CTGoiCuoc
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaGoiCuoc", typeof(string));
            dt.Columns.Add("MaLoaiGioTruyCap", typeof(string));
            dt.Columns.Add("DonGia", typeof(float));

            var kh = SQLDataContext.SQLData.getCTGoiCuoc();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaGoiCuoc"] = i.MaGoiCuoc;
                r["MaLoaiGioTruyCap"] = i.MaLoaiGioTruyCap;
                r["DonGia"] = i.DonGia;
                dt.Rows.Add(r);
            }

            //if (dt.Rows.Count == 0)
            //    return null;
            return dt;
        }

        public void add(string magoicuoc, string maloaigiotruycap, float dongia)
        {
            SQLDataContext.SQLData.addCTGoiCuoc(magoicuoc, maloaigiotruycap, dongia);
        }

        public void edit(string magoicuoc, string maloaigiotruycap, float dongia)
        {
            SQLDataContext.SQLData.editCTGoiCuoc(magoicuoc, maloaigiotruycap, dongia);
        }

        public void delete(string magoicuoc, string maloaigiotruycap)
        {
            SQLDataContext.SQLData.deleteCTGoiCuoc(magoicuoc, maloaigiotruycap);
        }
    }
}
