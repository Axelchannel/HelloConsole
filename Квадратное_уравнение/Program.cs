double a;
double b;
double c;
double x1=0;
double x2=0;


Console.WriteLine("Решение квадратного уравнения");
Console.WriteLine("Введите коэффициенты квадратного уравнения: ");
Console.Write("a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Квадратное уравние: ");
Console.WriteLine($"{a}x^2+{b}*x+{c}=0");
Console.WriteLine("Надём дискриминант");
double D=(b*b-4*a*c);
Console.Write("Дискриминант D=");
Console.WriteLine(D);
Console.WriteLine("Надём корни уравнения");



if (D < 0)
{
    Console.WriteLine("Квадратное уравнение не имеет корней");
}
else
{
    if (D == 0) //квадратное уравнение имеет два одинаковых корня
    {
        x1 = -b / (2 * a);
        x2 = x1;
    }
    else //уравнение имеет два разных корня
    {
        x1 = (-b + Math.Sqrt(D)) / (2 * a);
        x2 = (-b - Math.Sqrt(D)) / (2 * a);
    }
}            
Console.WriteLine("Корни уравнения:");

Console.WriteLine($"x1={x1}; x2={x2}");
