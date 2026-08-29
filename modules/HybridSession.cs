using System;

namespace App
{
    public class HybridBuffer
    {
        private int _state;

        public HybridBuffer(int seed) => _state = seed;

        public int fetch(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 68) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridBuffer(68);
            Console.WriteLine(obj.fetch(68));
        }
    }
}
