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
            linkedList.InsertAtBeginning(30);
            linkedList.InsertAtBeginning(56);
            linkedList.Display();
        }
    }
}