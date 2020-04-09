using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class MyQueue
    {
        private int capacity; //вместимость очереди
        private int count_busy; //сколько занято
        private KeyValuePair<Actions, Image>?[] elements;

        public KeyValuePair<Actions, Image>?[] Elements
        {
            get {
                return elements;
            }
        }

        public MyQueue()
        {
            capacity = 6;
            count_busy = 0;
            elements = new KeyValuePair<Actions, Image>?[capacity];
        }

        public bool Enqueue (KeyValuePair<Actions,Image> pair)
        {
            if(count_busy == capacity)
            {
                return false;
            }
            elements[count_busy] = pair;
            count_busy++;
            return true;
        }

        public KeyValuePair<Actions,Image>? Dequeue()
        {
            if (count_busy == 0)
                return null;
            KeyValuePair<Actions, Image>? return_pair = elements[0];
            for(int i = 0; i < count_busy - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            elements[count_busy - 1] = null;
            count_busy--;
            return return_pair;
        }

    }
}
