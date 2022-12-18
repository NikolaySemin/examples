int[] array = { 17, 26, 43, 8, 4, 55, 6, 73, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }


    index++;
}