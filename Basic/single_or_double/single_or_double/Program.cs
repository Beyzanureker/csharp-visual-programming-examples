public class ContinueWhile
{
    public static void Main()
    {
        int i = 1;
        while (i < 20)
        {
            i++;
            if ((i % 2) != 0)
                continue;  
            Console.WriteLine("i = " + i); 
        }
    }
}
