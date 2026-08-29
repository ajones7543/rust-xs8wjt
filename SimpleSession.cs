using System;

namespace App
{
    public class LiteMonitor
    {
        private int _state;

        public LiteMonitor(int seed) => _state = seed;

        public int decode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 50) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LiteMonitor(50);
            Console.WriteLine(obj.decode(50));
        }
    }
}
