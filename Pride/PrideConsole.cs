using System;

namespace Pride
{
    public class PrideConsole
    {
        public static readonly ConsoleColor[] Rainbow = new ConsoleColor[]
        {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.DarkMagenta,
        };

        public static void WriteWords(string input, string finalNewline = null)
        {
            var words = input.Split();
            int colorIndex = 0;
            int wordCount = 0;
            var oldBackground = Console.BackgroundColor;
            var oldForeground = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.White;
            foreach (var word in words)
            {
                wordCount++;
                Console.ForegroundColor = Rainbow[colorIndex];
                Console.Write(word);
                if (wordCount < words.Length)
                {
                    Console.Write(" ");
                }
                colorIndex = (colorIndex+1) % (Rainbow.Length-1);
            }
            if (!string.IsNullOrWhiteSpace(finalNewline))
            {
                Console.Write(finalNewline);
            }
            Console.BackgroundColor = oldBackground;
            Console.ForegroundColor = oldForeground;
        }
    }
}
