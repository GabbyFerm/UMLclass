using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLclass
{
    public class Loan
    {
        public string RentalObject;
        public string Member;
        public int LoanDate;
        public int ReturnDate;



        public void LoanItem()
        {
            Console.WriteLine($"Loan created for {RentalObject} to {Member}");
        }

        public void ReturnItem()
        {
            Console.WriteLine($"Return loan for {RentalObject} from {Member}");
        }

    }

}
