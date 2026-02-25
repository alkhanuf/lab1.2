using System;

public class Logic
{
    public static Grades CountGrades(string[] grades)
    {
        Grades res = new Grades();


        for (int i = 0; i < grades.Length; i++)
        {              
            int grade = int.Parse(grades[i]);

            if (grade == 5)
            {
                res.countFive++;
            }
            else if (grade == 4)
            {
                res.countFour++;
            }
            else if (grade == 3)
            {
                res.countThree++;
            }
            else if (grade == 2)
            {
                res.countTwo++;
            }          
        }

        //не возвращать массив, сделать класс
        return res;
    }
}
