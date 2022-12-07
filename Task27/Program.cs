Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

var sum = 0;

do {
    var number = a % 10;
    sum = sum + number;

    a = a / 10;
} while (a > 1);

Console.WriteLine("Сумма цифр в числе равна: {0}", sum);