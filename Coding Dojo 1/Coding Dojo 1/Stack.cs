using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1
{
    public class Stack<T>
    {

        public Element<T> current;

        public void Push(T item)
        {
            if (current == null)
            {
                current = new Element<T>() { ElementValue = item, Following = null };
            }
            else
            {
                Element<T> temp = new Element<T>() { ElementValue = item, Following = current };
                current = temp;
            }

        }

        public T Pop()
        {
            if (current != null)
            {
                T temp = current.ElementValue;
                current = current.Following;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if (current != null)
            {
                return current.ElementValue;
            }
            else
            {
                return default(T);
            }
        }

    }
}
