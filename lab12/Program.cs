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

            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;

            for (int i = 0; i < gradesArr.Length; i++)
            {
                int grade = int.Parse(gradesArr[i]);

                if (grade == 5)
                {
                    count5++;
                }
                else if (grade == 4)
                {
                    count4++; 
                }
                else if (grade == 3)
                {
                    count3++;
                }
                else if (grade == 2)
                {
                    count2++;
                }
                else
                {
                    Console.WriteLine("оценки " + grade + " не существует");
                }
            }

            Console.WriteLine("пятерок: " + count5);
            Console.WriteLine("четверток: " + count4);
            Console.WriteLine("троек: " + count3);
            Console.WriteLine("двоек: " + count2);

        }
    }
}
