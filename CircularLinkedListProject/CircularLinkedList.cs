using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        // Create a list with the specified values
        public void CreateList()
        {
            int i, n, theValue;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                theValue = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(theValue);
            }
        }

        // print the values in the list from first to last
        public void PrintList()
        {
            // if list is empty
            if (last == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }

            // else iterate and print
            Node p = last.link;
            do
            {
                Console.Write(p.value + " ");
                p = p.link;
            } while (p != last.link);
            Console.WriteLine();
        }

        // Insert at the beginning
        public void InsertAtBeginning(int theValue)
        {

            Node temp = new Node(theValue);

            // if no nodes exist
            if (last == null)
            {
                last = temp;
                last.link = last;
                return;
            }

            temp.link = last.link;
            last.link = temp;
        }

        // Insert at end
        public void InsertAtEnd(int theValue)
        {
            InsertAtBeginning(theValue);
            if (last.link != null)
                last = last.link;
        }

        // Finds the node specified in the argument. Else returns null
        public Node FindNode(int theValue)
        {
            Node p = last.link;
            do
            {
                if (p.value == theValue)
                    break;
                p = p.link;
            } while (p != last.link);
            return (p.value == theValue) ? p : null;
        }

        // Insert after specified node
        public void InsertAfter(int theValue, int theNode)
        {
            // find node "theNode"
            Node p = FindNode(theNode);

            // if node not found
            if (p == null)
                Console.WriteLine(theNode + " was not found in the list");

            // if node found
            else
            {
                Node temp = new Node(theValue);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;
            }
        }

        // Delete first node
        public void DeleteFirst()
        {
            // if empty
            if (last == null)
                return;

            // if only one node
            if (last.link == last)
                last = null;

            else
                last.link = last.link.link;
        }

        // Delete last node
        public void DeleteLast()
        {
            // if empty
            if (last == null)
                return;

            // if only one node
            if (last.link == last)
            {
                last = null;
                return;
            }

            // find second to last and delete next
            Node p = last;
            do p = p.link;
            while (p.link != last);
            last = p;
            last.link = last.link.link;
        }

        // Delete specific node
        public void DeleteNode(int theNode)
        {
            // If there are no nodes
            if (last == null)
                return;

            // If we are deleting the last remaining node
            if (last.link == last && last.value == theNode)
            {
                last = null;
                return;
            }

            // find node before the one we are looking for
            Node p = last;
            do
            {
                if (p.link.value == theNode)
                    break;
                p = p.link;
            } while (p.link != last.link);

            // if value not found
            if (p.link.value != theNode)
            {
                Console.WriteLine("Value not found");
                return;
            }

            // if we are deleting the last* value
            if (p.link == last)
                p = last;

            // else delete the node;
            else
                p.link = p.link.link;
        }

        // Concatenate another list
        public void Concatenate(CircularLinkedList list)
        {
            // if this list is empty
            if (last == null)
            {
                last = list.last;
                return;
            }

            // if other list is empty
            if (list.last == null)
                return;

            // else concatenate
            Node p = last.link;
            last.link = list.last.link;
            list.last.link = p;
            last = list.last;
        }

    }
}
