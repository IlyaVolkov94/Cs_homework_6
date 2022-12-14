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
        array[i] = new Random().Next(-value, value);
    return array;
}

int[] MaxAndMinFromArray(int[] array)
{
    int resArraySize = 2;
    int[] resArray = new int[resArraySize];
    int indexMin = 0;
    int indexMax = 1;
    resArray[indexMin] = array[0];
    resArray[indexMax] = array[0];
    foreach (int buf in array)
    {
        if (buf > resArray[indexMax])
            resArray[indexMax] = buf;
        if (buf < resArray[indexMin])
            resArray[indexMin] = buf;
    }
    return resArray;
}

void CheckSeries(int[] array, int[] MaxAndMinArray)
{
    int indexMax = 0;
    int indexMin = 1;
    int i = MaxAndMinArray[indexMin];
    int count = -1;
    int j = 0;
    int firstNumSeries = 0;
    int series = 0;
    while (i <= MaxAndMinArray[indexMax])
    {
        while (j < array.Length)
        {
            if (i == array[j])
            {
                count++;
                break;
            }
        }
        if (j == array.Length)
        {
            if (series > count)
            {
                firstNumSeries = i;
                series = count;
            }
            count = -1;
            i++;
        }
        i++;
        j = 0;
    }

        Console.WriteLine($"Первое число серии {firstNumSeries}, длина серии {series}");
}