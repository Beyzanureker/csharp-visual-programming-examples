using System;
namespace DateTimeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
        Console.WriteLine(dt);
           
            DateTime dt1 = new DateTime(2002, 01, 05);
            Console.WriteLine(dt1);
           
            DateTime dt2 = new DateTime(2019, 11, 23, 5, 10, 20);
            Console.WriteLine(dt2);
         
            DateTime dt3 = new DateTime(2019, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt3);
        }
    }
}