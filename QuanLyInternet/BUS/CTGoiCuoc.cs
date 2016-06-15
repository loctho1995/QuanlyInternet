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
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Mã Loại Giờ Truy Cập", typeof(string));
            dt.Columns.Add("Đơn Giá", typeof(float));

            var kh = SQLDataContext.SQLData.getCTGoiCuoc();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Mã Loại Giờ Truy Cập"] = i.MaLoaiGioTruyCap;
                r["Đơn Giá"] = i.DonGia;
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
