int[] array = [100, 5, 4, 7, 8, 35, 1, 3, 8, 500];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.Write(max);
//OR
for (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write(max);