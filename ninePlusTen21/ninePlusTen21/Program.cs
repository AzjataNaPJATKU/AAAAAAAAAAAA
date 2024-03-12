// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }
    return sum / numbers.Length;
}

int[] numb = {1,2,3,4};
double average = GetAverage(numb);
Console.WriteLine(average);