/* Имеется список чисел.
Создайте список, в который попадают числа,
описывающие максимальную возрастающую последовательность.
Порядок элементов менять нельзя.
Одно число - это не последовательность.
*/

int[] FillRandomArray(int value)
{
    int[] array = new int[value];
    int temp = new Random().Next(0, value * 2);
    int j = 0;
    for (int i = 0; i < value; i++)
    {
        while (j < i)   //Проверяем рандомное число на наличие его в массиве
        {
            if (array[j] == temp)
            {
                temp = new Random().Next(0, value);
                j = 0;
            }
            else j++;
        }
        array[i] = temp;
    }
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
    while(i<=MaxAndMinArray[indexMax])
    {
        
    }

}