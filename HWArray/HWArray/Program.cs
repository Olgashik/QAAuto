// See https://aka.ms/new-console-template for more information

int[] array = new int[10];

array[0] = 1;
array[1] = 3;
array[2] = 3;
array[3] = 3;
array[4] = 3;
array[5] = 3;
array[6] = 3;
array[7] = 10;
array[8] = 10;
array[9] = 100;

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i];
    Console.WriteLine(array[i]);
}
int sumArray = array[0];
int minimum = array[0];
int maximum = array[0];

for (int i = 1; i < array.Length; i++)
{
    sumArray = sumArray + array[i];

    if (array[i] < minimum)
    {
        minimum = array[i];
    }
    else
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }
}

Console.WriteLine("AverageValue  {0}", sumArray / (float) array.Length);

Console.WriteLine("Minimum {0}", minimum);

Console.WriteLine("Maximum {0}", maximum);