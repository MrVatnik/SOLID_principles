using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP //Single Responsibility Principle
{
    //this class implements SRP. SRP is: "A module should be responsible to one, and only one, actor."
    //The essence of the principle is that a class/structure/method should perform one single task.
    //All functionality of the component must be integral and have high cohesion.
    //This principle is necessary when it is necessary to change the program.
    //In the case where it is not applied, changes in one object may lead to changes in another, and so on.
    //Once it is applied, all changes that need to be made are minimized.
    //For example, here, if you need to add a new report output method, you can easily add it to the Printer class, without changing anything, even other methods in Printer class.
    class Report
    {
        public string Text { get; set; } = "";
        public void GoToFirstPage() =>
            Console.WriteLine("Go to first page");

        public void GoToLastPage() =>
            Console.WriteLine("Go to last page");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Go to page {pageNumber}");
    }


    //  responsible for Report printing
    class Printer
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine("Printing report");
            Console.WriteLine(report.Text);
        }
    }
}
