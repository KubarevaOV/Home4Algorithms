Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

var result = Math.Pow(a,b);
Console.WriteLine("Результат = {0}", result);