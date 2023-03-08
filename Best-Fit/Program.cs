using System;

public class GFG
{
    static void bestFit(int[] blocksize, int m, int[] processsize, int n)
    {
        int[] allocation = new int[n];
        for (int i = 0; i < allocation.Length; i++)
            allocation[i] = -1;

        for (int i = 0; i < n; i++)
        {
            int bestinx = -1;
            for (int j = 0; j < m; j++)
            {
                if (blocksize[j] >= processsize[i])
                {
                    if (bestinx == -1)
                        bestinx = j;
                    else if (blocksize[bestinx] > blocksize[j])
                        bestinx = j;
                }
            }
            if (bestinx != -1)
            {
                allocation[i] = bestinx;
                blocksize[bestinx] -= processsize[i];
            }
        }
        Console.WriteLine("\nProcess No.\tProcess Size\tBlock no.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + (i + 1) + "\t\t" +
                          processsize[i] + "\t\t");
            if (allocation[i] != -1)
                Console.Write(allocation[i] + 1);
            else
                Console.Write("Not Allocated");
            Console.WriteLine();
        }
    }
    public static void Main()
    {
        Console.WriteLine("Enter the number of blocks");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of processes");
        int n = int.Parse(Console.ReadLine());
        int[] blocksize = new int[m];
        int[] processsize = new int[n];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Enter the size of block " + (i + 1));
            blocksize[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the size of process " + (i + 1));
            processsize[i] = int.Parse(Console.ReadLine());
        }
        bestFit(blocksize, m, processsize, n);
    }
}