// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Ввиду того, что написано "Напишите цикл", будем решать через цикл, а не через math.pow

int ReadData (string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine()??"");
return number;
}


int a = ReadData("Введите основание: ");
int b = ReadData("Введите степень: ");
int temp = a;

for (int i = 1; i < b; i++)
{
    a = (temp * a);    
}

Console.WriteLine($"{temp} в степени {b} равно {a}");