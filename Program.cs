namespace TextVerktyg;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("=== Textverktyget ===");
            Console.WriteLine("1. Vänd på en text");
            Console.WriteLine("2. Räkna vokaler i en text");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Skriv en text: ");
                    string textToReverse = Console.ReadLine() ?? "";
                    Console.WriteLine($"Baklänges: {ReverseText(textToReverse)}");
                    break;

                case "2":
                    Console.Write("Skriv en text: ");
                    string textToCount = Console.ReadLine() ?? "";
                    Console.WriteLine($"Antal vokaler: {CountVowels(textToCount)}");
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("Hej då!");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }

    // Exempel: "Hej på dig" -> "gid åp jeH"
    static string ReverseText(string text)
    {
        char[] textChar;
        textChar = text.ToCharArray();
        string reversed = "";

        for (int i = textChar.Length - 1; i >= 0; i--)
        {
            reversed += textChar[i];
        }
        return reversed;
    }

    // Vokaler: a, e, i, o, u, y, å, ä, ö – både stora och små bokstäver räknas.
    // Exempel: "Hej på dig" -> 3
    static int CountVowels(string text)
    {
        char[] textChar;
        text = text.ToLower();
        textChar = text.ToCharArray();
        int count = 0;

        foreach (char character in textChar)
        {
            if ("aeiouyåäö".Contains(character))
            {
                count++;
            }
        }
        return count;
    }
}
