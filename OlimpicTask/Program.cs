using System;

namespace OlimpicTask
{
    class Program
    {
        static void Main()
        {

            Random random = new Random();
            int queuesCount = random.Next(3, 7);
            List<List<Human>> queues = new List<List<Human>>(queuesCount);
            for (int i = 0; i < queuesCount; i++)
            {
                int peoplesCount = random.Next(1, 10);
                queues.Add(new List<Human>());
                for (int j = 0; j < peoplesCount; j++)
                {
                    queues[i].Add(new Human());
                }

            }
            int people = random.Next(1, 10);
            foreach (var item in queues) Console.Write(item.Count + "\t");
            Console.WriteLine("| " + people);
            while (people > 0)
            {
                int index = 0;
                for (int i = 0; i < queues.Count; i++)
                {
                    if (queues[i].Count < queues[index].Count) index = i;
                }
                queues[index].Add(new Human());
                people--;
                for (int i = 0; i < queues.Count; i++)
                {
                    Console.Write(queues[i].Count + "\t");
                }
                Console.WriteLine("| " + people);
            }
            



            //MinMax<int> ints = new MinMax<int>(new int[] { 0, 1, 2, 3, 4, 5, });
            //Console.WriteLine(ints.Min());
            //Console.WriteLine(ints.Max());
            //MinMax<string> strings = new MinMax<string>(new string[] { "a", "bc", "def", "ghij" });
            //Console.WriteLine(strings.Min());
            //Console.WriteLine(strings.Max());
        }
    }
}