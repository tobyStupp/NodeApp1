using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeApp1
{
    class GenerateLinkedList
    {
        public static Node<int> GetLinkedList (int count, int range = 20)
        {
            Node<int> dummy = new Node<int>(-1);
            Node<int> last = dummy;
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                last.SetNext(new Node<int>(rnd.Next(20) + 1));
                last = last.GetNext();
            }

            return dummy.GetNext();
        }
        public static Node<int> GetLinkedList (int [] values)
        {
            Node<int> dummy = new Node<int>(-1);
            Node<int> last = dummy;
            foreach (int x in values)
            {
                last.SetNext(new Node<int>(x));
                last = last.GetNext();
            }
            return dummy.GetNext();
        }
    }
}
