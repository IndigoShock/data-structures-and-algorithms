# Tree Intersection
"Find common values in 2 binary trees."

## Challenges
The challenge is to see what the common values in two binary trees are. A binary tree will have a root node. Traversing through each breadth-first for the fastest traversal. The way I have done this is through a hash set since a hash set will have unique values. If say a duplicate value did push back, then insert that value into an empty array. This happens with each node value until no more nodes can be traversed through the binary tree. After the traversal is complete, return the empty array so we know what the common values are.

## Solution
![image](/assets/TreeIntersection.jpg)