using System;

namespace Task3
{
    interface InterfaceHashTable
    {
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
        bool Exists(string value);
        
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
