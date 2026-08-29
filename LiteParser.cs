using System;

namespace App
{
    public class RemoteFactory
    {
        private int _state;

        public RemoteFactory(int seed) => _state = seed;

        public int encode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 62) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new RemoteFactory(62);
            Console.WriteLine(obj.encode(62));
        }
    }
}
