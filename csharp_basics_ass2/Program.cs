namespace csharp_basics_ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable) Console.WriteLine("You can borrow this book.");
            Console.WriteLine();

            //------------------------------

            //Q2
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            Console.WriteLine();

            //------------------------------

            //Q3
            int pagess = 464;
            string sizeLabel = pagess > 300 ? "Long Book" : "Small Book";
            Console.WriteLine();

            //------------------------------

            //Q4
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int j = 0; j < books.Length; j++)
            {
                Console.WriteLine($"Book: {books[j]} and position: {j + 1}");
            }
            Console.WriteLine();

            //------------------------------

            //Q5
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine($"Book: {books[i]} and position: {i + 1}");
                i++;
            }
            Console.WriteLine();

            //------------------------------

            //Q6
            int cnt = 0;
            do
            {
                Console.WriteLine("Checking book...");
                cnt++;
            }
            while (cnt < 3);
            Console.WriteLine();

            //------------------------------

            //Q7
            foreach (string book in books)
            {
                Console.WriteLine("Book title: " + book);
            }
            Console.WriteLine();

            //------------------------------

            //Q8
            for (int k = 0; k < books.Length; k++)
            {
                if (books[k] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[k]);
            }
            Console.WriteLine();

            //------------------------------
        }
    }
}
