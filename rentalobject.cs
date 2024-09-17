
namespace UMLclass
{
    
    public class RentalObject
    {
        public string Title;
        public int Identifier;
        public string Rentaltime;

        public void DisplayObjectName()
        {
            Console.WriteLine("Display object name");
        }
    }


    // Book Subclass
    public class Book : RentalObject
    {
        public string Author;

        public void DisplayBookTitle() 
        { 
            Console.WriteLine("The Hitchhiker's Guide to the Galaxy");
        }
    }

    // Newspaper Subclass
    public class Newspaper : RentalObject
    {
        public string PublishedDate;

        public void DisplayNewspaperTitle()
        {
            Console.WriteLine("The New York Times");
        }
    }

    // DVD Subclass
    public class DVD : RentalObject
    {
        public string Director;

        public void DisplayDvdTitle()
        {
            Console.WriteLine("A Clockwork Orange");
        }
    }
}
