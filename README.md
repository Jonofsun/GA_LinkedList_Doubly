# Guided Assignment - Linked List Doubly

## Introduction

**What is a Doubly Linked List:** A doubly linked list is a linear data structure similar to a singly linked list, but with an additional feature: each node contains two references, one to the next node and one to the previous node. This allows traversal in both directions, forward and backward.

**Why is it Important:** The key advantage of a doubly linked list is its ability to traverse in both directions, making operations like reversing the list, navigating backwards, or modifying elements near the end more efficient compared to a singly linked list. It's particularly useful in scenarios where bi-directional navigation is crucial.

**Differences from Singly Linked List:**
1. **Node Structure:** Nodes in a doubly linked list have two references (next and previous) compared to one in a singly linked list.
2. **Traversal:** Doubly linked lists can be traversed in both forward and backward directions.
3. **Memory Usage:** They consume more memory per node due to the additional reference.
4. **Complexity in Operations:** Insertions and deletions involve updating more references, which can be slightly more complex.

**Pros of Doubly Linked Lists:**
1. **Bi-directional Traversal:** Allows moving forwards and backwards through the list.
2. **Efficient Insertions/Deletions:** Especially near the ends and in the middle of the list.
3. **Dynamic Size:** Grows and shrinks dynamically as needed.
4. **No Need for Predecessor Tracking:** The previous reference eliminates the need to track the preceding element.

**Cons of Doubly Linked Lists:**
1. **Higher Memory Overhead:** Each node requires extra memory for an additional reference.
2. **Complex Implementation:** Managing two references can be more error-prone.
3. **Slower Access:** Traversing can be slightly slower due to the additional overhead of managing two references.

***Real World Examples***

1. **Navigation Systems:** For forward and backward navigation in applications like web browsers.
2. **Music Players:** To navigate through playlists in both directions.
3. **Undo/Redo Functionality:** In text editors or graphic design software.
4. **Recently Used Files:** In software applications, to move through a list of recently used files or actions.
5. **Gaming:** In board games or puzzles that require moving forwards and backwards through game states.

---

## Requirements

**Project Setup:**
1. Create a new C# project named "GA_LinkedList_Doubly_YourName."
2. Include your name and the current date as comments in the main class or file.

**Linked List Implementation:**
3. Implement a generic doubly linked list class named `DoublyLinkedList<T>`.
4. Include a nested class `LinkedListNode<T>` for individual nodes, each with references to both the next and previous nodes.

**Fields and Properties:**
5. Include fields for `head`, `tail`, and `count`.
6. Implement a public property `Count` for accessing the number of elements.

**Constructor:**
7. Create a constructor to initialize `head` and `tail` to null and `count` to zero.

**Core Methods:**
8. Implement core methods:
   - `Add(T value)` - Adds elements to the end.
   - `DisplayForward()` - Displays elements from head to tail.
   - `DisplayBackward()` - Displays elements from tail to head.
   - `Remove(T value)` - Removes an element by value.
   - Indexer override to access elements by index.

**Additional Methods:**
9. Implement methods for inserting elements:
   - `InsertAtIndex(int index, T value)` - At a specified index.
   - `InsertAtFront(T value)` - At the beginning.
   - `InsertAtEnd(T value)` - At the end.

10. Implement methods for removing elements:
    - `RemoveAtIndex(int index)` - At a specified index.
    - `RemoveAtFront()` - At the beginning.
    - `RemoveAtEnd()` - At the end.

11. Implement the `Clear` method to empty the list.

**Testing:**
12. Test your `DoublyLinkedList` class in a separate program or class.
13. Include test cases for all functionalities, ensuring correct implementation.

**Readme File:**
15. In your README, address the following:
    - Explanation of a doubly linked list and its utility.
    - Comparisons between singly and doubly linked lists in terms of efficiency and use cases.
    - The significance of having two references in a node and potential issues.
    - Discuss scenarios where a doubly linked list is preferable over a singly linked list or an array.
    - Considerations for choosing between a doubly linked list and other data structures.
    - Thoughts on combining the advantages of different data structures for optimal efficiency.

Ensure thorough documentation and a clear explanation in your README.

---

## Start By Creating a Doubly Linked List Class

1. Make it generic
2. Name it `DoublyLinkedList`

```csharp
using System; // Import the System namespace for basic functionalities.

// Define a generic class called DoublyLinkedList.
// The 'T' here is a type parameter that allows this class to work with various data types.
class DoublyLinkedList<T>
{

}

```

---

### Create a Nested Node Class

A singly linked list node has a reference to the next node, allowing you to move forward, like a chain of connected beads.

A doubly linked list node has references to both the next and previous nodes, allowing you to move both forward and backward in the list, like a two-way street.


