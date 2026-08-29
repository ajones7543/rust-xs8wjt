using System;

namespace App
{
    public class AtomicFactory
    {
        private int _state;

        public AtomicFactory(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 5) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicFactory(5);
            Console.WriteLine(obj.load(5));
        }
    }
}
