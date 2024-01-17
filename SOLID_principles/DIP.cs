using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //this class implements DIP. DIP is:
    //"Depend upon abstractions, not concretes."
    //in other words: Abstractions should not depend on details. Details must depend on abstractions.
    //This helps by relegating the underlying logic to an abstraction level. Which allows you to add specific
    //implementations after without affecting all other implementations.
    
    //For example, here a book can be printed in any way defined through the IPrinter interface. If desired, you
    //can add any other method, without affecting the book itself, to describe its actual implementation: in a PDF
    //file, on paper, etc. If this principle were violated, it would be necessary to describe printing methods in the
    //book itself.
    interface IPrinter
    {
        void Print(string text);
    }

    class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public Book(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("print to console");
        }
    }

    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("print to html");
        }
    }
}
