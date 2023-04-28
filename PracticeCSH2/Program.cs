using System;

namespace PracticeCSH2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Абабов Абаб Абабович";
            byte age = 22;
            string eMail = "Abab@mail.ab";
            double point_Prog = 3.4;
            double point_Phy = 4.5;
            double point_Math = 5;
            string pattern = "Ф.И.О.: \t{0} \nВозраст: \t{1} \nПочта:  \t{2}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              eMail);
            string points = "Програмирование:{0} \nФизика: \t{1} \nМатематика: \t{2}";
            Console.WriteLine(points,
                              point_Prog, 
                              point_Phy, 
                              point_Math);
            Console.ReadKey();
            double sum = point_Prog+point_Phy+point_Math;
            double average = sum / 3;
            string total = "\rСумма баллов: \t{0}\nСредний балл: \t{1}";
            Console.WriteLine(total, sum, average);
            Console.ReadKey();

        }

    }
}