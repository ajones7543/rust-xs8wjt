using System;

namespace App
{
    public class SimpleScheduler
    {
        private int _state;

        public SimpleScheduler(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 51) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SimpleScheduler(51);
            Console.WriteLine(obj.decode(51));
        }
    }
}
