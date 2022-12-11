// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа");
string text = Convert.ToString(Console.ReadLine());
string[] numbersString = text.Split(' ', ';');
int[] numbersInt = new int[numbersString.Length];
int count=0;
for(int i=0;i<numbersString.Length;i++)
    {
        numbersInt[i]=Convert.ToInt32(numbersString[i]);
        if(numbersInt[i]>0)
            count++;
    }
Console.WriteLine(count);