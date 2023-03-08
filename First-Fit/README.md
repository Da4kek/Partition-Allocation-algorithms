# First-Fit Algorithm:

**Example:**

![First-Fit](https://media.discordapp.net/attachments/915850002453114911/1083041148202922204/image.png)

* The Partition is allocated which is first sufficient from the top of Main Memory.
* It's advangtage is that it is the fastest search algorithm.
* It's disadvantage is that it may leave a lot of unused space in the Main Memory.

**Pseudocode:**
    
    for i = 1 to n
        if (partition[i] >= process_size)
            partition[i] = partition[i] - process_size
            print("Process is allocated in partition: " + i)
            break
        else
            print("Process is not allocated in partition: " + i)

</br>

![image](https://media.geeksforgeeks.org/wp-content/uploads/Page_replacement_all_three.jpg)