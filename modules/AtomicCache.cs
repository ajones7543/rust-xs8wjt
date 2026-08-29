using System;

namespace App
{
    public class SharedController
    {
        private int _state;

        public SharedController(int seed) => _state = seed;

        public int render(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 64) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SharedController(64);
            Console.WriteLine(obj.render(64));
        }
    }
}
