int[] array = [100, 5, 4, 7, 8, 35, 1, 3, 8, 500];
int i = 0;
int max = array[0];
while (i+1 < array.Length)
{
    if(array[i+1] > max)
    {
        max = array[i+1];
    }
    i = i+1;
}
Console.Write(max);