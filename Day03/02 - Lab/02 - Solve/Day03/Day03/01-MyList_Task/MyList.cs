using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03._01_MyList_Task
{
    internal class MyList<T> where T : IComparable<T>
    {
        //Fields
        T[] arr;
        int capacity;
        int top;

        //Properties
        public int Capacity { get => capacity; }
        public int length { get => top + 1; }

        //Indexer
        public T this[int index]
        {
            get
            {
                if (top != -1 && index <= top)
                {
                    return arr[index];
                }
                else
                {
                    Console.WriteLine("There is no Data!");
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                if (top != -1 && index <= top)
                {
                    arr[index] = value;
                }
                else
                {
                    Console.WriteLine("Can't Set New Data - Just Update!");
                    throw new ArgumentOutOfRangeException();
                }
            }
        }



        //Constructor
        public MyList(int cap)
        {
            capacity = cap;
            arr = new T[cap];
            top = -1;
        }

        //Methods
        public void Add(T value)
        {
            if (top < capacity - 1)
            {
                top++;
                arr[top] = value;
            }
            else
            {
                capacity *= 2;
                T[] temp = new T[capacity];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
                top++;
                arr[top] = value;
                //throw new IndexOutOfRangeException();
            }

        }

        public void Remove(T value)
        {
            if (length == 0)
            {
                Console.WriteLine("Array Is Empty!");
                return;
            }
            bool valueFound = false;
            for (int i = 0; i < top; i++)
            {
                if (value.CompareTo(arr[i]) == 0)
                {
                    valueFound = true;
                    arr[i] = arr[i + 1];
                    for (int j = i + 1; j < top; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    capacity--;
                    top--;
                    T[] newArr = new T[capacity];
                    for (int k = 0; k <= top; k++)
                    {
                        newArr[k] = arr[k];
                    }
                    arr = newArr;
                    break;
                }
            }
            if (!valueFound)
                Console.WriteLine($"Not Found This Value -> {value}!");
        }

        public void Print()
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
