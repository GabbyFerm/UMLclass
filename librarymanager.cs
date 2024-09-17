

using UMLclass;

public class Librarymanager
{
    public string Name;


    //method
    public void LoanItem()
    {
        Console.WriteLine("Lends item.");
    }

    public void ReturnItem()
    {
        Console.WriteLine("Recieve rented item.");
    }

    public void GiveFine()
    {
        Console.WriteLine("Gives fine for overdue rental time.");
    }
}
