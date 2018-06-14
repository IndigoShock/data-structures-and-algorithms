# Merge Linked List
Write a method to merge two linked List classes.

## Challenge
The challenge is to have both linked lists merge starting from the head. The head of the first list will move to the second list's head. We approached it with two runners as reference nodes. The runner will keep moving to the next pair for the Current node to follow until the runner reaches the end of the list, indicating the Current node to stop.

## Solution
![Image](MergedLinkedLists\asset\MergeLinkedLists.jpg)