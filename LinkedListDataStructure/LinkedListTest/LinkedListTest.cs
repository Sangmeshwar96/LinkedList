using LinkedListDataStructure;
using System.Collections.Generic;

namespace LinkedListTest
{
    public class LinkedListTest
    {
        public LinkedList linkedList = new LinkedList();
        [Test]
        public void SearchElement_WhenFound_ShouldReturnNode()
        {
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(70);
            int search = linkedList.SearchValue(30);
            Assert.AreEqual(1, search);
        }
    }
}