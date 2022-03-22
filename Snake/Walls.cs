using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> wallList; //создание списка со значениями типа класса Figure

		public Walls(int mapWidth, int mapHeight) //конструктор, который берет размер поля 
		{
			wallList = new List<Figure>(); //создание списка со значениями типа класса Figure

			//рамки уже описаны
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '▀');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '▄');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '▐');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '▐');

			wallList.Add(upLine); //добавление в список
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure) //метод, который берет значение типа класса Figure
		{
			foreach (var wall in wallList) //перебор списка wallList
			{
				if (wall.IsHit(figure)) //если "фигура" столкнулась со стеной, то 
				{
					return true; //возвращается true
				}
			}
			return false; // в ином случае false
		}

		public void Draw() //метод для отрисовки стен
		{
			foreach (var wall in wallList) //перебор списка
			{
				wall.Draw(); //отрисовка
			}
		}
	}
}
