using System;
using System.Collections.Generic;

namespace NameFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //string the name list
            List<string> ListOfNames = new List<string>();

            //ask user to input names in the list

            Console.WriteLine("Please enter the names you are needing.");
            string Continue = "Yes";
            while (Continue != "No"&& Continue!= "no"&& Continue !="n"&& Continue != "N")
            {
                Console.WriteLine("Enter first name.");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("Are you entering more names? Yes/No");
                string fullname = "<" + lastname + ", " + firstname + ">";
                Continue = Console.ReadLine();
                ListOfNames.Add(fullname);
            }
            ListOfNames.Sort();
            Console.WriteLine("Final List:");
            foreach (string A in ListOfNames)
            {
                Console.WriteLine(A);
            }
            Console.ReadKey();
        }
    }
}
