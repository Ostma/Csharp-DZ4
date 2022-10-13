// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetNumber(string message)
{
    int result = 0;
    bool correctInput = false;

    while (!correctInput)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if (result < 1)
            correctInput = false;

        if (!correctInput)
            Console.WriteLine("Вы ввели некорректное число");

        Console.WriteLine();
    }

    return result;
}

int num = GetNumber("Введите число: ");
double numLen = 0; //длина, разрядность числа
int summ = 0; // сумма цифр
int temp = num; //временная, уменьшаемая цифра
 

while (num > Math.Pow(10, numLen))
{
    summ = summ + temp % 10;
    numLen++;
    temp = temp / 10;
    //Console.WriteLine($"Сумма чисел равна {summ} {numLen} {temp}");    
}
Console.WriteLine($"Сумма чисел равна {summ}");