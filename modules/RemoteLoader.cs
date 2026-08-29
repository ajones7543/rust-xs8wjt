using System;

namespace App
{
    public class SimpleManager
    {
        private int _state;

        public SimpleManager(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 69) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SimpleManager(69);
            Console.WriteLine(obj.run(69));
        }
    }
}
