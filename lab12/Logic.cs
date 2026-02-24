using System;

public class Logic
{
    public static int[] CountGrades(string[] grades)
    {
        int count5 = 0;
        int count4 = 0;
        int count3 = 0;
        int count2 = 0;


        for (int i = 0; i < grades.Length; i++)
        {              
            int grade = int.Parse(grades[i]);

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
        }

        return new int[] { count5, count4, count3, count2 };
    }
}
