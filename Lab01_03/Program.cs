using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
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
            SortList();
            ShowCostAreage();
            CalcuCost();
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
            for (int i = 0; i < num; i++)
            {
                Area area = new Area();
                area.Input();
                generalList.Add(area);
                Console.WriteLine();
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
                }
            }
            Console.WriteLine();
        }

        //SORT LIST ORDER BY ACREAGE
        public static void SortList()
        {
            List<General> listKQ1 = generalList.OrderBy(p => p.Acreage).ToList();
            Console.WriteLine("==========SORT LIST ORDER BY ACREAGE==========");
            Show(listKQ1);
        }

        //SHOW AREAS COST < 1 BILION AND AREAGE >= 60M^2
        public static void ShowCostAreage()
        {
            List<General> listKQ2 = generalList.Where(p => p.Cost < 1000000000 && p.Acreage >= 60).ToList();
            Console.WriteLine("==========SHOW AREAS COST < 1 BILION AND AREAGE >= 60M^2==========");
            if (listKQ2.Count() > 0)
            {
                Show(listKQ2);
            }
            else
            {
                Console.WriteLine("=> There not areas cost < 1 bilion and acreage >= 60m2!");
            }
        }

        //CALCULATE THE AVERAGE UNIT COST
        public static void CalcuCost()
        {
            double KQ = generalList.Average(p => p.Cost / p.Acreage);
            foreach (General gnr in generalList)
            {
                if (gnr.Acreage > 1000)
                {
                    Console.WriteLine("Result of the average unit cost: " + KQ);
                }
            }
        }
    }
}
