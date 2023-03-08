using System;

class GFG
{
    static void worstFit(int[] blockSize, int m,
                        int[] processSize, int n)
    {
        int[] allocation = new int[n];

        for (int i = 0; i < allocation.Length; i++)
            allocation[i] = -1;

        for (int i = 0; i < n; i++)
        {
            int wstIdx = -1;
            for (int j = 0; j < m; j++)
            {
                if (blockSize[j] >= processSize[i])
                {
                    if (wstIdx == -1)
                        wstIdx = j;
                    else if (blockSize[wstIdx] < blockSize[j])
                        wstIdx = j;
                }
            }

            if (wstIdx != -1)
            {
                allocation[i] = wstIdx;

                blockSize[wstIdx] -= processSize[i];
            }
        }

        Console.WriteLine("\nProcess No.\tProcess Size\tBlock no.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + (i + 1) + "\t\t\t" + processSize[i] + "\t\t\t");
            if (allocation[i] != -1)
                Console.Write(allocation[i] + 1);
            else
                Console.Write("Not Allocated");
            Console.WriteLine();
        }
    }

    public static void Main(String[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] blockSize = new int[m];
        int[] processSize = new int[n];
        for (int i = 0; i < m; i++)
        {
            blockSize[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            processSize[i] = int.Parse(Console.ReadLine());
        }
        worstFit(blockSize, m, processSize, n);
    }
}
