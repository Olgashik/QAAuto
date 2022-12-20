// See https://aka.ms/new-console-template for more information
namespace MetodsMassive
{
    internal class Program
    {
     
        static float AverageValue(int[] array)
        {
            float average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average /= array.Length;
            return average;
        }
        static int MinimumValue(int[] array)
        {
            int minimal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimal)
                {
                    minimal = array[i];
                }
             }
            return minimal;
        }
        static int MaximumValue(int[] array)
        {
            int maximal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximal)
                {
                    maximal = array[i];
                }
            }
            return maximal;
        }
        static void Main()
        {
            //var param = Console.ReadLine();
           //Console.WriteLine(param);
            int[] ar1 = {10, 9, 7, 8, 9, 9, 10 };

            float average1 = AverageValue(ar1);
            Console.WriteLine("average1 {0}", average1);

            int minimal1 = MinimumValue(ar1);
            Console.WriteLine("min1 {0}", minimal1);

            int maximal1 = MaximumValue(ar1);
            Console.WriteLine("max1 {0}", maximal1);

            Console.WriteLine();

            int[] ar2 = {8, 7, 9, 8, 10, 9, 6 };

            float average2 = AverageValue(ar2);
            Console.WriteLine("average2 {0}", average2);

            int minimal2 = MinimumValue(ar2);
            Console.WriteLine("min2 {0}", minimal2);

            int maximal2 = MaximumValue(ar2);
            Console.WriteLine("max2 {0}", maximal2);

            Console.WriteLine();

            int[] ar3 = {7, 10, 9, 5, 10, 9, 6 };

            float average3 = AverageValue(ar3);
            Console.WriteLine("average3 {0}", average3);

            int minimal3 = MinimumValue(ar3);
            Console.WriteLine("min3 {0}", minimal3);

            int maximal3 = MaximumValue(ar3);
            Console.WriteLine("max3 {0}", maximal3);

            Console.WriteLine();

            int[] ar4 = {4, 7, 9, 8, 5, 9, 6 };

            float average4 = AverageValue(ar4);
            Console.WriteLine("average4 {0}", average4);

            int minimal4 = MinimumValue(ar4);
            Console.WriteLine("min4 {0}", minimal4);

            int maximal4 = MaximumValue(ar4);
            Console.WriteLine("max4 {0}", maximal4);

            Console.WriteLine();

            int[] ar5 = {8, 10, 9, 8, 10, 9, 10 };

            float average5 = AverageValue(ar5);
            Console.WriteLine("average5 {0}", average5);

            int minimal5 = MinimumValue(ar5);
            Console.WriteLine("min5 {0}", minimal5);

            int maximal5 = MaximumValue(ar5);
            Console.WriteLine("max5 {0}", maximal5);

            Console.WriteLine();
        }


    }

}
