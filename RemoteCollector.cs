using System;

namespace App
{
    public class RemoteResolver
    {
        private int _state;

        public RemoteResolver(int seed) => _state = seed;

        public int decode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 26) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new RemoteResolver(26);
            Console.WriteLine(obj.decode(26));
        }
    }
}
