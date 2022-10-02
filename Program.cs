const double a = 0.0; //а - начало интервала
const double b = 1.0; //b - конец интервала
const double h1 = 0.2; //h - первый шаг интегрирования
const double h2 = 0.1; //h - второй шаг интегрирования
var y = -0.5; // начальное условие
var ya = Fa(a);

Console.WriteLine($"Шаг: {h1}");
Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "x", "Точное", "Аналитическое");
for (var x = a; x <= b + 1e-10; x += h1) // метод Эйлера
{
    y += h1 * F(x, y);
    ya = Fa(x);
    Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", x.ToString("0.0"), y, ya);
}

y = -0.5; // начальное условие
ya = Fa(a);
Console.WriteLine($"\nШаг: {h2}");
Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "x", "Точное", "Аналитическое");
for (var x = a; x <= b + 1e-10; x += h2) // метод Эйлера
{
    y += h2 * F(x, y);
    ya = Fa(x);
    Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", x.ToString("0.0"), y, ya);
}

double F(double x, double y) // правая часть
{
    return -4 * Math.Pow(x, 3) - 4 * x * y; // -4x^3 - 4xy
}

double Fa(double x) // аналитическое решение
{
    return Math.Pow(-x, 2) + 0.5 - Math.Exp(-2 * Math.Pow(x, 2)); // -x^2 + 0.5 - e^(-2x^2)
}
