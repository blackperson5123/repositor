int a;
int b;
int ans;
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