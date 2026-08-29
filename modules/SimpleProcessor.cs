using System;

namespace App
{
    public class StreamResolver
    {
        private int _state;

        public StreamResolver(int seed) => _state = seed;

        public int run(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 38) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new StreamResolver(38);
            Console.WriteLine(obj.run(38));
        }
    }
}
