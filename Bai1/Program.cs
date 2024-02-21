using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNV ql = new QuanLyNV();
            int chon = 0;
            do
            {
                Console.WriteLine("CHUONG TRINH QUAN LY NHAN VIEN");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Nhap danh sach nhan vien");
                Console.WriteLine("2. Hien thi thong tin cac nhan vien");
                Console.WriteLine("3. Thong ke tong tien luong cong ty phai tra cho nhan vien");
                Console.WriteLine("4. Tien luong thuc lanh trung binh cua cac nhan vien");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("------------------------------");
                Console.Write("Ban muon chon yeu cau: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong cong ty tra cho nhan vien : {ql.TinhTongLuong():#,##0 vnd}");
                        break;
                    case 4:
                        Console.WriteLine($"Trung binh tien luong thuc lanh cua cac nhan vien: {ql.TinhLuongTrungBinh():#,##0 vnd}");
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
            Console.ReadLine();
        }
    }
}
