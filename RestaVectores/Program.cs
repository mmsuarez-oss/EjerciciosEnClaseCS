int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] restaVector = new int[5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i=0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; 
        Console.ResetColor();
    }
}
Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i=0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; 
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La resta de los vectores es:");
for(int i=0; i < restaVector.Length; i++)
{
 restaVector[i] = vector1[i] - vector2[i];
}
Console.ResetColor();

for (int i = 0; i < restaVector.Length; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {restaVector[i]}");
}
