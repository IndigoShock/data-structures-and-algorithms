# Left Join
"Implement a simplified LEFT JOIN for 2 Hashmaps."

## Challenge
The challenge was if given two hashmaps, join them together. So the hashmaps have key value pairs. They also accept null values, which is different from hash tables and hash sets. Have an empty 2D array and insert the first hash map with the synonyms. As of now, the key for the first hash map will be at an index of [0] while the value will be at the index of [1]. The second hash map consists of antonyms. The logic here is if the second hash map's key matches the key in the first hash map, add the value of the second hash map's key to the index of [2] in the 2D array. If the key from the first hash map doesn't have any matches, then it will insert a NULL into the index of [2] in the 2D array. After the iteration is complete, then return the 2D array.

## Solution
![Image](../../assets/LeftJoin.jpg)