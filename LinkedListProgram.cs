using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace consol_practise_app
{
    public class LinkedListProgram
    {
        static Node head = null;
        class Node
        {
            public int data;
            public Node next;
        }
        public void linklistmain()
        {
            int choice = 0;

            while (choice != 9)
            {
                Console.WriteLine("\n********* Main Menu *********");
                Console.WriteLine("1. Insert in beginning");
                Console.WriteLine("2. Insert at last");
                Console.WriteLine("3. Insert at any location");
                Console.WriteLine("4. Delete from beginning");
                Console.WriteLine("5. Delete from last");
                Console.WriteLine("6. Delete at any location");
                Console.WriteLine("7. Search");
                Console.WriteLine("8. Display");
                Console.WriteLine("9. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: BeginInsert(); break;
                    case 2: LastInsert(); break;
                    case 3: RandomInsert(); break;
                    case 4: BeginDelete(); break;
                    case 5: LastDelete(); break;
                    case 6: RandomDelete(); break;
                    case 7: Search(); break;
                    case 8: Display(); break;
                    case 9: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        // Insert at beginning
        static void BeginInsert()
        {
            Node newNode = new Node();

            Console.Write("Enter value: ");
            newNode.data = int.Parse(Console.ReadLine());

            newNode.next = head;
            head = newNode;

            Console.WriteLine("Node inserted at beginning");
        }

        // Insert at last
        static void LastInsert()
        {
            Node newNode = new Node();
            Console.Write("Enter value: ");
            newNode.data = int.Parse(Console.ReadLine());
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
            Console.WriteLine("Node inserted at last");
        }

        // Insert at any location
        static void RandomInsert()
        {
            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Enter position after which insert: ");
            int loc = int.Parse(Console.ReadLine());

            Node newNode = new Node();
            newNode.data = value;

            Node temp = head;
            for (int i = 0; i < loc; i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Can't insert");
                    return;
                }
                temp = temp.next;
            }

            newNode.next = temp.next;
            temp.next = newNode;

            Console.WriteLine("Node inserted");
        }

        // Delete from beginning
        static void BeginDelete()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            head = head.next;
            Console.WriteLine("Node deleted from beginning");
        }

        // Delete from last
        static void LastDelete()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.next == null)
            {
                head = null;
                Console.WriteLine("Only node deleted");
                return;
            }

            Node ptr = head;
            Node prev = null;

            while (ptr.next != null)
            {
                prev = ptr;
                ptr = ptr.next;
            }

            prev.next = null;
            Console.WriteLine("Node deleted from last");
            Console.WriteLine("Gir test from mdjohircw");
        }

        // Delete at any location
        static void RandomDelete()
        {
            Console.Write("Enter location: ");
            int loc = int.Parse(Console.ReadLine());

            Node ptr = head;
            Node prev = null;

            for (int i = 0; i < loc; i++)
            {
                if (ptr == null)
                {
                    Console.WriteLine("Can't delete");
                    return;
                }
                prev = ptr;
                ptr = ptr.next;
            }

            prev.next = ptr.next;
            Console.WriteLine("Node deleted");
        }

        // Search element
        static void Search()
        {
            Console.Write("Enter value to search: ");
            int item = int.Parse(Console.ReadLine());

            Node ptr = head;
            int pos = 1;
            bool found = false;

            while (ptr != null)
            {
                if (ptr.data == item)
                {
                    Console.WriteLine($"Item found at position {pos}");
                    found = true;
                    break;
                }
                ptr = ptr.next;
                pos++;
            }

            if (!found)
                Console.WriteLine("Item not found");
        }

        // Display list
        static void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node ptr = head;
            Console.Write("List: ");
            while (ptr != null)
            {
                Console.Write(ptr.data + " -> ");
                ptr = ptr.next;
            }
            Console.WriteLine("null");
        }
    }
}
