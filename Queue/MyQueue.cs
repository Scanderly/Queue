using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public abstract class MyQueue
    {
        public abstract  void Enqueue(int i);
        public abstract object Dequeue();
       
    }
}
