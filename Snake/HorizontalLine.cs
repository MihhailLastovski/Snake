using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) //конструктор, принимающий значения точки от, который начнет отрисовываться линия xLeft и на какой точки заканчивается хRight. Также берет координату y, на которой символ будет нарисован и какой символ sym
		{
			pList = new List<Point>(); //создается список точек
			for (int x = xLeft; x <= xRight; x++) //цикл будет исполняться, пока xLeft не будет равен xRight
			{
				Point p = new Point(x, y, sym); //создание объекта p класса Point
				pList.Add(p); //добавление p в список
			}
		}
	}
}