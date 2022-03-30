﻿/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
    class Exercises8
	{
		// phương thức vẽ hình tam giác
		static string[,] DrawTriangle(int height)
        {
			var triangle = new string[height, 2 * height - 1];
			for (int i = 1; i <= height; i++)
			{
				for (int j = 1; j <= 2 * height - 1; j++)
				{
					if (j >= (height - i + 1) && j <= (height + i - 1))
					{
						triangle[i - 1, j - 1] = " * ";
					}
					else
					{
						triangle[i - 1, j - 1] = "   ";
					}
				}
			}
			return triangle;
		}

		// phương thức hiển thị kết quả
		static void ShowResult(string[,] rect)
		{
			for (int i = 0; i < rect.GetLength(0); i++)
			{
				for (int j = 0; j < rect.GetLength(1); j++)
				{
					Console.Write($"{rect[i, j]}");
				}
				Console.WriteLine();
			}
		}

		static void Main()
		{
			int h = int.Parse(Console.ReadLine());
			if (h <= 0)
			{
				Console.WriteLine("ERROR");
			}
			else
			{
				var result = DrawTriangle(h);
				ShowResult(result);
			}
		}
	}
}
