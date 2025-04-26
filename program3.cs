using System;

namespace MyFirstApp3
{
    class Program3
    {
        public static void MyList(string[] arg)
        {
            foreach (string name in arg)
            {
                Console.WriteLine("hello " + name);
            }
        }
    }
}
