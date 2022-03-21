using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure 
	{
		protected List<Point> pList; //поле типа List, в котором будут содержаться значения типа Point. Protected -  по сути является закрытым полем, но его могут использовать классы наследники
		public void Draw() //метод отрисовки точек
		{
			foreach (Point p in pList) //отрисовывает каждое значение p из списка pList
			{

				p.Draw();
			}
		}

		internal bool IsHit(Figure figure) //метод для проверки столкновения, который берет объект типа класса Figure. Возвращает bool значение
		{
			foreach (var p in pList) //берет каждое значение из списка и приравнивает к p 
			{
				if (figure.IsHit(p)) //если фигура столкнулась с точко, то возвращает true, в ином случае false

					return true;
			}
			return false;
		}

		private bool IsHit(Point point) //метод для проверки столкновения, который берет объект типа класса Point. Возвращает bool значение
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
