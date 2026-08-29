using System;

namespace App
{
    public class SmartClient
    {
        private int _state;

        public SmartClient(int seed) => _state = seed;

        public int handle(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 68) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SmartClient(68);
            Console.WriteLine(obj.handle(68));
        }
    }
}
