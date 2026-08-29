using System;

namespace App
{
    public class StreamAdapter
    {
        private int _state;

        public StreamAdapter(int seed) => _state = seed;

        public int resolve(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 50) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new StreamAdapter(50);
            Console.WriteLine(obj.resolve(50));
        }
    }
}
