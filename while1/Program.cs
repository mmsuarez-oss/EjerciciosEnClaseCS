int numero;

while (true)
{
    Console.WriteLine("Ingrese un numero entero:");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
       Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            Console.ResetColor();
   }
}

Console.WriteLine("Mostrando el cuadrado de los antecesores de " + numero + ":");
int cont = 1;
while (cont < numero)
{
    Console.WriteLine("El cuadrado de " + cont + " es: " + Math.Pow(cont, 2));
    cont++;
}