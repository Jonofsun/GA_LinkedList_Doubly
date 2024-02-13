namespace GA_LinkedList_Doubly_JonathanReed
{
    internal class Program
    {
        /* Jonathan Reed
         * 2/12/2024
         * 
         */
        static void Main(string[] args)
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

            // Add elements
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // Display forward and backward
            Console.WriteLine("Forward:");
            linkedList.DisplayForward();
            Console.WriteLine("Backward:");
            linkedList.DisplayBackward();

            // Remove an element
            if (linkedList.Remove(20))
                Console.WriteLine("20 removed");

            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            // Insert elements at specific positions
            linkedList.InsertAtIndex(1, 25); // Insert 25 at index 1
            linkedList.InsertAtFront(5);     // Insert 5 at the beginning
            linkedList.InsertAtEnd(35);      // Insert 35 at the end

            // Display forward after insertion
            Console.WriteLine("Forward (after insertion):");
            linkedList.DisplayForward();

            // Remove elements at specific positions
            linkedList.RemoveAtFront(); // Remove the first element
            linkedList.RemoveAtEnd();   // Remove the last element
            linkedList.RemoveAtIndex(2); // Remove the element at index 2

            // Display forward after removal
            Console.WriteLine("Forward (after removal):");
            linkedList.DisplayForward();

            // Clear the linked list
            linkedList.Clear();

            // Display forward after clearing
            Console.WriteLine("Forward (after clearing):");
            linkedList.DisplayForward();

            Console.ReadLine();
        }
    }
}
