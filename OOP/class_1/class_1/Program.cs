using class_1;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace Sınıf_ders
{
    class class_1
    {
        string color = "red";
        string model;
        int year;

        public class_1(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            class_1 myObj = new class_1();
            Console.WriteLine(myObj.color);

            class_1 c = new class_1();
            Console.WriteLine(c.color);
        }
    }
}

