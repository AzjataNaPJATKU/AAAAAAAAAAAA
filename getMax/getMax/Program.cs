// See https://aka.ms/new-console-template for more information

static int GetMax(int[] numbers)
{
    int maksum = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i]>maks)
        {
            maks = numbers[i];
        }
    }
    return maks;
}

int[] numb = {1,2,3,4};
Console.WriteLine(GetMax(numb));
