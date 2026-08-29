using System;

namespace App
{
    public class HybridProcessor
    {
        private int _state;

        public HybridProcessor(int seed) => _state = seed;

        public int sync(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 4) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new HybridProcessor(4);
            Console.WriteLine(obj.sync(4));
        }
    }
}
