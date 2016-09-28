using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection, theValue;

            CircularLinkedList list = new CircularLinkedList();
            list.CreateList();

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("[1] Display List");
                Console.WriteLine("[2] Insert at the beginning");
                Console.WriteLine("[3] Insert at the end");
                Console.WriteLine("[4] Insert after a node");
                Console.WriteLine("[5] Delete first node");
                Console.WriteLine("[6] Delete last node");
                Console.WriteLine("[7] Delete specific node");
                Console.WriteLine("[8] Exit Application");
                Console.Write("Enter Choice: ");
                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 8)
                    break;

                switch(selection)
                {
                    case 1:
                        Console.Write("List: ");
                        list.PrintList();
                        break;
                    case 2:
                        Console.Write("Enter the value to insert: ");
                        list.InsertAtBeginning(ReadInt());
                        break;
                    case 3:
                        Console.Write("Enter the value to insert: ");
                        list.InsertAtEnd(ReadInt());
                        break;
                    case 4:
                        Console.Write("Enter the value to insert: ");
                        theValue = ReadInt();
                        Console.Write("Enter the node to insert after: ");
                        list.InsertAfter(theValue, ReadInt());
                        break;
                    case 5:
                        list.DeleteFirst();
                        break;
                    case 6:
                        list.DeleteLast();
                        break;
                    case 7:
                        Console.Write("Enter the node to delete: ");
                        list.DeleteNode(ReadInt());
                        break;
                    default:
                        Console.WriteLine("Please enter a choice from the menu");
                        break;
                }
            }

        }

        // quick readline to int function
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
