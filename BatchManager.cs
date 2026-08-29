using System;

namespace App
{
    public class SecureScheduler
    {
        private int _state;

        public SecureScheduler(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 49) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SecureScheduler(49);
            Console.WriteLine(obj.handle(49));
        }
    }
}
