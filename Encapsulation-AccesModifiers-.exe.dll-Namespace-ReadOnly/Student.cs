using System;
namespace Encapsulation_AccesModifiers_.exe.dll_Namespace_ReadOnly
{
	public class Student : Person
	{
		private int _point;
		public int Point
		{
			get { return _point; }
			set
			{
				if (value >= 0 && value <= 100)
				{
					_point = value;
				}
				else
				{
					Console.WriteLine("Point must be between 0 and 100");
				}

			}

		}

		public Student(int point)
		{
			Point = point;
		}

		
	}
}

