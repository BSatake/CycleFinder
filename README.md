From InterviewCake.com
https://www.interviewcake.com/question/csharp/linked-list-cycles

You have a singly-linked list ↴ and want to check if it contains a cycle.

A singly-linked list is built with nodes, where each node has:

node.Next—the next node in the list.
node.Value—the data held in the node. For example, if our linked list stores timestamps, node.Value might be the number of seconds past the Unix epoch.
For example:

  public class LinkedListNode
{
    public int Value { get; set; }

    public LinkedListNode Next { get; set; }

    public LinkedListNode(int value)
    {
        Value = value;
    }
}

C#
A cycle occurs when a node’s Next points back to a previous node in the list. The linked list is no longer linear with a beginning and end—instead, it cycles through a loop of nodes.

Write a method ContainsCycle() that takes the first node in a singly-linked list and returns a boolean indicating whether the list contains a cycle.
