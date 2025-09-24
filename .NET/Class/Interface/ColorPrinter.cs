using System;

namespace Interface
{
    // Color printer implementation
    public class ColorPrinter : IPrinter
    {
        private string _name;

        public ColorPrinter(string name)
        {
            _name = name;
        }

        public void Print(string document)
        {
            Console.WriteLine($"🎨 {_name} is printing in COLOR: {document}");
        }

        public string GetStatus()
        {
            return $"{_name} - Color mode ready";
        }
    }
}