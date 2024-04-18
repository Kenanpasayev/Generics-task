using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class CustomList<T>
    {

        T[] arr;
        List<T> items;

        public CustomList()
        {
            arr = Array.Empty<T>();

        }
        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public T Find(Predicate<T> value)
        {
            foreach (T item in items)
            {
                return items.Find(value);
            }
            return default(T);
        }
        public List<T> FindAll(Predicate<T> value)
        {
            return items.FindAll(value);
        }
        public bool Remove(T item)
        {

            return items.Remove(item);
        }
        public int RemoveAll(Predicate<T> value)
        {
            return items.RemoveAll(value);
        }
    }
}
