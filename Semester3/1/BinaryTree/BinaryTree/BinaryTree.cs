using System;
using System.Collections.Generic;
using System.Collections;

namespace Tree
{
    /// <summary>
    /// Binary tree
    /// </summary>
    /// <typeparam name="T">value, which is comparable</typeparam>
    public class BinaryTree<T> : Tree<T> where T: IComparable
    {
        private TreeElement root;
        
        public BinaryTree()
        {
            root = null;
        }

        public void Add(T value)
        {
            if (root == null)
            {
                root = new TreeElement(value);
            }
            else
            {
                root.AddNewElement(value);
            }
        }

        public void Remove(T value)
        {
            if (IsEmpty())
            {
                throw new Exception("Tree is empty");
            }
            else
            {
                root = root.RemoveElement(value);
            }
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public bool IsExists(T value)
        {
            if (IsEmpty())
            {
                return false;
            }
            return root.IsExistsElement(value);
        }

        public string PrintElementsOfTree()
        {
            string result = null;
            foreach (T value in this)
            {
                result += value.ToString() + " ";
            }
            return result;
        }

        /// <summary>
        /// Class which realise elements for tree
        /// </summary>
        private class TreeElement
        {
            public TreeElement(T value)
            {
                this.LeftChild = null;
                this.RightChild = null;
                this.Value = value;
            }

            public TreeElement LeftChild { get; set; }
            public TreeElement RightChild { get; set; }
            public T Value { get; set; }

            public void AddNewElement(T newValue)
            {
                if (this.Value.CompareTo(newValue) == 0)
                {
                    throw new Exception("This value already exists");
                }

                if (this.Value.CompareTo(newValue) > 0)
                {
                    if (LeftChild == null)
                    {
                        LeftChild = new TreeElement(newValue);
                    }
                    else
                    {
                        LeftChild.AddNewElement(newValue);
                    }
                }
                else
                {
                    if (RightChild == null)
                    {
                        RightChild = new TreeElement(newValue);
                    }
                    else
                    {
                        RightChild.AddNewElement(newValue);
                    }
                }
            }

            public TreeElement RemoveElement(T value)
            {
                if (this.Value.CompareTo(value) == 0)
                {
                    if (this.LeftChild == null && this.RightChild == null)
                    {
                        return null;
                    }

                    if (this.RightChild != null && this.LeftChild == null)
                    {
                        return this.RightChild;
                    }

                    if (this.LeftChild != null && this.RightChild == null)
                    {
                        return this.LeftChild;
                    }
                    else
                    {
                        TreeElement auxilary = this.RightChild;
                        while (auxilary.LeftChild != null)
                        {
                            auxilary = auxilary.LeftChild;
                        }
                        this.Value = auxilary.Value;
                        auxilary = auxilary.RightChild;
                    }
                }
                else if (this.Value.CompareTo(value) < 0)
                {
                    if (this.RightChild != null)
                    {
                        this.RightChild = this.RightChild.RemoveElement(value);
                    }
                }
                else
                {
                    if (this.LeftChild != null)
                    {
                        this.LeftChild = this.LeftChild.RemoveElement(value);
                    }
                }

                return this;
            }

            public bool IsExistsElement(T value)
            {
                if (this.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                else if (this.Value.CompareTo(value) > 0)
                {
                    if (this.LeftChild != null)
                    {
                        return this.LeftChild.IsExistsElement(value);
                    }
                }
                else
                {
                    if (this.RightChild != null)
                    {
                        return this.RightChild.IsExistsElement(value);
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Reilized for IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Realized for IEnumerator
        /// </summary>
        private class TreeEnumerator : IEnumerator<T>
        {
            private int position;
            private List<T> list;

            public TreeEnumerator(BinaryTree<T> currentTree)
            {
                this.position = -1;
                this.list = new List<T>();
                this.RewriteInList(currentTree.root);
            }

            /// <summary>
            /// Take value from the tree in ascending order and write them in list
            /// </summary>
            private void RewriteInList(TreeElement currentElement)
            {
                if (currentElement == null)
                {
                    return;
                }
                this.RewriteInList(currentElement.LeftChild);
                list.Add(currentElement.Value);
                this.RewriteInList(currentElement.RightChild);
            }

            public void Reset()
            {
                position = -1;
            }

            T IEnumerator<T>.Current
            {
                get { return list[position]; }
            }

            public object Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                position++;
                return (position < list.Count);
            }

            public void Dispose()
            {
            }
        }
    }
}