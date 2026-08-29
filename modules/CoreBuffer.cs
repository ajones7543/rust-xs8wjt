using System;

namespace App
{
    public class SharedContext
    {
        private int _state;

        public SharedContext(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 58) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SharedContext(58);
            Console.WriteLine(obj.dispatch(58));
        }
    }
}
