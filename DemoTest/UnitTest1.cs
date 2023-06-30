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
    }
}