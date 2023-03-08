# Best-fit algorithm
*This is a simple implementation of the best-fit algorithm in C#.*

* Best fit algorithm is a memory allocation algorithm that allocates a process to the partition with the smallest size that is large enough to hold the process.
  
* The algorithm is implemented in the `BestFit.cs` file.

**Example:**
![Best-fit algorithm](https://media.discordapp.net/attachments/915850002453114911/1083048453053087824/image.png)

**Pseudocode:**
```csharp
BestFit(int[] memory, int[] processes)
{
    for each process in processes
    {
        for each partition in memory
        {
            if partition is empty and partition size >= process size
            {
                allocate process to partition
                break
            }
        }
    }
}
```
</br>

![Image](https://media.geeksforgeeks.org/wp-content/uploads/Page_replacement_all_three.jpg)