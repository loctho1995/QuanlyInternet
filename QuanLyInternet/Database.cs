using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyInternet.BUS;

namespace QuanLyInternet
{
    public class Database
    {
        static Database instance = null;
        public static Database GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }

        public CTKM_BUS CTKM
        { get; set; }

        public DoiTuong_BUS DoiTuong
        { get; set; }

        public DoiTuongApDungKM_BUS DoiTuongApDungKM
        { get; set; }

        public GoiCuoc_BUS GoiCuoc
        { get; set; }

        public HoaDonThang_BUS HoaDonThang
        { get; set; }

        public HopDong_BUS HopDong
        { get; set; }
        public LoaiGioTruyCap_BUS LoaiGioTruyCap
        { get; set; }
        public ThamSo thamSo
        { get; set; }

        public TinhTrang_BUS TinhTrang
        { get; set; }

        public ThongTinTruyCap_BUS ThongTinTruyCap
        { get; set; }
        private Database()
        {
            InitDataBase();
        }
        public void InitDataBase()
        {
            BUS.SQLDataContext.CreateDataContext();

            CTKM = new CTKM_BUS();
            DoiTuong = new DoiTuong_BUS();
            DoiTuongApDungKM = new DoiTuongApDungKM_BUS();
            GoiCuoc = new GoiCuoc_BUS();
            HoaDonThang = new HoaDonThang_BUS();
            HopDong = new HopDong_BUS();
            LoaiGioTruyCap = new LoaiGioTruyCap_BUS();
            thamSo = new ThamSo();
            TinhTrang = new TinhTrang_BUS();
            ThongTinTruyCap = new ThongTinTruyCap_BUS();
        }
    }

}
