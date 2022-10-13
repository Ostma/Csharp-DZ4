// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// ввод элеменетов через консоль (через запятую. использовать метод string.Split())


Console.WriteLine("Введите 8 цифр, разделяя их запятыми: ");
string array = Console.ReadLine();

string[] massiv = array.Split(",");

if (massiv.Length == 8)
{
    for (int i = 0; i < massiv.Length; i++)
    Console.Write($"{massiv[i]} ");
}
else
Console.WriteLine("Вы ввели не восемь цифр");