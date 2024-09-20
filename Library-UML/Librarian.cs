namespace Library_UML
{
    public class Librarian
    {

        private string inputName;

        public Librarian(string inputName)
        {
            Name = inputName;
        }

        public string Name
        {
            get { return inputName; }
            set { inputName = value; }
        }

        public void Lend()
        {
            Console.WriteLine(Name + " lånade ut föremålet till kunden");
        }

        public void Return()
        {
            Console.WriteLine(Name + " tog tillbaka föremålet ifrån kunden.");
        }

        public void GiveTicket()
        {
            Console.WriteLine(Name + " gav kunden en böter.");
        }

    }
}
