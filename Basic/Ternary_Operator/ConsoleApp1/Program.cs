using System;

public class IfElseStatementProgram
{
    public static void Main()
    {
        Console.WriteLine("Bir sayı giriniz");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 50;

        var result = a > b ? $"{a} is greater than {b}" : $"{a} is less than {b}"; 
        Console.WriteLine(result);

    }
}