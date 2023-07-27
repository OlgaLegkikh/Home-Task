using System;
using System.Linq;

namespace Optional_Task_2
{
    public class RandomTextGenerator
    {
		private static Random _random = new Random();

		public string RandomString(int length)
		{
			const string chars = " абвгдежзиклмнопрстуфхцчъыьэюя";
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[_random.Next(s.Length)]).ToArray());
		}
	}
}