```csharp
class DoublyLinkedList<T>
{
    // Nested class LinkedListNode representing elements in the doubly linked list.
    class LinkedListNode<T>
    {
        public T Value { get; set; }                    // Data stored in the node.
        public LinkedListNode<T> Next { get; set; }     // Reference to the next node.
        public LinkedListNode<T> Previous { get; set; } // Reference to the previous node.

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
```

***What is a Doubly Linked List Node***

A doubly linked list node is a crucial component of a doubly linked list, containing:
1. Data element storage.
2. Two pointers or references: one to the next node, one to the previous node.
3. Support for efficient forward and backward traversal.
4. Facilitation of dynamic sizing and flexible insertions/removals.
5. Foundation for complex data structures and algorithms.

---

### Fields, Property, and Constructor for your Doubly Linked List

Add the following code

```csharp
class DoublyLinkedList<T>
{
    // Private fields to track the head, tail, and count of elements.
    private LinkedListNode<T> head;
    private LinkedListNode<T> tail;
    private int count;

    // Public property to access the count of elements.
    public int Count
    {
        get { return count; }
    }

    // Constructor to initialize an empty doubly linked list.
    public DoublyLinkedList()
    {
        // Initially, both head and tail are null, and the count is 0.
        head = null;
        tail = null;
        count = 0;
    }
}
```

Explanation with comments:

- `private LinkedListNode<T> head;`: This private field holds a reference to the first node in the list (the head).

- `private LinkedListNode<T> tail;`: This private field holds a reference to the last node in the list (the tail).

- `private int count;`: This private field keeps track of the number of elements in the list.

- `public int Count`: This public property allows external code to access the count of elements in the list.

- `public DoublyLinkedList()`: This is the constructor of the `DoublyLinkedList` class. It initializes an empty doubly linked list:
  - `head = null;`: The head is set to null initially.
  - `tail = null;`: The tail is set to null initially.
  - `count = 0;`: The count is set to 0 to indicate an empty list.

**Explanation for `tail`:**

The `tail` reference is included in a doubly linked list to efficiently perform operations at the end of the list, such as adding or removing elements. Without the `tail`, you would need to traverse the entire list from the `head` to find the last node, which can be inefficient for these operations.

Having a `tail` reference allows you to access the last node directly, making tail-related operations faster and more efficient, especially when working with large lists.

---

## Insert At Front

```csharp
public void InsertAtFront(T value)
{
    // Create a new node with the given value.
    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

    if (head == null)
    {
        // If the list is empty, set both head and tail to the new node.
        head = newNode;
        tail = newNode;
    }
    else
    {
        // If the list is not empty, insert the new node at the front.
        newNode.Next = head;
        head.Previous = newNode;
        head = newNode;
    }

    // Increment the count to reflect the addition of a new element to the list.
    count++;
}
```

Explanation with comments for inserting at the front:

1. `LinkedListNode<T> newNode = new LinkedListNode<T>(value);`: This line creates a new node with the given value. This node will be inserted at the front of the doubly linked list.

2. `if (head == null)`: This condition checks if the list is empty. If `head` is null, it means the list has no elements.

   - `head = newNode;`: If the list is empty, both `head` and `tail` are set to the new node, making it the first and only element in the list.

3. If the list is not empty (the `else` block), the new node is inserted at the front:
   - `newNode.Next = head;`: The "Next" reference of the new node is set to the current `head`, which links the new node to the current first node.
   - `head.Previous = newNode;`: The "Previous" reference of the current head (the previous first node) is set to the new node, linking the previous first node to the new node.
   - `head = newNode;`: Finally, the `head` is updated to be the new node, making it the new first node in the list.

4. `count++;`: After successfully adding a new element at the front, the `count` is incremented to keep track of the number of elements in the list.

---

### Insert At Index


```csharp
public void InsertAtIndex(int index, T value)
{
    // Check if the provided index is out of range.
    if (index < 0 || index > count)
    {
        // Throw an exception if the index is invalid.
        throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
    }

    // Step 1: Create a new node with the given value.
    LinkedListNode<T> newNode = new LinkedListNode<T>(value);

    if (index == 0)
    {
        // Step 2: Insert at the beginning (index 0).
        // - Set the "Next" reference of the new node to the current head.
        newNode.Next = head;

        if (head != null)
        {
            // If the list was not empty, set the "Previous" reference of the current head to the new node.
            head.Previous = newNode;
        }

        // Update the head to be the new node, making it the new first node in the list.
        head = newNode;

        if (count == 0)
        {
            // If the list was initially empty, set the tail to the new node as well.
            tail = newNode;
        }
    }
    else if (index == count)
    {
        // Step 3: Insert at the end (index count).
        // - Set the "Previous" reference of the new node to the current tail.
        newNode.Previous = tail;

        // - Set the "Next" reference of the current tail to the new node.
        tail.Next = newNode;

        // Update the tail to be the new node, making it the new last node in the list.
        tail = newNode;
    }
    else
    {
        // Step 4: Insert at a middle index.
        // - Initialize a current node to traverse the list to the node before the desired index.
        LinkedListNode<T> current = head;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.Next;
        }

        // - Update references to insert the new node in the middle.
        newNode.Next = current.Next;
        newNode.Previous = current;
        current.Next.Previous = newNode;
        current.Next = newNode;
    }

    // Step 5: Increment the count to reflect the addition of a new element to the list.
    count++;
}
```

