using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK_TH_p2
{
    class MyList
    {
        private IntNode first;
        private IntNode last;

        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }

        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }

        public MyList()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public int Count
        {
            get
            {
                int count = 0;
                IntNode p = first;
                while (p != null)
                {
                    count++;
                    p = p.Next;
                }
                return count;
            }
        }

        public void AddFirst(int x)
        {
            IntNode newNode = new IntNode(x);
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }

        public void AddLast(int x)
        {
            IntNode newNode = new IntNode(x);
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    break;
                AddLast(x);
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        public IntNode SearchX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                    return p;
                p = p.Next;
            }
            return null;
        }

        public int GetNodeIndex(IntNode node)
        {
            IntNode p = first;
            int index = 0;
            while (p != null && p != node)
            {
                p = p.Next;
                index++;
            }
            if (p == node)
                return index;
            else
                return -1;
        }

        public IntNode GetMax()
        {
            if (IsEmpty())
                return null;

            IntNode maxNode = first;
            IntNode p = first.Next;
            while (p != null)
            {
                if (p.Data > maxNode.Data)
                {
                    maxNode = p;
                }
                p = p.Next;
            }
            return maxNode;
        }

        public IntNode GetMin()
        {
            if (IsEmpty())
                return null;

            IntNode minNode = first;
            IntNode p = first.Next;
            while (p != null)
            {
                if (p.Data < minNode.Data)
                    minNode = p;
                p = p.Next;
            }
            return minNode;
        }

        public IntNode Find(IntNode p )
        {        
            if (p == first)
                return null;

            IntNode prevP = first;
            while (prevP != null && prevP.Next != p)
            {
                prevP = prevP.Next;
            }
            return prevP;
        }
            
        public IntNode RemoveAt(int i)
        {
            if (IsEmpty())
                return null;

            IntNode p = first;
            IntNode prev = null;
            for (int j = 0; j < i; j++)
            {
                prev = p;
                p = p.Next;
            }

            if (p == first)
            {
                first = first.Next;
            }
            else if (p == last)
            {
                last = prev;
            }
            else
            {
                prev.Next = p.Next;
            }

            return p;
        }

        public void RemoveX(int x)
        {
            IntNode p = first;
            IntNode prev = null;
            while (p != null)
            {
                if (p.Data == x)
                {
                    if (p == first)
                    {
                        first = first.Next;
                    }
                    else if (p == last)
                    {
                        last = prev;
                    }
                    else
                    {
                        prev.Next = p.Next;
                    }

                    break;

                }
                prev = p;
                p = p.Next;
            }
        }

        public void InsertAt(int x, int i)
        {
            if (i < 0)
                return;

            IntNode newNode = new IntNode(x);

            if (IsEmpty())
            {
                first = last = newNode;
                return;
            }

            if (i == 0)
            {
                newNode.Next = first;
                first = newNode;
                return;
            }

            IntNode p = first;
            IntNode prev = null;
            for (int j = 0; j < i; j++)
            {
                prev = p;
                p = p.Next;
            }

            newNode.Next = p;
            prev.Next = newNode;
        }

        public void InsertXAfterMin(int x)
        {
            if (IsEmpty())
                return;

            IntNode minNode = GetMin();

            if (minNode == null)
                return;

            IntNode newNode = new IntNode(x);

            newNode.Next = minNode.Next;
            minNode.Next = newNode;
        }

        public void InsertXAfterY(int x, int y)
        {
            IntNode p = first;

            while (p != null)
            {
                if (p.Data == y)
                {
                    IntNode newNode = new IntNode(x);
                    newNode.Next = p.Next;

                    if (p == last)
                    {
                        last = newNode;
                    }

                    p.Next = newNode;
                    break;
                }

                p = p.Next;
            }
        }

        public void InsertXBeforeMax(int x)
        {
            if (IsEmpty())
                return;

            IntNode maxNode = GetMax();

            if (maxNode == null)
                return;

            IntNode newNode = new IntNode(x);

            newNode.Next = maxNode;
            if (maxNode == first)
            {
                first = newNode;
            }
            else
            {
                IntNode p = first;
                while (p.Next != maxNode)
                {
                    p = p.Next;
                }

                p.Next = newNode;
            }

        }

        public void InsertXBeforeY(int x, int y)
        {
            IntNode p = first;
            IntNode prev = null;
            while (p != null)
            {
                if (p.Data == y)
                {
                    IntNode newNode = new IntNode(x);

                    if (p == first)
                    {
                        first = newNode;
                    }
                    else
                    {
                        prev.Next = newNode;
                    }

                    newNode.Next = p;
                    break;
                }

                prev = p;
                p = p.Next;
            }
        }

        public MyList RShiftRight()
        {

            if (IsEmpty())
                return this;

            IntNode newFirst = last;
            last = newFirst;
            IntNode p = first;

            while (p != null)
            {
                if (p.Next == last)
                    p.Next = null;

                p = p.Next;
            }

            newFirst.Next = first;
            first = newFirst;

            return this;

        }

        public void Swap(IntNode a, IntNode b)
        {
            int temp = a.Data;
            a.Data = b.Data;
            b.Data = temp;
        }

        public void InterchangeSort()
        {
            

            for (int i = 0; i < Count - 1; i++)
            {
                IntNode p = first;
                for (int j = 0; j < Count - 1 - i; j++)
                {
                    if (p.Data > p.Next.Data)
                    {
                        Swap(p, p.Next);
                    }
                    p = p.Next;
                }
            }

            //for (int i = 0; i < Count - 1; i++)
            //{
            //    for (int j = i + 1; j < Count; j++)
            //    {
            //        if (first.Data > first.Next.Data)
            //        {
            //            Swap(first,first.Next);
            //        }
            //    }
            //}

        }

        public void SelectionSort()
        {

            for (int i = 0; i < Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Count; j++)
                {
                    if (first.Data < first.Next.Data)
                        minIndex = j;
                }

                Swap(first, first.Next);
            }

            //for (int i = 0; i < Count - 1; i++)
            //{
            //    // Tìm node có giá trị nhỏ nhất trong danh sách từ vị trí i
            //    int minIndex = i;
            //    for (int j = i + 1; j < Count; j++)
            //    {
            //        if (first.Next.Data < first.Data)
            //            minIndex = j;
            //    }

            //    // Hoán đổi giá trị của node có giá trị nhỏ nhất với node thứ i
            //    int temp = first.Data;
            //    first.Data = first.Next.Data;
            //    first.Next.Data = temp;
            //}

        }
    }
}
