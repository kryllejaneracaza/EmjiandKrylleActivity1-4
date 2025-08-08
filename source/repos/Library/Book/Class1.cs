namespace Book1
{
    public class Book
    {
        // Private fields
        private string title;
        private string author;
        private int yearPublished;
        private string genre;

        // Constructor 1: No information
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            yearPublished = 0;
            genre = "Unknown";
        }

        // Constructor 2: Basic information (title, author)
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            yearPublished = 0;
            genre = "Unknown";
        }

        // Constructor 3: Detailed  information (title, author, yearPublished)
        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
            genre = "Unknown";
        }

        // Constructor 4: Complete information (title, author, yearPublished, genre)
        public Book(string title, string author, int yearPublished, string genre)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
            this.genre = genre;
        }

        // Method to display book info
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Year Published: {yearPublished}");
            Console.WriteLine($"Genre: {genre}");
        }
    }

}

