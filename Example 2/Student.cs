using System;
using System.Text;

namespace Example2
{
    public class Student
    {
        public string name; //Ім'я
        public int age; // вік
        public string role; // роль
        public string facultet;
        public string group;
        public int course;
        public int rate;

        //конструктор з параметрами
        public Student(string name, int age, string role, string facultet, string group, int course)
        {
            this.name = name;
            this.age = age;
            this.role = role;
            this.facultet = facultet;
            this.group = group;
            this.course = course;
        }

        public Student()
        {
            this.name = "Artem";
            this.age = 18;
            this.role = "студент";
            this.course = 3;
        }

        public void PrintRate()
        {
            if (this.rate >= 90)
                Console.WriteLine("Привіт відмінникам");
            else
            {
                if (this.rate < 50)
                    Console.WriteLine("Треба вчитися краще!");
                else
                    Console.WriteLine("Можна вчитися ще краще!");
            }
        }

        public void Passport()
        {
            Console.WriteLine("Хто ви?");
            Console.WriteLine("Прiзвище = " + name);
            Console.WriteLine("Вiк= " + age);
            Console.WriteLine("Роль= " + role);
            Console.WriteLine("Факультет = " + facultet);
            Console.WriteLine("група= " + group);
            Console.WriteLine("курс= " + course);
            Console.WriteLine("рейтинг= " + rate);
            PrintRate();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nХто ви?");
            sb.Append("\nПрiзвище = " + name);
            sb.Append("\nВiк= " + age);
            sb.Append("\nРоль= " + role);
            sb.Append("\nФакультет = " + facultet);
            sb.Append("\nгрупа= " + group);
            sb.Append("\nкурс= " + course);
            sb.Append("\nрейтинг= " + rate);
            return sb.ToString();
        }


    }
}
