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
            Console.WriteLine(" 2. Dodawanie");
            Console.WriteLine(" 3. Odejmowanie");
            Console.WriteLine(" 4. Mnożenie");
            Console.WriteLine(" 5. Dzielenie");
            Console.WriteLine(" 6. Reszta z dzielenia");

            Console.Write("Twój wybór: ");

            if (int.TryParse(Console.ReadLine(), out int wybor))
            {
                int x, y;
                Calculator calc = new Calculator();

                switch (wybor)
                {
                    case 1:
                        Sortowanie();
                        break;
                    case 2:
                        PobierzLiczby(out x, out y);
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {calc.Add(x , y) }");
                        break;
                    case 3:
                        PobierzLiczby(out x, out y);
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {calc.Subtract(x, y)}");
                        break;
                    case 4:
                        PobierzLiczby(out x, out y);
                        Console.WriteLine($"Wynik mnożenia {x} oraz {y} to {calc.Multiply(x, y)}");
                        break;
                    case 5:
                        PobierzLiczby(out x, out y);
                        Console.WriteLine($"Wynik dzielenia {x} oraz {y} to {calc.Dividy(x, y)}");
                        break;
                    case 6:
                        PobierzLiczby(out x, out y);
                        Console.WriteLine($"Wynik reszty z dzielenia {x} oraz {y} to {calc.Modulo(x, y)}");
                        break;
                    default:
                        ShowError("Wprowadzona wartość jest poza zakresem.");
                        break;
                }
            }
            else
            {
                ShowError("Wprowadzona wartość jest nieprawidłowa.");
            }
        }

        private static void PobierzLiczby(out int x, out int y)
        {
            Console.Clear();
            Console.Write("Podaj wartość parametru X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj wartość parametru Y: ");
            y = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Wyświetl błąd w konsoli.
        /// </summary>
        /// <param name="message">Wiadomość do wyświetlenia.</param>
        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
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