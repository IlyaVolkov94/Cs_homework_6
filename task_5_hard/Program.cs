/* Имеется список чисел.
Создайте список, в который попадают числа,
описывающие максимальную возрастающую последовательность.
Порядок элементов менять нельзя.
Одно число - это не последовательность.
*/

int[] FillArray(int value)
{
    int[] array = new int[value];
    for (int i = 0; i < value; i++)
    {
        array[i] = new Random().Next(0, value);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(string.Empty);
    return array;
}

int[] MaxAndMinFromArray(int[] array)
{
    int resArraySize = 2;
    int[] resArray = new int[resArraySize];
    int indexMax = 0;
    int indexMin = 1;
    resArray[indexMin] = array[0];
    resArray[indexMax] = array[0];
    foreach (int buf in array)
    {
        if (buf > resArray[indexMax])
            resArray[indexMax] = buf;
        if (buf < resArray[indexMin])
            resArray[indexMin] = buf;
    }
    Console.WriteLine($"Min {resArray[1]}; Max {resArray[0]}");
    return resArray;
}

void CheckSeries(int[] array, int[] MaxAndMinArray)
{
    int indexMax = 0;
    int indexMin = 1;
    int i = MaxAndMinArray[indexMin];
    int count = -1;
    int j = 0;
    int firstNumSeries = i;
    int series = count;
    while (i <= MaxAndMinArray[indexMax])
    {
        while (j < array.Length)
        {
            if (i+1 == array[j])
            {
                count++;
                Console.Write(array[i] + " ");
            }
            j++;
        }
        if (j == array.Length)
        {
            if (count > series)
            {
                firstNumSeries = i;
                series = count;
                count = -1;
            }
            i++;
        }
        i++;
        j = 0;
    }
}
    int arraySize = 7;
    int[] array = FillArray(arraySize);
    int[] MaxMin = MaxAndMinFromArray(array);
    CheckSeries(array, MaxMin);