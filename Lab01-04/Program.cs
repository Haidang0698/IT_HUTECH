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
        static void Main(string[] args)
        {
            Input();
            Console.WriteLine("==========SHOW LIST==========");
            Show(generalList);
            ShowCost_Acreage();
            ShowSumCost();
            Console.ReadKey();
        }

        //INPUT LIST
        public static void Input()
        {
            //Input Number
            do
            {
                Console.Write("Input Number: ");
            } while (!int.TryParse(Console.ReadLine(), out num));
            //Input list
            Console.WriteLine("==========INPUT LIST==========");
            int choose;
            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.WriteLine("\n1. Area\n2. Apartment\n3. TownHouse");
                    Console.Write("Choose: ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose == 1 && choose == 2 && choose == 3);

                switch (choose)
                {
                    case 1:
                        Area area = new Area();
                        area.Input();
                        generalList.Add(area);
                        Console.WriteLine();
                        break;
                    case 2:
                        Apartment apartment = new Apartment();
                        apartment.Input();
                        generalList.Add(apartment);
                        Console.WriteLine();
                        break;
                    case 3:
                        TownHouse townHouse = new TownHouse();
                        townHouse.Input();
                        generalList.Add(townHouse);
                        Console.WriteLine();
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
                    ((Area)gnr).Show();
                    Console.WriteLine();
                }
                else if (gnr is Apartment)
                {
                    ((Apartment)gnr).Show();
                    Console.WriteLine();
                }
                else if (gnr is TownHouse)
                {
                    ((TownHouse)gnr).Show();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        //SHOW SUM COST FOR 3 OBJECTS.
        public static void ShowSumCost()
       {
            double KQ1 = generalList.Sum(p => p.Cost);
            if (KQ1 > 0)
            {
                Console.WriteLine("Result sumary cost for 3 obiects: " + KQ1);
            }
       }

        //SHOW AREAS COST < 1 BILION AND AREAGE >= 60M^2
        public static void ShowCost_Acreage()
        {
            List<General> listKQ2 = generalList.Where(p => p.Cost < 1000000000 && p.Acreage >= 60).ToList();
            Console.WriteLine("==========SHOW AREAS COST < 1 BILION AND AREAGE >= 60M^2==========");
            if (listKQ2.Count() > 0)
            {
                Show(listKQ2);
            }
        }
    }
}
