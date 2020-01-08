using System;

namespace LazySingleFloat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program prgm = new Program();
            prgm.SetValue(55.0f);
            prgm.PrintValue();
        }

        public void SetValue(float value)
        {
            Singleton.Instance.FltNum = value;
        }

        public void PrintValue()
        {
            Console.WriteLine($"{Singleton.Instance.FltNum}");
        }
    }
}
