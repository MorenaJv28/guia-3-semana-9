//Ejercicio 2

Console.WriteLine(@" Utilizando la constante matemática de E: Math.E conocido en ocasiones como
número de Euler o constante de Napier, utilizar ese valor para hacer los siguientes
cálculos utilizando las funciones en C# y mostrarlas en consola.

Redondear los valores decimales del número hasta la 10 posición");

double e = Math.E;
double round = Math.Round(e, 10);
Console.WriteLine($"\nEl valor de e redondeado a la decima posicion es: " + round);
Console.WriteLine();//espacio
Console.WriteLine("creado por Ing. Gutierrez");