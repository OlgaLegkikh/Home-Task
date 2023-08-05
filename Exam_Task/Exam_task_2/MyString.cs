using System;
namespace Exam_task_2
{
	public class MyString
	{
		private string? _myString;


		public MyString()
		{
			Console.WriteLine("Введите строку");
			_myString = Console.ReadLine();
            Console.WriteLine(_myString);
        }

		public MyString(int i)
		{
            Console.WriteLine("Введите строку");
            _myString = Console.ReadLine();
			try
			{
				if (i % 2 == 0)
				{
					_myString.ToUpper();
				}
				else
				{
					_myString.ToLower();
				}
			}
			catch (NullReferenceException)
			{

				Console.WriteLine("Строка пуста");
			}

		}

		public string Reverse()
		{
			try
			{
				char[] arr = this._myString.ToCharArray();
				Array.Reverse(arr);
				return new string(arr);

			}
			catch (NullReferenceException)
			{
				return "Строка пуста";
			}
        }
	}
}

