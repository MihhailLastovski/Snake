using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class RndColor : Score //наследник класса Score
    {
		public static Random rnd = new Random(); //переменная класса Random
		public static ConsoleColor GetRandomConsoleColor() //метод типа данных ConsoleColor
		{
			var consoleColors = Enum.GetValues(typeof(ConsoleColor)); //создание переменной, которая берет количество значений из класса перечисления (enum)
			return (ConsoleColor)consoleColors.GetValue(rnd.Next(1, consoleColors.Length)); //возвращает цвет, который равен значению переменной. Метод рандом для генерации случайного цвета, начало с 1, потому что 0 - это черный цвет, а черный в консоли не видно
		}
	}
}
