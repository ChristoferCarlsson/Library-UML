namespace Library_UML
{
    internal class Library
    {
        public void Open()
        {
            Librarian LibrarianOne = new Librarian("Johan");
            LibrarianOne.Return();

            Customer Lars = new Customer("Lars");
            Lars.Loan();

            //We create a new book, movie, and magazine
            Book LoanedBook = new Book("A conmans purchase", "Jerry", "#ABBA", "2024-09-24", 239);
            Movie LoanedMovie = new Movie("The one with Nicolas Cage", "Mark Steven Johnson", "#ACDC", "2024-09-26", 90);
            Magazine LoanedMagazine = new Magazine("A ball for a foot", "Me", "#KIZZ", "2024-09-22", "Sport");
        }
    }
}
