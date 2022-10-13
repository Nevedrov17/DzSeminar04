Console.Clear();

double Pow (int a, int b)
{
   double res =  Math.Pow(a,b);
   return res;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( Pow(a,b));






