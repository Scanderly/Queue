using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue1:MyQueue
    {

        private ArrayList _arrayList; 
        private int _queue;
        public Queue1()
        {
            _arrayList=new ArrayList();
            _queue =0 ;
        }

        public override object Dequeue()
        {
           
            object number = _arrayList[0];
            _arrayList.RemoveAt(0);
            _queue--;
            return number;
        }

        public override void Enqueue(int i)
        {
            _arrayList.Add(i);
            _queue++;
        }

       
    }
}
