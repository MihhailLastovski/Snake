using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class RndColor : Score
    {
		public static Random rnd = new Random();
		public static ConsoleColor GetRandomConsoleColor()
		{
			var consoleColors = Enum.GetValues(typeof(ConsoleColor));
			return (ConsoleColor)consoleColors.GetValue(rnd.Next(1, consoleColors.Length));
		}
	}
}
