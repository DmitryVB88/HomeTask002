//Выяснить, является ли первое число, квадратом второго.
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите второе чило: ");
int b = int.Parse(Console.ReadLine() ?? "");
if(a == b * b)
 {
     Console.WriteLine($"Поздравляю, число {a} является квадратом числа {b}!");

 }
 else
 {
     Console.WriteLine($"Увы, число {a} не является квадратом числа {b}.");
 }