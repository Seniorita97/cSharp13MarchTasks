int[] array = { 2, 3, 4, 6, 7, 10 };
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine($"cem {sum}, ededi orta  {sum / array.Length}");