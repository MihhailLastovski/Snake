using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class GameOver : RndColor
	{
		
		public void WriteGameOver() //Метод для вывода информации
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = GetRandomConsoleColor(); //Применение метода из класса RndColor
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			System.Threading.Thread.Sleep(500); //таймер
			WriteText("    G A M E    O V E R", xOffset + 1, yOffset++);
			System.Threading.Thread.Sleep(500);
			WriteText($"	    Score:{a}", xOffset, yOffset++);
			WriteText($"	Press something", xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
		}

        static void WriteText(String text, int xOffset, int yOffset) //Метод для вывода информации, который берет 3 значения: сама надпись, расположение по оси x и расположение по оси y 
		{
			Console.SetCursorPosition(xOffset, yOffset); //пишет в определенной позиции
			Console.WriteLine(text);
		}


	}
}
