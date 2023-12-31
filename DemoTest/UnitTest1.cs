using LinkList;
namespace DemoTest
{
    /*Ability to search LinkedList to find Node with value 30

            - Write MSTest Test Case as demonstrated in class
            - Loop through LinkedList to find node with key 30
     */
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Search_NodeWithValue30_ReturnsNode()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            Node result = linkedList.Search(30);

            Assert.IsNotNull(result);
            Assert.AreEqual(30, result.Data);
        }

        [TestMethod]
        public void Search_NodeWithNonExistentValue_ReturnsNull()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            Node result = linkedList.Search(42);

            Assert.IsNull(result);
        }

        /*
         * Ability to insert 40 after 30 to the Linked List sequence of 56->30->70
            - Write MSTest Test Case as demonstrated in class
            - Search LinkedList to get Node with key value 30
            - Then Insert 40 to 30
            - Final Sequence: 56->30->40->70
         */
        [TestMethod]
        public void InsertAfter_InsertNodeWithValue40AfterNodeWithValue30()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            Node node30 = linkedList.Search(30);
            linkedList.InsertAfter(node30.Data, 40);

            Assert.AreEqual(56, linkedList.head.Data);
            Assert.AreEqual(30, linkedList.head.Next.Data);
            Assert.AreEqual(40, linkedList.head.Next.Next.Data);
            Assert.AreEqual(70, linkedList.head.Next.Next.Next.Data);
            Assert.IsNull(linkedList.head.Next.Next.Next.Next);
        }

        [TestMethod]
        public void InsertAfter_InsertNodeWithValue40AfterNodeWithValueNonExistent()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            Node node42 = linkedList.Search(42);
            linkedList.InsertAfter(node42?.Data ?? 0, 40);

            Assert.AreEqual(56, linkedList.head.Data);
            Assert.AreEqual(30, linkedList.head.Next.Data);
            Assert.AreEqual(70, linkedList.head.Next.Next.Data);
            Assert.IsNull(linkedList.head.Next.Next.Next);
        }


    }
}