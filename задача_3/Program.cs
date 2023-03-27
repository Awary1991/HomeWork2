Console.WriteLine("Введите цифру дня");

int a = int.Parse(Console.ReadLine());

if (a > 0 & a < 6)
    {
        Console.Write("Не выходной");
    }

if (a > 5 & a < 8)
    {
        Console.Write("Выходной");
    }

if (a < 0)
    {
        Console.Write("Не верная цифра дня");
    }

if (a > 7)
    {
        Console.Write("Не верная цифра дня");
    }