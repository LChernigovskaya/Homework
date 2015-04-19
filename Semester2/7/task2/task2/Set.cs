using System;
using System.Collections.Generic;
using System.Collections;

namespace SetNamespace
{
    /// <summary>
    /// ADT set
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> : IEnumerable<T>
    {
        private List<T> listForSet;
        public int Length { get; set; }

        public Set()
        {
            listForSet = new List<T>();
        }

        /// <summary>
        /// Check such element exists in set or doesn't
        /// </summary>
        /// <param name="value">Value to be checked</param>
        /// <returns></returns>
        public bool Exists(T value)
        {
            return listForSet.Contains(value);
        }

        /// <summary>
        /// Add new element in the set
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(T value)
        {
            if (Exists(value))
            {
                return;
            }

            listForSet.Add(value);
            Length++;
        }

        /// <summary>
        /// Delete the element from the set
        /// </summary>
        /// <param name="value">Element to be deleted</param>
        public void RemoveElement(T value)
        {
            if (Exists(value))
            {
                listForSet.Remove(value);
            } 
        }

        /// <summary>
        /// Unite our set with another set
        /// </summary>
        /// <param name="secondSet">Set to be united</param>
        /// <returns>New set which is the union of two sets</returns>
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

        /// <summary>
        /// Intersect our set with another set
        /// </summary>
        /// <param name="secondSet">Set to be intersected with our set</param>
        /// <returns>New set which is intersection of two sets</returns>
        public Set<T> Intersection(Set<T> secondSet)
        {
            Set<T> intersectionSet = new Set<T>();
            foreach (var element in secondSet)
            {
                if (this.Exists(element))
                {
                    intersectionSet.Add(element);
                }
            }
            return intersectionSet;
        }

        /// <summary>
        /// Print ADT set
        /// </summary>
        public void PrintSet()
        {
            foreach (var element in listForSet)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Realization for IEnumerable
        /// </summary>
        /// <returns></returns>
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