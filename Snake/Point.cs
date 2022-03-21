using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point : RndColor
	{
		
		public int x; //поле значение x 
		public int y; //поле значения y
		public char sym; //поле символа



		public Point(int x, int y, char sym) //конструктор, который берет 2 позиции на оси координат и символ точки 
		{
			this.x = x; //ключевое слово this. используется для того, чтобы программа поняла, что обращаемся к полям, а не к аргументу
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p) //конструктор, который берет объект типа Point и обновляет его значения
		{
			x = p.x; //заменяет старое значение на новое значение
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction) //метод движения
		{
			if (direction == Direction.RIGHT) //конструкция if для определения направления, если направление вправо, то переменную x увеличиваем на offset 
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}
		
		public bool IsHit(Point p)
		{
			Console.ForegroundColor = GetRandomConsoleColor();
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
			
			
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

	}
}
