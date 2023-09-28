//Ejercicio 1

Console.WriteLine(@"Utilizando la constante matemática de PI: Math.PI utilizar ese valor para hacer los
siguientes cálculos utilizando las funciones en C# y mostrarlas en consola.
1- Truncar el valor de PI
2- Redondear hacia arriba
3- Redondear hacia abajo");

double Pi = Math.PI;
double truncate = Math.Truncate(Pi);
Console.WriteLine($"\nValor de PI truncado: " + truncate);
Console.WriteLine();// espacio
double ceiling = Math.Ceiling(Pi);
Console.WriteLine($"Valor de PI redondeado hacia arriba: " + ceiling);
Console.WriteLine();//espacio
double floor = Math.Floor(Pi);
Console.WriteLine($"Valor de PI redondeado hacia abajo: " + floor);