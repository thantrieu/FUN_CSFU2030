/// <summary>
/// @author Branium Academy
/// @see https://braniumacademy.net
/// @version 2022.03.30
/// </summary>

using System;

namespace ExercisesLesson52
{
	
    class Exercises4
    {
		static int M = 9;
		static int N = 13;

		static void Main()
        {
			var result = DrawPlusSign();
			ShowResult(result);
        }

		static void ShowResult(string[,] rect)
		{
			for (int i = 0; i < rect.GetLength(0); i++)
			{
				for (int j = 0; j < rect.GetLength(1); j++)
				{
					Console.Write($"{rect[i, j]}");
				}
				Console.WriteLine("\n");
			}
		}

		// phương thức vẽ hình dấu +
		static string[,] DrawPlusSign()
        {
			var plusSign = new string[M, N];
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					if ((i == 0 || i == 8) && (j >= 4 && j <= 8)
						|| (i == 1 || i == 2 || i == 6 || i == 7)
							&& (j == 4 || j == 8)
						|| ((i == 3 || i == 5) && (j < 5 || j > 7))
						|| (i == 4 && (j == 0 || j == 12)))
					{
						plusSign[i, j] = " * ";
					}
					else
					{
						plusSign[i, j] = "   ";
					}
				}
			}
			return plusSign;
		}
    }
}
