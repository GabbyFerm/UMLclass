namespace UMLclass
{

    public class Member
    {
        // Private attributes
        private int MemberID { get; set; }
        private string Name { get; set; }

        // Public property to access the private Name attribute
        public string NamePublic
        {
            get { return Name; }
        }

        // Public constructor to initialize Member class
        public Member(int memberID, string name)
        {
            MemberID = memberID;
            Name = name;
        }

        // Public method to show member information
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}, Name: {Name}");
        }
    }
}



