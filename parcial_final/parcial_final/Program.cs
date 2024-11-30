public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de filas (N):");
        int filas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de columnas (M):");
        int columnas = int.Parse(Console.ReadLine());

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números aleatorios
        Random random = new Random();
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(1, 10); // Números aleatorios entre 1 y 9
            }
        }

        // Imprimir la matriz
        Console.WriteLine("La matriz generada es:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Presiona Esc para salir.");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
 }
