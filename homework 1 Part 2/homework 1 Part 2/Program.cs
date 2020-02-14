using System;

namespace homework_1_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            string StudentID = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            string PercentHomeworkInput = Console.ReadLine();
            int PercentHomework = Convert.ToInt32(PercentHomeworkInput);
            Console.WriteLine("What is your overall percentage grade for participations?");
            string PercentParticipationInput = Console.ReadLine();
            int PercentParticipation = Convert.ToInt32(PercentParticipationInput);
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            string PercentQuizzesInput = Console.ReadLine();
            int PercentQuizzes = Convert.ToInt32(PercentQuizzesInput);
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            string PercentMidtermInput = Console.ReadLine();
            int PercentMidterm = Convert.ToInt32(PercentMidtermInput);
            Console.WriteLine("What is your overall percentage grade for the final?");
            string PercentFinalInput = Console.ReadLine();
            int PercentFinal = Convert.ToInt32(PercentFinalInput);
            string ClassFinal = (ref int PercentHomework + ref int PercentParticipation +
                ref int (PercentQuizzes + ref int PercentMidterm + ref int PercentFinal) / 5;
            Console.WriteLine(FirstName LastName (StudentID)', your final grade is' ClassFinal);
        }
    }
}
