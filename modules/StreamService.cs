using System;

namespace App
{
    public class HybridSession
    {
        private int _state;

        public HybridSession(int seed) => _state = seed;

        public int load(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 51) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridSession(51);
            Console.WriteLine(obj.load(51));
        }
    }
}
