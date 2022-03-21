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

		internal bool IsHit(Figure figure) //метод для проверки столкновения, который берет объект класса
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p))

					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
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
