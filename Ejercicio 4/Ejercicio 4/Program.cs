
//Ejercicio 4
Console.WriteLine(@"Aplicar las funciones matemáticas vistas en clases para la codificación de un
programa que calcule las raíces de una ecuación de segundo grado utilizando la
fórmula cuadrática. El usuario deberá ingresar los valores de las constantes a, b y c
para resolver las raíces.
");


Console.WriteLine("\nCálculo de raíces de una ecuación de segundo grado (ax^2 + bx + c = 0)");

Console.Write("Ingrese el valor de a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de c: ");
double c = Convert.ToDouble(Console.ReadLine());

double Discriminante = Math.Pow(b, 2) - 4 * a * c;

if (Discriminante > 0)
{
    double R1 = (-b + Math.Sqrt(Discriminante)) / (2 * a);
    double R2 = (-b - Math.Sqrt(Discriminante)) / (2 * a);
    Console.WriteLine($"Las raíces son: {R1} y {R2}");
}
else if (Discriminante == 0)
{
    double raiz = -b / (2 * a);
    Console.WriteLine($"La raíz doble es: {raiz}");
}
else
{
    double RP = -b / (2 * a);
    double IP = Math.Sqrt(-Discriminante) / (2 * a);
    Console.WriteLine($"Las raíces son complejas: {RP} + {IP}i y {RP} - {IP}i");
}