Explanation with detailed comments:

1. `public void InsertAtIndex(int index, T value)`: This method allows you to insert an element with the given value at the specified index in the doubly linked list.

2. `if (index < 0 || index > count)`: This condition checks if the provided index is out of the valid range of indices. If it's out of range, it throws an `ArgumentOutOfRangeException`.

3. `LinkedListNode<T> newNode = new LinkedListNode<T>(value);`: This line creates a new node with the given value, which will be inserted into the list.

4. The method handles three cases:

   - **Insert at the beginning (index 0)**: If the index is 0, the new node is inserted at the beginning of the list.

   - **Insert at the end (index count)**: If the index is equal to the current count (number of elements), the new node is inserted at the end of the list.

   - **Insert at a middle index**: For all other cases, the method iterates through the list to find the node before the desired index and then inserts the new node between the previous node and the next node.

5. `count++`: After successfully adding a new element at the specified index, the `count` is incremented to keep track of the number of elements in the list.

---

### Display Methods (Forward and Backward)

```csharp
public void DisplayForward()
{
    LinkedListNode<T> current = head;
    while (current != null)
    {
        Console.Write($"{current.Value} -> ");
        current = current.Next;
    }
    Console.WriteLine("null");
}

public void DisplayBackward()
{
    LinkedListNode<T> current = tail;
    while (current != null)
    {
        Console.Write($"{current.Value} -> ");
        current = current.Previous;
    }
    Console.WriteLine("null");
}
```

1. `DisplayForward` starts from the head and moves forward.
2. `DisplayBackward` starts from the tail and moves backward.

---

### Remove Method (Removing an Element by Value)

```csharp
public bool Remove(T value)
{
    LinkedListNode<T> current = head;

    while (current != null)
    {
        if (current.Value.Equals(value))
        {
            if (current == head) head = head.Next;
            if (current == tail) tail = tail.Previous;
            if (current.Next != null) current.Next.Previous = current.Previous;
            if (current.Previous != null) current.Previous.Next = current.Next;

            count--;
            return true;
        }

        current = current.Next;
    }

    return false;
}
```

1. Traverses the list to find the node.
2. Updates references of neighboring nodes when found.
3. Handles cases for removing head or tail.
4. Decreases the count.

---

### Indexer Override (Accessing Elements by Index)

```csharp
public T this[int index]
{
    get
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException();

        LinkedListNode<T> current = head;
        for (int i = 0; i < index; i++)
            current = current.Next;

        return current.Value;
    }
}
```

1. Validates the index.
2. Traverses to the node at the specified index.
3. Returns the node's value.

---

### Test the Code

```csharp
class Program
{
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
            Console.WriteLine("

20 removed");

        // Access element by index
        Console.WriteLine($"Element at index 1: {linkedList[1]}");

        Console.ReadLine();
    }
}
```

---

## Add Additional Methods

### Insert At

Implement `InsertAtIndex`, `InsertAtFront`, and `InsertAtEnd` methods, adjusting node references accordingly.

### Remove At

Implement `RemoveAtIndex`, `RemoveAtFront`, and `RemoveAtEnd`, handling the references and edge cases.

### Clear

Implement `Clear` to reset the list, setting head and tail to null and count to zero.

---

## Rubric

| Name                | Description                                                       | Points |
|---------------------|-------------------------------------------------------------------|--------|
| Project Setup       | C# project creation with correct naming and comments.              | 5      |
| DoublyLinkedList    | Implementation of the generic doubly linked list class.           | 10     |
| LinkedListNode      | Nested `LinkedListNode` class implementation.                     | 5      |
| Fields & Properties | Proper implementation of fields and property.                     | 5      |
| Constructor         | Constructor implementation for `DoublyLinkedList`.                | 5      |
| Core Methods        | Core methods (InsertAtFront, InsertAtIndex, DisplayForward/Backward, Remove, Indexer) impl. | 15     |
| Additional Methods  | Additional methods for insertion and removal.                     | 15     |
| Clear Method        | Implementation of the `Clear` method.                             | 5      |
| Testing             | Comprehensive testing program with diverse cases.                 | 10     |
| Code Compilation    | Error-free code compilation.                                      | 5      |
| Readme              | Detailed README with explanations and answers.                    | 10     |
| Total               |                                                                   | 100    |

This assignment guides you through creating a doubly linked list, similar to the singly linked list tutorial, with more focus on bidirectional traversal and manipulation.