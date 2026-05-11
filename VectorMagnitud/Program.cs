int[] vector = new int[5];
int[] magVector = new int[5];
int sumaVector = 0;
Console.WriteLine("Ingrese los elementos del vector");
for (int i = 0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número entero válido.");
        Console.ResetColor();
        i--; // Para repetir el mismo elemento si se equivoca
    }
}
for (int i = 0; i < vector.Length; i++)
{
    magVector[i] = vector[i] * vector[i];
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La magnitud de los vectores es:");
for (int i = 0; i < magVector.Length; i++)
{
    Console.WriteLine($"Magnitud del elemento {i + 1}: {magVector[i]}");
}
for (int i = 0; i < magVector.Length; i++)
{
    sumaVector += magVector[i];
}
double magnitudTotal = Math.Sqrt(sumaVector);
Console.WriteLine($"La suma de los cuadrados es: {sumaVector}");
Console.WriteLine($"La magnitud total del vector es: {magnitudTotal:F2}");
Console.ResetColor();