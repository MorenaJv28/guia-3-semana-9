//Ejercicio 3

Console.WriteLine(@"Realice un programa que calcule la suma acumulada 
de los cuadrados de los primeros 20 dígitos.

Ejemplo suma = (1x1) + (2x2) + (3x3) + .. (18*18) + (19x19) + (20*20)");

 double sum = 0;

for (int i = 1; i <= 20; i++)
{
    sum += Math.Pow(i, 2);
}

Console.WriteLine($"\nEl resultado de la suma acumulada de los cuadrados de los primeros 20 números es: {sum}");
 
