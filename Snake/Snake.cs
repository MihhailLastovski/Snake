using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
	class Snake : Figure
	{
		int a = 0;
		Direction direction; //переменная типа класса enum
		public Snake(Point tail, int length, Direction _direction, int a) //конструктор змейки, который берет значения: точку змейки(позиция и символ), длина, направление
		{
			
			direction = _direction; //переменная, которая равна направлению
			pList = new List<Point>(); //создание списка
			for (int i = 0; i < length; i++) //цикл пока i не будет равна длине змейки
			{
				Point p = new Point(tail); //создание точки
				p.Move(i, direction); //смещение точки 
				pList.Add(p); //добавление в список точки
			}
			
		}
		public int ScorePoint() 
		{
			a++; //прибавление очков
			Console.SetCursorPosition(70, 23); //установка позиции курсора
			Console.WriteLine($"Score: {a}"); //вывод
			return a;
		}
		public void Move() //метод движения 
		{
			Point tail = pList.First(); //хвост змейки ставится на первую позицию в списке
			pList.Remove(tail); //удаляется точка, которая раньше была хвостом
			Point head = GetNextPoint(); //создание точки(головы)
			pList.Add(head); //добавление головы

			tail.Clear(); //чистит хвост
			head.Draw(); //отрисовывает голову
		}

		public Point GetNextPoint() //метод для создания и передвижения змейки
		{
			Point head = pList.Last(); //создает точку, которая равна последней точке в списке
			Point nextPoint = new Point(head); //создает точку, которая равна голове
			nextPoint.Move(1, direction); //передвигает точку на 1, в заданном направлении
			return nextPoint; //возвращает точку
		}

		public bool IsHitTail() //метод для проверки столкнавения с хвостом
		{
			var head = pList.Last(); //создание переменной, которая равна последней точки в списке
			for (int i = 0; i < pList.Count - 2; i++) //цикл пока i не будет равна количеству значений в списке
			{
				if (head.IsHit(pList[i])) //если голова столкнулась с какой либо точкой, то 
					return true; //возвращает true
			}
			return false; //в ином случае false
		}

		public void HandleKey(ConsoleKey key) //метод для управления змейкой
		{
			//конструкция if
			if (key == ConsoleKey.LeftArrow) //если кнопка равна x, то направление становится равным x
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}
		public bool Eat(Point food) //метод для взаимодействия змейки с едой
		{
			Point head = GetNextPoint(); //создается очка 
			if (head.IsHit(food)) //если голова столкнулась с едой, то 
			{
				food.sym = head.sym; //символ еды становится равным символу головы
				pList.Add(food); //добавляется в список 
				return true; //возвращает true
			}
			else
				return false; //в ином случае false
		}

	}
}