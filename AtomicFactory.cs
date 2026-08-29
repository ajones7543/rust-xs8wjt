using System;

namespace App
{
    public class SimpleGateway
    {
        private int _state;

        public SimpleGateway(int seed) => _state = seed;

        public int handle(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 21) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleGateway(21);
            Console.WriteLine(obj.handle(21));
        }
    }
}
