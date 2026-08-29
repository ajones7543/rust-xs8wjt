using System;

namespace App
{
    public class SharedCache
    {
        private int _state;

        public SharedCache(int seed) => _state = seed;

        public int parse(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 28) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedCache(28);
            Console.WriteLine(obj.parse(28));
        }
    }
}
