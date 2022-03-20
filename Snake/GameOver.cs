using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class GameOver : RndColor
	{
		

		public void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = GetRandomConsoleColor();
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			System.Threading.Thread.Sleep(500);
			WriteText("    G A M E    O V E R", xOffset + 1, yOffset++);
			System.Threading.Thread.Sleep(500);
			WriteText("============================", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}


	}
}
