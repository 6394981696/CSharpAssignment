
using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Different types of loops in C#:");

        // 1️⃣ For Loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"For Loop: {i}");
        }

        // 2️⃣ While Loop
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine($"While Loop: {j}");
            j++;
        }

        // 3️⃣ Do-While Loop
        int k = 1;
        do
        {
            Console.WriteLine($"Do-While Loop: {k}");
            k++;
        } while (k <= 5);

        // 4️⃣ Foreach Loop (Array Example)
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Foreach Loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // 🔴 Finding Min & Max from an Array
        int[] data = { 34, 67, 12, 89, 23 };
        int min = data.Min();
        int max = data.Max();
        Console.WriteLine($"Smallest: {min}, Largest: {max}");

        // 🔥 Infinite Loops Example
        // Uncomment to test
        // for (;;){Console.WriteLine("Infinite Loop");}

        // ⏭️ Break & Continue Example
        for (int x = 1; x <= 10; x++)
        {
            if (x == 5) break;  // Stops at 5
            Console.WriteLine($"Break Example: {x}");
        }

        for (int y = 1; y <= 10; y++)
        {
            if (y == 5) continue; // Skips 5
            Console.WriteLine($"Continue Example: {y}");
        }

        // 🔥 Parallel.ForEach Example (Performance Boost)
        string[] tasks = { "Task1", "Task2", "Task3", "Task4", "Task5" };

        Console.WriteLine("\n🔵 Normal Foreach:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }

        Console.WriteLine("\n🔴 Parallel.ForEach:");
        Parallel.ForEach(tasks, task =>
        {
            Console.WriteLine(task);
        });
    }
}
