using System;
using System.Collections;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class Stack
        {
            private ArrayList List { get; set; }
            public Stack()
            {
                List = new ArrayList();
            }
            public void Push(object obj)
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("Value can't be null.");
                }
                List.Add(obj);
            }

            public object Pop()
            {
                if (List.Count == 0)
                {
                    throw new InvalidOperationException("Can't execute Pop with empty list.");
                }

                var obj = List[List.Count - 1];
                List.RemoveAt(List.Count - 1);

                return obj;
            }

            public void Clear()
            {
                List.Clear();
            }
        }
    }
}
