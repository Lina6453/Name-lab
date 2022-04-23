using System;

namespace Имя
{
    public class Person
    {
        private int p;
        string name;
        const double k = 1.5;
        const double x = 3;
        public Person(string nm)
        {
            name = nm;
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

        public int MaxDohod (int p)
        {
            return Convert.ToInt32(Math.Abs(p * x));
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
            Person a = new Person (w);
            Console.WriteLine("Возраст =" + a.GetAge());
            Person q = new Person(k);
            Console.WriteLine( "Имя=  " + q.GetName());
             Person n = new Person(u);
            Console.WriteLine("Доход=  " + n.Dohod(f).ToString());
            Person b = new Person(u)
            Console.ReadKey();
        }
    }
}
