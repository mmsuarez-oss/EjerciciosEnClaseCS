//Leer 5 edades y mostrar la edad promedio

int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for( int i = 0; i < edades.Length; i++)
{
    try
    {
         Console.WriteLine("Dime la edad " + (i + 1) + ":");
         edades[i] = int.Parse(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
        i--; // para volver a pedir la misma pisicion
    }
    Console.WriteLine("Dime la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine());
    suma += edades[i];
}
foreach (int edad in edades)
{
   suma += edad;
}
promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);