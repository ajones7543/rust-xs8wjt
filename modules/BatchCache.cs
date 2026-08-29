using System;

namespace App
{
    public class FastManager
    {
        private int _state;

        public FastManager(int seed) => _state = seed;

        public int sync(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 7) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new FastManager(7);
            Console.WriteLine(obj.sync(7));
        }
    }
}
