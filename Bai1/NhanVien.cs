using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;
        public NhanVien()
        {

        }
        public NhanVien(string maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
        public string Maso
        {
            set { maso = value; }
            get { return maso; }
        }
        public string Hoten
        {
            set { hoten = value; }
            get { return hoten; }
        }
        public int Luongcung
        {
            set { luongcung = value; }
            get { return luongcung; }
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap luong cung: ");
            luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return luongcung;
        }
    }
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;
        public NhanVienBC() : base()
        {

        }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai: ");
            mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double luongthuclanh;
            double phantram;
            if (mucxeploai == "A")
            {
                phantram = 1.8;
            }
            else if (mucxeploai == "B")
            {
                phantram = 1.2;
            }
            else if (mucxeploai == "C")
            {
                phantram = 0.8;
            }
            else
            {
                phantram = 0.0;
            }
            luongthuclanh = Luongcung + (phantram * Luongcung);
            return (int)luongthuclanh;
        }
    }
    class NhanVienHD : NhanVien
    {
        private int doanhthu;
        public NhanVienHD() : base()
        {

        }
        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu) : base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu: ");
            doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            double luongthuclanh = Luongcung + (0.05 * doanhthu);
            return (int)luongthuclanh;
        }
    }
}
