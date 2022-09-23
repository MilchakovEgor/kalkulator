Console.WriteLine("Меню:\r\n" +
"1. Сложить 2 числа\r\n" +
"2.Вычесть первое из второго\r\n" +
"3.Перемножить два числа\r\n" +
"4.Разделить первое на второе\r\n" +
"5.Возвести в степень N первое число\r\n" +
"6.Найти квадратный корень из числа\r\n" +
"7.Найти 1 процент от числа\r\n" +
"8.Найти факториал из числа\r\n" +
"9.Выйти из программы\r\n");
bool client = true;

do
{
    Console.WriteLine("Введите номер опреации: ");
    int oper = Convert.ToInt32(Console.ReadLine());
    if (oper == 9)
    {
        client = false;
    }
    if (oper==1)
    {
        Console.WriteLine("Введите 1-ое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( B + A);
    }
    if(oper==2)
    {
        Console.WriteLine("Введите 1-ое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( B - A);
    }
    if(oper==3)
    {
        Console.WriteLine("Введите 1-ое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(A * B);
    }
    if(oper==4)
    {
        Console.WriteLine("Введите 1-ое число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(A / B);
    }
    if(oper==5)
    {
        Console.WriteLine("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа:");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(A, B));
    }
    if(oper==6)
    {
        Console.WriteLine("Введи число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(A));
    }
    if(oper==7)
    {
        Console.WriteLine("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((A / 100) * 1);
    }
    if(oper==8)
    {
        Console.Write("Введите число: ");
        int A = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= A; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
while (client==true);
{
    Console.WriteLine("Выход");
}