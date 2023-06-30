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

            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            linkedList.Display();
        }
    }
}