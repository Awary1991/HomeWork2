Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());
while (a >= 1000)
    {
        a = a / 10;
    }
    if (a < 100)
    {
        Console.WriteLine("Не верное число");
    }
    else 
    {
        a = a % 10;
        Console.WriteLine(a);
    }
