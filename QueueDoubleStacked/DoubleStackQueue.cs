using System.Collections.Generic;

namespace QueueDoubleStacked
{
    /// <summary>
    /// DoubleStackQueue is a standard FIFO queue implemented per my insane boss's requirements that internally the queue is handled as two stacks
    /// </summary>
    public class DoubleStackQueue
    {
        // Contents are stored in StackA during persistence between operations
        private Stack<string> StackA = new Stack<string>();

        // Items are moved to StackB for retrieving the oldest item from the bottom of the Stack.
        private Stack<string> StackB = new Stack<string>();

        public int Count
        {
            get { return StackA.Count; }
        }

        public void Enqueue(string item)
        {
            while (StackB.Count > 0)
            {
                StackA.Push(StackB.Pop());
            }
            StackA.Push(item);
        }

        public string Dequeue()
        {
            while (StackA.Count > 0)
            {
                StackB.Push(StackA.Pop());
            }
            var valueToReturn = StackB.Pop();
            while (StackB.Count > 0)
            {
                StackA.Push(StackB.Pop());
            }
            return valueToReturn;
        }


    }
}