using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_loop_demo
{
     class Program
    {
        static void Main(string[] args)
        {
            int record;
            Console.WriteLine("Insert number of volunteers?");
            record = Int32.Parse(Console.ReadLine());
            String[] name = new String[record];
            int[] age = new int[record];
            char[] gender = new char[record];
            String[] email = new String[record];

            for (int i = 0; i < record; i++)
            {

                if (record < 0)
                    Console.WriteLine("Please enter number of volunteers.");

                else
                {
                    Console.WriteLine("Enter name:");
                    name[i] = Console.ReadLine();
                    Console.WriteLine("Enter age:");
                    age[i] = int.Parse(Console.ReadLine());
                    Console.Write("Enter gender:");
                    gender[i] = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Enter email:");
                    email[i] = Console.ReadLine();
                }
            }
            Console.WriteLine("Name \t Age \t Gender \t Email");

            for (int i = 0; i < record; i++)
            {
                Console.WriteLine(name[i] + '\t' + age[i] + '\t' + gender[i] + '\t' + email[i]);
            }


            Console.ReadKey();
        }
    }
}