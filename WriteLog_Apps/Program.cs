using System;

namespace WriteLog_Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your value");
            string inputValue = Console.ReadLine();

            try
            {
                Console.WriteLine("Hello World!=" + Convert.ToInt32(inputValue));
            }
            catch (Exception ex)
            {
                ex.WriteLog();
            }

            Console.ReadKey();
        }
    }
}
