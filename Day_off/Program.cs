//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите день недели, от 1 до 7: ");
int daynum = int.Parse(Console.ReadLine()?? "");
if(daynum == 1)
{
    Console.WriteLine("Monday - ещё работать и работать...");
}
else if(daynum == 2)
{
    Console.WriteLine("Tuesday - лёд тронулся");
}
else if(daynum == 3)
{
    Console.WriteLine("Wednesday - мы на середине недели");
}
else if(daynum == 4)
{
    Console.WriteLine("Thursday - почти пятница, но пока четверг");
}
else if(daynum == 5)
{
    Console.WriteLine("Friday - ну, еще денек и отдохнешь");
}
else if(daynum == 6)
{
    Console.WriteLine("Saturday - а вот и первый выходной");
}
else if(daynum == 7)
{
    Console.WriteLine("Sunday - еще один выходной,но завтра снова понедельник...");
}
else if(daynum < 1)
{
    Console.WriteLine("Кажется кто-то перетрудился. В неделе всего семь дней)))");
}
else if(daynum > 7)
{
    Console.WriteLine("Кажется кто-то перетрудился. В неделе всего семь дней)))");
}