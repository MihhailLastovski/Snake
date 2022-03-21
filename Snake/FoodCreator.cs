using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator //класс создания еды
	{
		int mapWidht; //поле, которое берет значение ширины игрового поля
		int mapHeight; //поле, которое берет значение высоты игрового поля
		char sym; //поле, которое содержит один символ и этим символом будет еда на карте

		Random random = new Random(); //переменная класса Random

		public FoodCreator(int mapWidth, int mapHeight, char sym) //конструктор для создания еды, он берет ширину игрового поля, высоту игрового поля и символ
		{
			this.mapWidht = mapWidth; //ключевое слово this. используется для того, чтобы программа поняла, что обращаемся к полям, а не к аргументу
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public Point CreateFood() //метод создания еды, создает еду в случайной точке
		{
			int x = random.Next(2, mapWidht - 2); //задает случайное значение переменной с помощью рандома
			int y = random.Next(2, mapHeight - 2); //задает случайное значение переменной с помощью рандома
			return new Point(x, y, sym); //создает и возвращает новую точку, подставляя значение в конструктор Point
		}
	}
}
