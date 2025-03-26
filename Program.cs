using System;

class Program
{
    static void Main()
    {
        Library library = new Library();

        // Adding Books
        library.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        library.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        library.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

        // Adding Patrons
        Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
        Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

        library.AddPatron(student1);
        library.AddPatron(student2);
        library.AddPatron(staff1);

        // Display Initial State
        library.DisplayBooks();
        library.DisplayPatrons();

        // Borrowing Books
        Console.WriteLine("Borrowing Books...");
        if (library.Books[1].BorrowBook())
            Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
        if (library.Books[2].BorrowBook())
            Console.WriteLine("Akhil borrowed 'Analytics in Action'");
        Console.WriteLine();

        // Display Updated Books
        library.DisplayBooks();
    }
}
