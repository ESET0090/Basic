using System;

namespace Interface
{
    // Laser printer implementation
    public class LaserPrinter : IPrinter
    {
        private string _name;

        public LaserPrinter(string name)
        {
            _name = name;
        }

        public void Print(string document)
        {
            Console.WriteLine($"⚡ {_name} is LASER printing: {document}");
        }

        public string GetStatus()
        {
            return $"{_name} - Laser ready";
        }
    }
}