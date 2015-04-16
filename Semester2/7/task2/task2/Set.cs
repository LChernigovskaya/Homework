using System;
using System.Collections.Generic;
using System.Collections;

namespace SetNamespace
{
    public class Set<T> : IEnumerable<T>
    {
        private List<T> listForSet;
        public int Lenght;

        public Set()
        {
            listForSet = new List<T>();
        }

        public bool Exists(T value)
        {
            return (listForSet.Contains(value));
        }

        public void Add(T value)
        {
            if (Exists(value))
            {
                return;
            }

            listForSet.Add(value);
            Lenght++;
        }

        public void RemoveElement(T value)
        {
            if (Exists(value))
            {
                listForSet.Remove(value);
            } 
        }

        public Set<T> Union(Set<T> secondSet)
        {
            Set<T> unionSet = new Set<T>();
            foreach (var element in this)
            {
                unionSet.Add(element);
            }
            foreach (var element in secondSet)
            {
                if (!this.Exists(element))
                {
                    unionSet.Add(element);
                }
            }

            return unionSet;
        }

        public Set<T> Intersection(Set<T> secondSet)
        {
            Set<T> intersectionSet = new Set<T>();
            foreach(var element in secondSet)
                if (this.Exists(element))
                {
                    intersectionSet.Add(element);
                }
            return intersectionSet;
        }

        public void PrintSet()
        {
            foreach (var element in listForSet)
                Console.Write(element);
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.listForSet.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}
