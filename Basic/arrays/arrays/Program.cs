using System;

namespace ArrayApplication
{
    class Program
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

           
            Console.Write("Array elements: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); 

      
            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        static void Main(string[] args)
        {
            Program app = new Program();

            int[] balance = new int[] { 81, 64, 78, 34, 43 };
            double avg;

            avg = app.getAverage(balance, balance.Length);

            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey();
        }
    }
}
