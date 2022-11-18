int[] array = {132, 21, 453, 24, 15, 26, 78, 128};

int n = array.Length;
int find = 128;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine (index);
    }
    index++;
}