using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueDoubleStacked.Test
{
    /// <summary>
    /// Test class for our double-stacked queue
    /// </summary>
    [TestClass]
    public class QueueDoubleStackedTester
    {
        [TestMethod]
        public void CreateAndEmptyBlankQueue()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(0);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }
        [TestMethod]
        public void EnqueAndDequeue1()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(1);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void EnqueAndDequeue10()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(10);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void EnqueAndDequeue100()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(100);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void EnqueAndDequeue10000()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(10000);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void EnqueAndDequeue100000()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            EnqueAndDequeue(100000);
            stopwatch.Stop();

            Debug.WriteLine("Completed in {0}ms", stopwatch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Shared method to enqueue and dequeue a specified number of items
        /// </summary>
        /// <param name="numberOfItems"></param>
        private static void EnqueAndDequeue(int numberOfItems)
        {
            var queueStack = new DoubleStackQueue();
            Debug.WriteLine("Enqueueing {0} items...", numberOfItems);
            for (int i = 1; i <= numberOfItems; i++)
            {
                queueStack.Enqueue(String.Format("Item {0}", i));
            }

            Debug.WriteLine("Completed enqueueing {0} items", numberOfItems);
            Debug.WriteLine(string.Empty);
            Debug.WriteLine("Dequeueing {0} items...", numberOfItems);
            while (queueStack.Count > 0)
            {
                queueStack.Dequeue();
            }

            Debug.WriteLine("Completed dequeueing {0} items.", numberOfItems);
        }
    }
}
