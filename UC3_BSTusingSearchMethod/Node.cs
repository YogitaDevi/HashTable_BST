using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_BSTusingSearchMethod.BinarySearch
{
    public class Node
    {
        public int Element { get; set; }
        public Node Leftside { get; set; }
        public Node Rightside { get; set; }

        public Node(int data)
        {
            this.Element = data;
        }

        internal bool CompareTo(int element)
        {
            throw new NotImplementedException();
        }
    }
}
