# Worst-Fit algorithm
* Worst-Fit algorithm is a memory allocation algorithm that allocates a process to the partition with the largest size that is sufficient to hold the process.

**Example:**
![Worst-Fit](https://media.discordapp.net/attachments/915850002453114911/1083051471865647175/image.png)

**Algorithm:**
```csharp
WorstFit(int[] memory, int[] processes)
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