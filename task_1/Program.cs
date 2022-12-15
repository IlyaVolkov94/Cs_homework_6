// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] TransformStringtoInt(string text)
{
    string[] stringSeparators = new string[] { ", ", "; ", " ", ";", "," };
    string[] numbersString = text.Split(stringSeparators, StringSplitOptions.None);
    int[] numbersInt = new int[numbersString.Length];
    for (int i = 0; i < numbersString.Length; i++)
        numbersInt[i] = Convert.ToInt32(numbersString[i]);
    return numbersInt;
}

Console.Write("Введите числа: ");
string text = Convert.ToString(Console.ReadLine())!;
int[] array = TransformStringtoInt(text);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine("Количиство введенных натуральных чисел: " + count);