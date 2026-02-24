//Известны оценки каждого из учеников класса. Посчитать количество пятерок, количество четверок, количество троек и количество двоек.

namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите оценки учеников (через пробел)");
            string grades = Console.ReadLine();

            string[] gradesArr = grades.Split(' ');

            int[] counts = Logic.CountGrades(gradesArr);

            Console.WriteLine("пятерок: " + counts[0]);
            Console.WriteLine("четверок: " + counts[1]);
            Console.WriteLine("троек: " + counts[2]);
            Console.WriteLine("двоек: " + counts[3]);
        }
    }
}
