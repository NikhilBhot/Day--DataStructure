namespace LinkList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Lets create a simple Linked List of 56, 30 and 70
             */
            LinkedList linkedList = new LinkedList();

            linkedList.Add(70);

            /*Ability to create Linked List by adding 30 and 56 to 70

                - Node with data 70 is First Created
                - Next 30 is added to 70
                - Finally 56 is added to 30
                - LinkedList Sequence: 56->30->70
             */
            //linkedList.InsertAtBeginning(30);
            //linkedList.InsertAtBeginning(56);

            /*
             * Ability to create Linked
                List by appending 30 and
                70 to 56

                - Node with data 56 is First Created
                - Next Append 30 to 56
                - Finally Append 70 to 30
                - LinkedList Sequence: 56->30->70
             */
            linkedList.Add(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
        }
    }
}