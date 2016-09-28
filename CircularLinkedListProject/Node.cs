using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    class Node
    {
        public int value;
        public Node link;

        public Node(int i)
        {
            value = i;
            link = null;
        }
    }
}
