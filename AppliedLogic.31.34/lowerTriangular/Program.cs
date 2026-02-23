using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

    if (n <= 0)
    {
        Console.WriteLine("El orden debe ser mayor que cero.");
        continue;
    }

    int[,] matrix = new int[n, n];

    // Llenar matriz
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
        }
    }

    Console.WriteLine("\nMatriz completa:\n");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nTriangular inferior:\n");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions(
            "\n¿Deseas continuar [S]í, [N]o?: ",
            options
        );
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over.");
