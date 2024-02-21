using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("[1. Nhan vien bien che | 2. Nhan vien hop dong]: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Nhap sai. Vui long nhap lai");
                        break;
                }
                Console.Write("Ban co muon tiep tuc(Y/N): ");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10} {"Ho ten",10}{"Luong thuc lanh",20:#,##0 vnd}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10} {x.Hoten,10}{x.TinhLuong(),20:#,##0 vnd}");
            }
        }
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
        public double TinhLuongTrungBinh()
        {
            double avg;
            int count = 0;
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
                count++;
            }
            avg = sum / count;
            return avg;
        }
    }
}