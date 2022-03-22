using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym) //конструктор, принимающий значения точки от, который начнет отрисовываться линия yUp и на какой точки заканчивается yDown. Также берет координату x, на которой символ будет нарисован и какой символ sym
		{
			pList = new List<Point>(); //создается список точек
			for (int y = yUp; y <= yDown; y++) //цикл будет исполняться, пока yUp не будет равен yDown
			{
				Point p = new Point(x, y, sym); //создание объекта p класса Point
				pList.Add(p); //добавление p в список
			}
		}
	}
}