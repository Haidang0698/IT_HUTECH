using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_04
{
    class Program
    {
        static List<QLThongTin> listQLTT;
        static void Main(string[] args)
        {
            int number, Chose;

           
            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("I ------ Nhap Vao Danh sach Thongo tin ");
                Console.WriteLine("II ------ Xuat Danh Sach Thong Tin theo thu tu nhap  ");
                Console.WriteLine("III ------ Xuat Danh Sach Thong Tin theo tung loai  ");
                Console.WriteLine("IV ------ Xuat Tong Gia ban cua 3 laoi (Khu Dat , Chung Cu , Nha Pho ");
                Console.WriteLine("V ------ Xuat theo dieu kien Khu Dat (S > 100) hoac Nha Pho (S> 60 && Year >=2019) ");
                Console.WriteLine("VI ------  Nhap vao thong tin tim kiem ");
                Console.WriteLine("                  << O >> END                      ");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                do
                {

                    Console.Write("\nMoi ban chon Chuc Nang : ");


                } while (!int.TryParse(Console.ReadLine(), out Chose) || Chose < 0 || Chose > 6);
                Console.WriteLine("-----------");
                switch (Chose)
                {
                    case 1:
                        do
                        {
                            Console.Write("Nhap Vao so luong Thong Tin: ");

                        } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
                        Console.WriteLine("Xin Hay Nhap Vao Danh Sach");
                        InputList(number);
                        break;
                    case 2:
                        Console.WriteLine("Danh Sach Ban Vua Nhap Theo thu tu nhap cua ban ");

                        OutList(listQLTT);
                        break;
                    case 3:

                        Console.WriteLine("\nDanh Sach Cua Ban Theo Tung loai");

                        OutListToSpecies(listQLTT);
                        break;
                    case 4:
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        OutputSumPrice();
                        break;
                    case 5:
                        Console.WriteLine("");
                        ListWhere();
                        break;
                    case 6:
                        string diaDiem;
                        long giaBan;
                        float dienTich;
                        Console.Write("Dia Diem : ");
                        diaDiem = Console.ReadLine();
                        do
                        {
                            Console.Write("Gia ban : ");
                        } while (!long.TryParse(Console.ReadLine(), out giaBan));
                        do
                        {
                            Console.Write("Dien Tich : ");
                        } while (!float.TryParse(Console.ReadLine(), out dienTich));
                        SeachInformation(diaDiem,giaBan,dienTich);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }


            } while (Chose != 0);


            Console.ReadKey();
        }

        private static void SeachInformation(string diaDiem, long giaBan, float dienTich)
        {
            List<QLThongTin> seachList = listQLTT.Where(p => ((p is ChungCu) && String.Compare((p as ChungCu).Address, diaDiem, true) == 0 && (p as ChungCu).Price <= giaBan && (p as ChungCu).Acreage >= dienTich) || ((p is NhaPho) && String.Compare((p as NhaPho).Address, diaDiem, true) == 0 && (p as NhaPho).Price <= giaBan && (p as NhaPho).Acreage >= dienTich)).ToList();
            if (seachList.Count > 0)
            {
                OutListToSpecies(seachList);
            }
            else
            {
                Console.WriteLine("\t\t\t--- Khong Co Thong tin Can Tim ---\n");
            }
        }

        private static void ListWhere()
        {
            List<QLThongTin> skd = listQLTT.Where(p => ((p is KhuDat) && (p as KhuDat).Acreage > 100) || ((p is NhaPho) && (p as NhaPho).Acreage > 60 && (p as NhaPho).YearBuilt.Year >= 2019)).ToList();
            if (skd.Count > 0)
            {
                foreach (QLThongTin qltt in skd)
                {
                    OutListToSpecies(skd);
                }
            }
            else
            {
                Console.WriteLine("\t\t\t--- Khong co Thong tin nao thoa dieu kien tren---\n");
            }
        }

        private static void OutListToSpecies(List<QLThongTin> listQLTT)
        {
            int j = 0;
            int k = 0;
            int m = 0;

            Console.WriteLine("\n--------------------------- KHU DAT--------------------------------\n");
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is KhuDat)
                {
                    j += 1;
                    Console.WriteLine("\n--- Khu Dat {0}", j);

                    (qltt as KhuDat).Show();
                }
            }
            if(j == 0)
            {
                    Console.WriteLine("Khong Co Thong tin Khu Dat\n");
            }
            Console.WriteLine("\n--------------------------- CHUNG CU --------------------------------\n");
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is ChungCu)
                {
                    k += 1;
                    Console.WriteLine("\n--- Chung Cu {0}", k);

                    (qltt as ChungCu).Show();

                }

            }
            if (k == 0)
            {
                Console.WriteLine("Khong Co Thong tin Chung Cu\n");
            }
            Console.WriteLine("\n--------------------------- NHA PHO--------------------------------\n");
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is NhaPho)
                {
                    m += 1;
                    Console.WriteLine("\n--- Nha Pho {0}", m);

                    (qltt as NhaPho).Show();
                }
            }
            if(m == 0)
            {
                Console.WriteLine("Khong Co Thong tin Nha Pho\n");
            }
        }

        private static void OutputSumPrice()
        {
            long sumprice = 0;
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is KhuDat)
                {
                    sumprice += (qltt as KhuDat).Price;
                }

            }
            Console.WriteLine("\n--- Tong gia ban Khu Dat : {0}", sumprice);
            sumprice = 0;
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is ChungCu)
                {
                    sumprice += (qltt as ChungCu).Price;
                }

            }
            Console.WriteLine("\n--- Tong gia ban Chung Cu : {0}", sumprice);
            sumprice = 0;
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is NhaPho)
                {
                    sumprice += (qltt as NhaPho).Price;
                }

            }
            Console.WriteLine("\n--- Tong gia ban Nha Pho : {0}", sumprice);
        }

        private static void OutList(List<QLThongTin> listQLTT)
        {
            int j = 0;
            int k = 0;
            int m = 0;
            foreach (QLThongTin qltt in listQLTT)
            {
                if (qltt is KhuDat)
                {
                    j += 1;
                    Console.WriteLine("\n--- Khu Dat {0}", j);

                    (qltt as KhuDat).Show();
                }
                else
                {
                    if (qltt is ChungCu)
                    {
                        k += 1;
                        Console.WriteLine("\n--- Chung Cu {0}", k);
                        (qltt as ChungCu).Show();
                    }
                    else
                    {
                        m += 1;
                        Console.WriteLine("\n--- Nha Pho {0}", m);
                        (qltt as NhaPho).Show();
                    }
                }

            }
        }

        private static void InputList(int number)
        {
            int i, chose;
            int j = 0;
            int k = 0;
            int m = 0;
            listQLTT = new List<QLThongTin>();
            for (i = 0; i < number; i++)
            {
                Console.WriteLine("---- 1 > Nhap Thong tin Cua Khu Dat ---");
                Console.WriteLine("---- 2 > Nhap Thong tin Cua Chung Cu ---");
                Console.WriteLine("---- 3 > Nhap Thong tin Cua Nha Pho ---");

                do
                {

                    Console.Write("\n--- Ban Chon Nhap Thong Tin So : ");
                    chose = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                } while (chose < 0 || chose > 4);
                switch (chose)
                {
                    case 1:
                        j += 1;
                        Console.WriteLine("Nhap Vao Khu Dat : {0}\n", j);
                        KhuDat khuDat = new KhuDat();
                        khuDat.Input();
                        listQLTT.Add(khuDat);
                        break;
                    case 2:
                        k += 1;
                        Console.WriteLine("Nhap Vao Chung Cu : {0}\n", k);
                        ChungCu chungCu = new ChungCu();
                        chungCu.Input();
                        listQLTT.Add(chungCu);
                        break;
                    case 3:
                        m += 1;
                        Console.WriteLine("Nhap Vao Nha Pho : {0}\n", m);
                        NhaPho nhaPho = new NhaPho();
                        nhaPho.Input();
                        listQLTT.Add(nhaPho);
                        break;

                }
            }
        }
    }
}