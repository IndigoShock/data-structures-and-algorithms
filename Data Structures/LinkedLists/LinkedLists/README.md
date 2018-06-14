# kth from the end of a Linked List
Write a method for the Linked List class which takes a number, k, as a parameter. 
Return the node that is k from the end of the linked list.

## Challenge
The challenge is to iterate through the linked list twice. The first while loop is to know how long the list is. Subtracting how long the loop is by what value k is. Then we'll find k.

## Solution
![Image](LinkedLists/asset/KthElement.jpg)



# Merge Linked List
Write a method to merge two linked List classes.

## Challenge
The challenge is to have both linked lists merge starting from the head. The head of the first list will move to the second list's head. We approached it with two runners as reference nodes. The runner will keep moving to the next pair for the Current node to follow until the runner reaches the end of the list, indicating the Current node to stop.

## Solution
![Image](LinkedLists/asset/MergeLinkedLists.jpg)