using System;

namespace Interface
{
    // Basic printer implementation
    public class BasicPrinter : IPrinter
    {
        private string _name;

        public BasicPrinter(string name)
        {
            _name = name;
        }

        public void Print(string document)
        {
            Console.WriteLine($"🖨️ {_name} is printing: {document}");
        }

        public string GetStatus()
        {
            return $"{_name} - Ready";
        }
    }
}