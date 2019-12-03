using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        public static int num;
        public static List<Person> personList = new List<Person>();
        static void Main(string[] args)
        {
            Input();
            Console.WriteLine("============SHOW LIST============");
            Show(personList);
            ShowMaxScoreIT();
            ShowAllIT();
            SearchName();
            Console.ReadKey(); 
        }

        //INPUT LIST
        public static void Input()
        {
            //Input Number List
            do
            {
                Console.Write("Input Number: ");
            } while (!int.TryParse(Console.ReadLine(), out num));
            //Input List
            Console.WriteLine("============INPUT LIST============");
            int j = 0, k = 0, choose;
            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.Write("Choose (1. Student/2. Teacher): ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose == 1 && choose == 2);
                if (choose == 1)
                {
                    Student student = new Student();
                    Console.WriteLine("Student {0}", j + 1);
                    student.Input();
                    personList.Add(student);
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    Teacher teacher = new Teacher();
                    Console.WriteLine("Teacher {0}", k + 1);
                    teacher.Input();
                    personList.Add(teacher);
                    Console.WriteLine();
                }
                
            }
        }

        //SHOW LIST
        public static void Show(List<Person> personList)
        { 
            foreach (Person pr in personList)
            {
                if (pr is Student)
                {                  
                    ((Student)pr).Show();
                }
                else if (pr is Teacher)
                {
                    ((Teacher)pr).Show();
                }
            }
        }

        //SHOW THE LIST OF STUDENT FACULTY IT AND MAX SCORE
        public static void ShowMaxScoreIT()
        {
            string faculty;
            Console.Write("\nSearch Faculty: ");
            faculty = Console.ReadLine();
            Console.WriteLine("============SHOW THE LIST OF STUDENT FACULTY IT AND MAX SCORE============");
            List<Person> studentIT = personList.Where(p => (p is Student) && (p as Student).Faculty == faculty).ToList();
            float maxScore = studentIT.Max(p => (p as Student).Mark);
            List<Person> listMaxStudentIT = studentIT.Where(p => (p as Student).Mark == maxScore).ToList();
            if (listMaxStudentIT.Count() > 0)
            {
                Show(listMaxStudentIT);
            }             
            else
            {
                Console.WriteLine("=> There not list of student faculty IT!");
            }
        }

        //SHOW THE LIST OF ALL STUDENT SCORE < 5 AND FACULTY IT
        public static void ShowAllIT()
        {
            string faculty;
            Console.Write("\nSearch Faculty: ");
            faculty = Console.ReadLine();
            Console.WriteLine("============SHOW THE LIST OF ALL STUDENT SCORE < 5 AND FACULTY IT============");
            List<Person> studentIT = personList.Where(p => (p is Student) && (p as Student).Faculty == faculty).ToList();
            List<Person> listMaxStudentIT = studentIT.Where(p => (p as Student).Mark < 5).ToList();
            if (listMaxStudentIT.Count() > 0)
            {
                Show(listMaxStudentIT);
            }
            else
            {
                Console.WriteLine("=>There not list of student faculty IT!!");
            }

        }

        //SEARCH NAME
        public static void SearchName()
        {
            string k;
            Console.Write("\nSearch Name: ");
            k = Console.ReadLine();
            Console.WriteLine("============SHOW NAME IS SEARCH============");
            foreach (Person pr in personList)
            {
                if (String.Compare(pr.Name, k, true) == 0)
                {
                    if (pr is Student)
                    {
                        ((Student)pr).Show();
                    }
                    else if (pr is Teacher)
                    {
                        ((Teacher)pr).Show();
                    }
                }
            } 
        }
    }
}
