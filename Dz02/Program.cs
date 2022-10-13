Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = 0;
int sum = 0;
int f = 0;
while(c < a)
{
    f = a%10;
    sum = f + sum;
    a = a/10;
}

Console.WriteLine($"Сумма чисел = {sum}");