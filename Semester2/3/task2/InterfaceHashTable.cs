using System;

namespace HashNamespace
{
    /// <summary>
    /// Hash table for strings
    /// </summary>
    interface InterfaceHashTable
    {
        /// <summary>
        /// Change hash function during operation
        /// </summary>
        /// <param name="userHashFunction">New hash function</param>
        void ChangeHashFunction(Func<string, int, int> userHashFunction);

        /// <summary>
        /// Add new word in hash table
        /// </summary>
        /// <param name="value">Input srtring</param>
        void AddElement(string value);

        /// <summary>
        /// Remove certain word
        /// </summary>
        /// <param name="value">Word which will be deleted</param>
        void RemoveElement(string value);
        
        /// <summary>
        /// Check: word is exist in hash table
        /// </summary>
        /// <param name="value">Word to be checked</param>
        /// <returns></returns>
        bool IsExist(string value);
        
        /// <summary>
        /// Print list that contains the word
        /// </summary>
        /// <param name="value"></param>
        void PrintList(string value);
        
        /// <summary>
        /// Show statistic: number of worlds in hash-table, average length of lists and number of empty cells
        /// </summary>
        void PrintStatistic();
    }
}
