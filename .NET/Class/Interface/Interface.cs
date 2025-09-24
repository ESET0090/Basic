using System;

namespace Interface
{
    // Printer interface - defines what all printers must do
    public interface IPrinter
    {
        void Print(string document);
        string GetStatus();
    }
}