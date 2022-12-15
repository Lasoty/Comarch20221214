using System;

namespace ComarchCwiczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comarch Cwiczenia");

            Console.WriteLine("MENU: ");
            Console.WriteLine(" 1. Sortowanie");

            if (int.TryParse(Console.ReadLine(), out int wybor))
            {
                switch (wybor)
                {
                    case 1:
                        Sortowanie();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wprowadzona wartość jest poza zakresem.");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadzona wartość jest nieprawidłowa.");
                Console.ResetColor();
            }
        }

        private static void Sortowanie()
        {
            Console.Clear();
            Console.Write("Podaj liczby rozdzielone spacją: ");
            string[] sLiczby = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] liczby = new int[sLiczby.Length];
            int i = 0;
            foreach (var item in sLiczby)
            {
                liczby[i] = int.Parse(item);
                i++;
            }

            int n = liczby.Length;

            for (i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        int tmp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Posortowane wartości: " + string.Join(", ", liczby));

            Console.ReadLine();
        }
    }
}