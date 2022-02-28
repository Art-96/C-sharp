using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Contract";

            Body body = new Body();
            body.Content = "Contract body ...";

            Footer footer = new Footer();
            footer.Content = "Director: Ivanov I.I.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay
            Console.ReadKey();
        }
    }
}
