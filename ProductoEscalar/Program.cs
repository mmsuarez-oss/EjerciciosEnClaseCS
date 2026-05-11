int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] multiplicaciones = new int[5];

int productoEscalar = 0;

Console.WriteLine("Ingrese los elementos del vector 1");

for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento vector 1 - {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--;
    }
}

Console.WriteLine("\nIngrese los elementos del vector 2");

for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Elemento vector 2 - {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--;
    }
}

for (int i = 0; i < vector1.Length; i++)
{
    multiplicaciones[i] = vector1[i] * vector2[i];
    productoEscalar += multiplicaciones[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nMultiplicaciones por posición:");

for (int i = 0; i < multiplicaciones.Length; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {vector1[i]} * {vector2[i]} = {multiplicaciones[i]}");
}

Console.WriteLine($"\nEl producto escalar total es: {productoEscalar}");
Console.ResetColor();