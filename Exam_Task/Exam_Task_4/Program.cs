// See https://aka.ms/new-console-template for more information
using Exam_Task_4;

MyStack stack = new MyStack(5);
stack.Push(1);
stack.Push(2);
stack.StackOutput();
Console.WriteLine(stack.Pop());
stack.Push(3);
stack.Push(4);
stack.StackOutput();
 

