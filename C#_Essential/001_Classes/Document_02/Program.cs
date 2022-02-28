using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Contract");
            document.Body = "Body contract...";
            document.Footer = "Director: Ivanov I. I.";

            document.Show();

            // Delay
            Console.ReadKey();
        }
    }
}
