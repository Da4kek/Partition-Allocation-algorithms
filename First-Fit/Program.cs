using System;

class GFG
{
    // Method to allocate memory to
    // blocks as per First fit algorithm
    static void firstFit(int[] blockSize, int m,
                         int[] processSize, int n)
    {
        // Stores block id of the block
        // allocated to a process
        int[] allocation = new int[n];

        // Initially no block is assigned to any process
        for (int i = 0; i < allocation.Length; i++)
            allocation[i] = -1;

        // pick each process and find suitable blocks
        // according to its size ad assign to it
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (blockSize[j] >= processSize[i])
                {
                    // allocate block j to p[i] process
                    allocation[i] = j;

                    // Reduce available memory in this block.
                    blockSize[j] -= processSize[i];

                    break;
                }
            }
        }

        Console.WriteLine("\nProcess No.\tProcess Size\tBlock no.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + (i + 1) + "\t\t" +
                          processSize[i] + "\t\t");
            if (allocation[i] != -1)
                Console.Write(allocation[i] + 1);
            else
                Console.Write("Not Allocated");
            Console.WriteLine();
        }
    }

    // Driver Code
    public static void Main()
    {
        Console.WriteLine("Enter the number of blocks");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of processes");
        int n = int.Parse(Console.ReadLine());
        int[] blockSize = new int[m];
        int[] processSize = new int[n];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Enter the size of block " + (i + 1));
            blockSize[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the size of process " + (i + 1));
            processSize[i] = int.Parse(Console.ReadLine());
        }


        firstFit(blockSize, m, processSize, n);
    }
}