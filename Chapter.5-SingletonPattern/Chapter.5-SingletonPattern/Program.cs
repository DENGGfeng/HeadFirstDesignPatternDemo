using System;

namespace Chapter._5_SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.ToString();

            Singleton singleton2 = Singleton.GetInstance(); 
            singleton2.ToString();

            Console.ReadKey();

        }
    }

    public class Singleton
    { 
        private static Singleton uniqueInstance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }

        public override string ToString()
        {
            Console.WriteLine(GetHashCode().ToString());
            return GetHashCode().ToString();
        }
    }
}
