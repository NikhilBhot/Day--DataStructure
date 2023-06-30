using LinkList;
namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
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