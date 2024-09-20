namespace Library_UML
{

    public class LoanedItem
    {

        //Fick inte koden att fungera ordentligt

        //public string Title;
        //public string Creator;
        //public string Id;
        //public string ExpirationDate;


        //public LoanedItem() { }
        //public LoanedItem(string Title, string Creator, string Id, string ExpirationDate)
        //{ 
        //    this.Title = Title;
        //    this.Creator = Creator; 
        //    this.Id = Id;
        //    this.ExpirationDate = ExpirationDate;
        //}
    }


    public class Book(string Title, string Creator, string Id, string ExpirationDate, int Pages) : LoanedItem
    {
        int Pages = Pages;
    }


    public class Movie(string Title, string Creator, string Id, string ExpirationDate, int Length) : LoanedItem
    {
        int Length = Length;
    }


    public class Magazine(string Title, string Creator, string Id, string ExpirationDate, string TypeOf) : LoanedItem
    {
        string Type = TypeOf;
    }

}
