using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tests a basic linked list 0-10 no cycles
            LinkedListNode testCase1 = new LinkedListNode(0);
            LinkedListNode ptr = testCase1;
            for (int i = 1; i <= 10; i++)
            {
                // Instantiate the next node
                ptr.Next = new LinkedListNode(0); // Note that value doesn't matter
                // Move to the next node
                ptr = ptr.Next;
            }

            // Test a single node linked list
            LinkedListNode testCase2 = new LinkedListNode(0);

            // Tests a single node linked list with a cycle
            LinkedListNode testCase3 = new LinkedListNode(0);
            testCase3.Next = testCase3;
            
            // Tests a linked list with a cycle in the middle
            LinkedListNode testCase4 = new LinkedListNode(0);
            ptr = testCase4;
            for (int i = 1; i <= 10; i++)
            {
                // Instantiate the next node
                ptr.Next = new LinkedListNode(0); // Note that value doesn't matter
                // Move to the next node
                ptr = ptr.Next;
            }
            ptr = testCase4;
            for (int i = 1; i <= 5; i++)
            {
                // Move to the next node
                ptr = ptr.Next;
            }
            ptr.Next = testCase4.Next;

            // Tests a link list with a cycle at the start
            LinkedListNode testCase5 = new LinkedListNode(0);
            ptr = testCase5;
            for (int i = 1; i <= 15; i++)
            {
                // Instantiate the next node
                ptr.Next = new LinkedListNode(0); // Note that value doesn't matter
                // Move to the next node
                ptr = ptr.Next;
            }
            ptr.Next = testCase5;

            // Tests a linked list with a cycle at the start, but with an odd length
            LinkedListNode testCase6 = new LinkedListNode(0);
            ptr = testCase6;
            for (int i = 1; i <= 16; i++)
            {
                // Instantiate the next node
                ptr.Next = new LinkedListNode(0); // Note that value doesn't matter
                // Move to the next node
                ptr = ptr.Next;
            }
            ptr.Next = testCase6;

            if (ContainsCycle(testCase1))
            {
                Console.WriteLine("Test 1: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 1: Does not contain a cycle");
            }

            if (ContainsCycle(testCase2))
            {
                Console.WriteLine("Test 2: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 2: Does not contain a cycle");
            }

            if (ContainsCycle(testCase3))
            {
                Console.WriteLine("Test 3: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 3: Does not contain a cycle");
            }

            if (ContainsCycle(testCase4))
            {
                Console.WriteLine("Test 4: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 4: Does not contain a cycle");
            }

            if (ContainsCycle(testCase5))
            {
                Console.WriteLine("Test 5: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 5: Does not contain a cycle");
            }

            if (ContainsCycle(testCase6))
            {
                Console.WriteLine("Test 6: Contains a cycle");
            }
            else
            {
                Console.WriteLine("Test 6: Does not contain a cycle");
            }

        }

        // Containes Cycle 
        static Boolean ContainsCycle(LinkedListNode head)
        {
            LinkedListNode frontPtr = head;
            LinkedListNode backPtr = head;
            while(frontPtr.Next != null)
            {
                if (frontPtr.Next == null)
                    return false;
                frontPtr = frontPtr.Next;
                if (frontPtr.Next == null)
                    return false;
                frontPtr = frontPtr.Next;
                //Back Pointer doesn't need to check since it's always strictly behind the front pointer
                backPtr = backPtr.Next;

                // Return True if the front pointer ever encounters the backpointer
                if (frontPtr == backPtr)
                    return true;
            }
            return false;
        }


    }

    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }
    }
}
