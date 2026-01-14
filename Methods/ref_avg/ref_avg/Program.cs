using System;

namespace ArrayApplication
{
    class MyArray
    {
        double getAverage(int[] arr, int size,ref double avg)
        {
            int i;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg=0;

           
            app.getAverage(balance, 5,ref avg);

            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey();
        }
    }
}
