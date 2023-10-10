using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK_TH_p2
{
    class IntNode
    {
        private int data;
        private IntNode next;

        public int Data
        {
            get { return data; }
            set { Data = value; }
        }

        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public IntNode(int x)
        {
            data = x;
            next = null;
        }
    }
}
