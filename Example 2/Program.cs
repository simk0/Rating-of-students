using System;
namespace Example2
{
    public class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Студент 1\n");
                //ініціалізація полів класу виконується в конструкторі з параметрами
                Student student1 = new Student("Iванов", 20, "студент", "Крок", "IПЗ-2", 3);
                Console.WriteLine("Ваш рейтинг?");
                string rate = Console.ReadLine();
                SetRate(student1, rate);
                student1.Passport();

                Console.WriteLine("\n\n Студент 2\n");
                //ініціалізація деяких полів класу виконується в конструкторі без параметрів
                Student student2 = new Student();
                Console.WriteLine("Ваш рейтинг?");
                rate = Console.ReadLine();
                SetRate(student2, rate);
                Console.WriteLine(student2.ToString());
                student2.PrintRate();

                Console.ReadLine();
            }
        }
        static void SetRate(Student student, string rate)
        {
            try
            {
                student.rate = int.Parse(rate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Format error:\n{ex.Message}");
            }

        }
    }
}
