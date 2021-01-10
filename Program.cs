using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many do you know  Ali :)) ?");

            int n = Convert.ToInt32(Console.ReadLine());

            Ali[] friends = new Ali[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter Ali's full name:");
                string fullName = Convert.ToString(Console.ReadLine());
                Console.Write("Please enter Ali's age:");
                int age = Convert.ToInt32(Console.ReadLine());

                friends[i] = new Ali(age, fullName);
            }

        }
    }