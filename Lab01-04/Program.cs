using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Program
    {
        public static int num;
        public static List<General> generalList = new List<General>();
        //MAIN
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Input Number: ");
            } while (!int.TryParse(Console.ReadLine(), out num));
            int choose;
            do
            {
                Console.WriteLine("*************************MENU*****************************");
                Console.WriteLine("1. Input List");
                Console.WriteLine("2. Show List");
                Console.WriteLine("3. Show Sum Cost For 3 Objects");
                Console.WriteLine("4. Show List All Areas is Acreage > 100m2 or TownHouse is Acreage > 60m2 and Year Build >= 2019");
                Console.WriteLine("5. Type To Find (Address/Cost/Acreage)");
                Console.Write("Choose: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: 
                        Input(); 
                        break;
                    case 2:
                        Console.WriteLine("************************SHOW LIST*************************");
                        Show(generalList);
                        break;
                    case 3:
                        ShowSumCost();
                        break;
                    case 4:
                        ShowData();
                        break;
                    case 5:
                        TypeToFind();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!!");
                        break;
                }
            } while (choose != 0);
            Console.ReadKey();
        }
        //INPUT LIST
        public static void Input()
        {
            //Input list
            int choose;
            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.WriteLine("************************INPUT LIST*************************");
                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Townhouse");
                    Console.WriteLine("3. Apartment");
                    Console.Write("Choose: ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose == 0);
                switch (choose)
                {
                    case 1:
                        Area area = new Area();
                        area.Input();
                        generalList.Add(area);
                        Console.WriteLine();
                        break;
                    case 2:
                        TownHouse townHouse = new TownHouse();
                        townHouse.Input();
                        generalList.Add(townHouse);
                        Console.WriteLine();
                        break;
                    case 3:
                        Apartment apartment = new Apartment();
                        apartment.Input();
                        generalList.Add(apartment);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!!");
                        break;
                }
            }
        }
        //SHOW LIST
        public static void Show(List<General> generalList)
        {
            foreach (General gnr in generalList)
            {
                if (gnr is Area)
                {
                    Console.WriteLine("1. Area");
                    ((Area)gnr).Show();
                    Console.WriteLine();
                }
                else if (gnr is Apartment)
                {
                    Console.WriteLine("2. Apartment");
                    ((Apartment)gnr).Show();
                    Console.WriteLine();
                }
                else if (gnr is TownHouse)
                {
                    Console.WriteLine("3. TownHouse");
                    ((TownHouse)gnr).Show();
                    Console.WriteLine();
                }
            }
        }
        //SHOW SUM COST FOR 3 OBJECTS.
        public static void ShowSumCost()
        {
            double KQ1 = generalList.Sum(p => p.Cost);
            Console.WriteLine("*************SHOW AVERAGE COST FOR 3 OBJECTS*************");
            if (KQ1 > 0)
            {
                Console.WriteLine("=> Result sumary cost for 3 obiects: " + KQ1 + "\n");
            }
        }
        //SHOW LIST ALL AREAS IS ACREAGE > 100M2 OR TOWNHOUSE IS ACREAGE > 60M2 AND YEAR BUILD >= 2019
        public static void ShowData()
        {
            List<General> listKQ1 = generalList.Where(p => (p is Area) && (p as Area).Acreage > 100).ToList();
            List<General> listKQ2 = generalList.Where(q => (q is TownHouse) && (q as TownHouse).Acreage > 60 && (q as TownHouse).YearBuild >= 2019).ToList();
            Console.WriteLine("***SHOW LIST ALL AREAS IS ACREAGE > 100M2 OR TOWNHOUSE IS ACREAGE > 60M2 AND YEAR BUILD >= 2019***");
            if (listKQ1.Count() > 0)
                Show(listKQ1);
            else
                Console.WriteLine("=> There is no areas with area> 100m2!!!");
            if (listKQ2.Count() > 0)
                Show(listKQ2);
            else
                Console.WriteLine("=> There is no townhouse with area> 60m2 and year build >= 2019!!!");
        }
        //TYPE TO FIND (ADDRESS, COST, ACREAGE)
        public static void TypeToFind()
        {
            Console.WriteLine("*************TYPE TO FIND (ADDRESS, COST, ACREAGE)*************");
            Console.Write("Address To Find: ");
            string k = Console.ReadLine();
            Console.Write("Cost To Find: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Acreage To Find: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("***LIST TO FIND***");
            foreach (General gnr in generalList)
            {
                if ((String.Compare(gnr.Address, k, true) == 0) && gnr.Cost <= m && gnr.Acreage >= n)
                {
                    if (gnr is TownHouse)
                    {
                        ((TownHouse)gnr).Show();
                    }
                    else if (gnr is Apartment)
                    {
                        ((Apartment)gnr).Show();
                    }
                    else
                    {
                        Console.WriteLine("=> None of them!!!");
                    }
                }
            }
        }
    }
}
