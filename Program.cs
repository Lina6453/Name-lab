using System;

namespace Имя
{
    public class Person
    {
        private int p;
        string name;
        const double k = 1.5;
        const double c = 3.0;
        string age;
        public Person(string nm)
        {
            name = nm;
        }
        public string GetName()
        {
            return name;
        }
        public Person (string fg)
        {
            age = fg;
        }

        public int GetAge()
        {
            return age;
        }

        public int Dohod(int p)
        {
            return Convert.ToInt32(Math.Abs(p * k));
        }
        public double MaxDohod (int p)
        {
            return Convert.ToInt32(Math.Abs(p * c));
        }

    }

    public class Manadger : Person
    {

    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string k = Console.ReadLine();
            Console.WriteLine("Введите Минимальный доход");
            string u  = Console.ReadLine();
            int f = Convert.ToInt32(u);
            Console.WriteLine("Введите возраст");
            int w = Console.ReadLine();
            Person a = new Person (w);
            Console.WriteLine("Возраст =" + a.GetAge());
            Person q = new Person(k);
            Console.WriteLine( "Имя=  " + q.GetName());
             Person n = new Person(u);
            Console.WriteLine("Доход=  " + n.Dohod(f).ToString());
            Person x = new Person(u);
            Console.WriteLine("МаксДоход= " + x.MaxDohod(f).ToString());
            Console.ReadKey();
            
        }
    }
}
