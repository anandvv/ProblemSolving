using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class QueueAsStack
    {
        Stack<int> inputStack;
        Stack<int> outputStack;

        public QueueAsStack()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        public void enqueue(int x)
        {
            PopElementsFromOutputStackToInputStack();

            inputStack.Push(x);

            PushElementsFromInputStackToOutputStack();
        }

        private void PushElementsFromInputStackToOutputStack()
        {
            while (inputStack.Count != 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        private void PopElementsFromOutputStackToInputStack()
        {
            while (outputStack.Count != 0)
            {
                inputStack.Push(outputStack.Pop());
            }
        }

        public int dequeue()
        {
            if (outputStack.Count > 0)
                return outputStack.Pop();
            else
                return -1;
        }

        public int front()
        {
            return outputStack.Peek();
        }
    }
}
