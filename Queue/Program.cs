using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue1 queue1 = new Queue1();
            queue1.Enqueue(44);
            queue1.Enqueue(765);
            queue1.Enqueue(87);
            queue1.Enqueue(23);
            queue1.Enqueue(1);

            Console.WriteLine(queue1.Dequeue());
            Console.ReadLine();
        }
    }
}
