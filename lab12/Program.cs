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

            Grades counts = Logic.CountGrades(gradesArr);

            Console.WriteLine("пятерок: " + counts.countFive);
            Console.WriteLine("четверок: " + counts.countFour);
            Console.WriteLine("троек: " + counts.countThree);
            Console.WriteLine("двоек: " + counts.countTwo);
        }
    }
}
