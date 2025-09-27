using System;
using System.Text;

class Program
{
    static void Main()
    {
        
        StringBuilder report = new StringBuilder();

      
        report.AppendLine("=== Text report ===");
        report.AppendLine("Date: " + DateTime.Now.ToShortDateString());
        report.AppendLine("List of events:");

        while (true)
        {
            Console.Write("Enter the event (or 'exit' to complete): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            report.AppendLine("- " + input);
        }

        
        Console.WriteLine("\nYour report:");
        Console.WriteLine(report.ToString());
    }
}
