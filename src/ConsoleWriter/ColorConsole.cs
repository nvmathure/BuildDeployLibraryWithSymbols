using System;

namespace ConsoleWriter
{
    public class ColorConsole
    {
        public void Write(string value, ConsoleColor foregroundColor = default, ConsoleColor backgroundColor = default)
        {
            var originalForegroundColor = Console.ForegroundColor;
            var originalBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = foregroundColor != default ? foregroundColor : originalForegroundColor;
            Console.BackgroundColor = backgroundColor != default ? backgroundColor : originalBackgroundColor;
            Console.WriteLine(value);
            Console.ForegroundColor = originalForegroundColor;
            Console.BackgroundColor = originalBackgroundColor;
        }
    }
}
