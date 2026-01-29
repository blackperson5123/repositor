int a;
int b;
int ans;
double ans2;
string sign;


Console.WriteLine("Введите знак");
sign = Console.ReadLine();




if (sign == "-")
{
    Console.WriteLine("Вычитание: Введите 1 и второе число")
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());


    ans = a - b;
    Console.WriteLine(ans);
}

if (sign == "+")
{
    Console.WriteLine("Сложение: Введите 1 и второе число")
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());


    ans = a + b;
    Console.WriteLine(ans);
}

if (sign == "/")
{
    Console.WriteLine("Деление: Введите 1 и 2 число ")
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    if(a == 0)
    {
        Console.WriteLine("Не может быть нулем, введите заного")
        a = int.Parse(Console.ReadLine());
    }
    if (b == 0)
    {
        Console.WriteLine("Не может быть нулем, введите заного")
        b = int.Parse(Console.ReadLine());
    }
    ans2 = a / b;
    Console.WriteLine(ans2);
}