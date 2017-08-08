using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组转列表
{
    class MyList<T>
    {
        public T[] templist=new T[capacity];
        int length=0;
        public static int capacity=8;
     
        public void Add(T a)
        {
            if (length==capacity)
            {
                capacity *= 2;
                T[] templist2 = templist;
                templist=new T[capacity];
                templist2.CopyTo(templist,0);
            }
            templist[length] = a;
            length++;
        }

        public void RemoveAt(int a)
        {
            length--;
            for (int i = a; i < length; i++)
            {
                templist[i] = templist[i + 1];
            }
        }

        public void Print(T[] a)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }

        public void Set(int index, T a)
        {
            templist[index] = a;
        }

        public T Get(int index)
        {
            return templist[index];
        }

        public T PopFront()
        {
            T a=Get(0);
            RemoveAt(0);
            return a;
        }

        public void Insert(int Index,T a)
        {
            if (length == capacity)
            {
                capacity *= 2;
            }
            T[] templist2 = templist;
            templist = new T[capacity];
            templist2.CopyTo(templist, 0);
            for (int i = Index; i < length; i++)
            {
                templist[i + 1] = templist2[i];
            }
            templist[Index] = a;
            length++;
        }
        public void Insert2(int Index, T a)
        {
            if (length == capacity)
            {
                capacity *= 2;
                T[] templist2 = templist;
                templist = new T[capacity];
                templist2.CopyTo(templist, 0);
            }

            length++;
            for (int i = length; i > Index-1; i--)
            {
                templist[i + 1] = templist[i];
            }
            templist[Index] = a;
           
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<float> list=new MyList<float>();
         
            list.Add(1.1f);
            list.Add(1.2f);
            list.Add(1.3f);
            list.Add(1.4f);
            list.Add(1.5f);
            list.Add(1.6f);
            list.Add(1.7f);
            list.Add(1.8f); 

            //list.RemoveAt(2);
            //list.Set(2,10);
            list.Insert2(2,1.9f);
            list.Insert2(4,1.8f);
            list.Print(list.templist);
            Console.WriteLine("获取的数字是："+list.Get(3));
            Console.Read();
        }
    }
}
