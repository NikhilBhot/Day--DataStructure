using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        /*
             * Lets create a simple Linked List of 56, 30 and 70
         */
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        /*
         * Ability to create Linked
                List by appending 30 and
                70 to 56

                - Node with data 56 is First Created
                - Next Append 30 to 56
                - Finally Append 70 to 30
                - LinkedList Sequence: 56->30->70
         */
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        /*Ability to insert 30 between 56 and 70
            - Final Sequence: 56->30->70
         */
        public void InsertAfter(int value, int data)
        {
            Node newNode = new Node(data);
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }
    }
}
