using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextFileWordCounter
{
    /// <summary>
    /// This class provides functionality to count words in a given file
    /// 
    /// An optional CancellationToken can be used, if the WordCounter should perform asynchronously
    /// </summary>
    public class WordCounter
    {
        public string FilePath { get; set; }
        public IDictionary<string, int> Words { get; set; }
        public CancellationTokenSource CancellationTokenSource { get; set; }


        public WordCounter(string filePath)
        {
            FilePath = filePath;
        }

        public WordCounter(string filePath, CancellationTokenSource cancellationTokenSource)
        {
            FilePath = filePath;
            CancellationTokenSource = cancellationTokenSource;
        }


        /// <summary>
        /// Counts how often every word occurs in a given file
        ///
        /// The method can be cancelled by passing an optional Cancellation Token
        /// </summary>
        /// <returns>A dictionary with the word as key and the amount as value</returns>
        public ConcurrentDictionary<string, int> GetWordsAsDict()
        {
            var result = new ConcurrentDictionary<string, int>();
            Parallel.ForEach(File.ReadLines(FilePath, Encoding.Default), line =>
            {
                var words = line.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    CancellationTokenSource?.Token.ThrowIfCancellationRequested();

                    result.AddOrUpdate(word, 1, (_, x) => x + 1);
                }
            });

            Words = result;

            return result;
        }

        /// <summary>
        /// Example method of possible additional WordCounter functionality
        /// </summary>
        /// <returns>Total sum of words</returns>
        public int TotalWordCount()
        {
            if (Words == null)
            {
                GetWordsAsDict();
            }

            return Words.Sum(word => word.Value);
        }
    }
}