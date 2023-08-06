using System;
using System.Reflection;

namespace Exam_Task_4
{
	public class MyStack
	{
		private int[] _myStack;
		private int _stackSize;

		public MyStack(int stackSize)
		{
			_stackSize = stackSize;
			_myStack = new int[stackSize];
			
		}

		public int Pop()
		{
			int firstElement = _myStack[0];
            for (int i = 1; i < _myStack.Length; i++)
            {
                _myStack[i - 1] = _myStack[i];
            }
            return firstElement;

		}

		public void Push(int newValue)
		{
			var newStack = new int[] { newValue };
            var z = new int[newStack.Length + _myStack.Length];
			newStack.CopyTo(z, 0);
			_myStack.CopyTo(z, newStack.Length);
			_myStack = z;
			Array.Resize(ref _myStack,_stackSize);

        }

		public void StackOutput()
		{
			foreach (int element in _myStack)
			{
				Console.Write($"{element}");
				Console.Write(Environment.NewLine);
			}
		}
	}
}

