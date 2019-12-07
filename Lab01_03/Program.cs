using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_03
{
    
    class Program
    {
        static List<QLThongTin> listQLTT;
        static void Main(string[] args)
        {
            int number, Chose;
            do
            {
                Console.Write("Number of Area: ");

            } while (!int.TryParse(Console.ReadLine(), out number) || number < 0);

            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("I ------ Imput List ");
                Console.WriteLine("II ------ Output List ");
                Console.WriteLine("III ------ Sort List OrderBy for Acreage ");
                Console.WriteLine("IV ------ Output List Area for Where ");
                Console.WriteLine("V ------  The average unit cost ");
                Console.WriteLine("                  << O >> END                      ");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                do
                {
                    Console.Write("Input Chose : ");

                } while (!int.TryParse(Console.ReadLine(), out Chose) || Chose < 0 || Chose > 5);
                switch (Chose)
                {
                    case 1:
                        Console.WriteLine("Input Land Listing information");
                        InputList(number);
                        break;
                    case 2:
                        Console.WriteLine("Output Land Listing information");
                        Console.WriteLine("No.\t\t\tAddress\t\t\t\tPrice\t\t\t\tAcreage ");
                        OutList(listQLTT);
                        break;
                    case 3:
                        Console.WriteLine("New Land Listing information for Acreage OrderBy");
                        Console.WriteLine("No.\t\t\tAddress\t\t\t\tPrice\t\t\t\tAcreage ");
                        SortListAcreage();
                        break;
                    case 4:
                        Console.WriteLine("Land Listing information for Where Price && Acreage");
                       
                        ListAcreageWhere();
                        break;
                    case 5:
                        Console.WriteLine("The average unit cost");
                        
                        float sum = 0;
                        List<QLThongTin> average = listQLTT.Where(p => p.Acreage >= 1000).ToList();
                        if (average.Count > 0)
                        {
                            Console.WriteLine("No.\t\t\tAddress\t\t\t\tPrice\t\t\t\tAcreage ");
                            foreach (KhuDat kd in average)
                            {
                                kd.Show();
                                sum += kd.DonGia();
                                
                            }
                            Console.WriteLine("Average : {0}", (float)(sum/average.Count()));
                        }
                        else
                        {
                            Console.WriteLine("Don't Acreage >= 1000m2\n");
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }


            } while (Chose != 0);


            Console.ReadKey();
        }

        private static void SortListAcreage()
        {
            List<QLThongTin> sortList = listQLTT.OrderBy(p => p.Acreage).ToList();
            OutList(sortList);
        }

        private static void ListAcreageWhere()
        {
            
            List<QLThongTin> listWhere = listQLTT.Where(p => p.Price < 1000000000 && p.Acreage >= 60).ToList();
            if (listWhere.Count() > 0)
            {
                Console.WriteLine("No.\t\t\tAddress\t\t\t\tPrice\t\t\t\tAcreage ");
                OutList(listWhere);
            }
            else
            {
                Console.WriteLine(">>> Don't the Land seach\n");
            }
        }

        private static void OutList(List<QLThongTin> listQLTT)
        {
            int i = 0;
            foreach(KhuDat kd in listQLTT)
            {
                Console.Write("Land: {0}\t\t\t", i + 1);
                kd.Show();
            }
        }

        private static List<QLThongTin> InputList(int number)
        {
            int i;
            listQLTT = new List<QLThongTin>();
            for(i=0; i < number; i++)
            {
                Console.WriteLine("Land Number : {0}", i + 1);
                KhuDat kd = new KhuDat();
                kd.Input();
                listQLTT.Add(kd);
            }
            return listQLTT;
        }
    }
}
