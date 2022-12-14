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
 

 
}
    int arraySize = 7;
    int[] array = FillArray(arraySize);
    int[] MaxMin = MaxAndMinFromArray(array);
    CheckSeries(array, MaxMin);