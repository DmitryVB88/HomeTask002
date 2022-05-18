// Найти расстояние между точками в пространстве 2D / 3D.
Console.WriteLine("Введите координаты 3-х точек по осям X, Y и Z. ");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine()?? "");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine()?? "");
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine()?? "");
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine()?? "");
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine()?? "");
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine()?? "");

if(z1 == 0 && z2 == 0)
{
    int a = (x2 - x1);
    int b = (y2 - y1);
    int mult = (a * a) + (b * b);
    // Console.WriteLine(mult);
    double d2 = (double)Math.Sqrt(mult);
    Console.WriteLine($"Расстояние между точками в 2-хмерном пространстве составляет = {d2}");
}
else
{
    int a = (x2 - x1);
    int b = (y2 - y1);
    int c = (z2 - z1);
    int product = (a * a) + (b * b) + (c * c);
    // Console.WriteLine(product);
    double d3 = (double)Math.Sqrt(product);
    Console.WriteLine($"Расстояние между точками в 3-хмерном пространстве составляет = {d3}"); 
}