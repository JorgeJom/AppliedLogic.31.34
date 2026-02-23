using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

    if (n <= 0 || n % 2 == 0)
    {
        Console.WriteLine("El orden debe ser un número impar mayor que cero.");
        continue;
    }

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = 2 * i + j;
        }
    }

    Console.WriteLine("MATRIZ COMPLETA");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }

    Console.WriteLine("RELOJ DE ARENA");

    int mitad = n / 2;
    int width = 4;

    for (int i = 0; i < n; i++)
    {
        int colInicio, colFin;

        if (i <= mitad)
        {
            colInicio = i;
            colFin = n - 1 - i;
        }
        else
        {
            colInicio = n - 1 - i;
            colFin = i;
        }

        int espacios = colInicio * width;
        Console.Write(new string(' ', espacios));

        for (int j = colInicio; j <= colFin; j++)
        {
            Console.Write(matrix[i, j].ToString().PadLeft(width));
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