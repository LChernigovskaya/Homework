using System;
using System.Collections.Generic;

namespace Tree
{
    /// <summary>
    /// The tree with iterator
    /// </summary>
    /// <typeparam name="T">value, which is comparable</typeparam>
    public interface Tree<T>: IEnumerable<T> where T: IComparable
    {
        /// <summary>
        /// Add new element  in tree
        /// </summary>
        /// <param name="value">new element</param>
        void Add(T value);

        /// <summary>
        /// Remove element from the tree
        /// </summary>
        /// <param name="value">element to be deleted</param>
        void Remove(T value);

        /// <summary>
        /// Check the element exists or not
        /// </summary>
        /// <param name="value">element to be checked</param>
        bool IsExists(T value);

        /// <summary>
        /// Check tree is empty or not
        /// </summary>
        bool IsEmpty();

        /// <summary>
        /// All element from the tree in ascending order
        /// </summary>
        /// <returns></returns>
        string PrintElementsOfTree();
    }
}
