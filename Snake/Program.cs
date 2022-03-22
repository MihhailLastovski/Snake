using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Snake
{
	class Program
	{

		static void Main(string[] args)
		{
			while (true) //бесконечный цикл
			{
				Menu menu = new Menu(); //создание объекта класса Menu
				menu.Main(); //вызов метода
				Score score = new Score(); //создание объекта класса Score
				Params param = new Params(); //создание объекта класса Params
				Sound soundtheme = new Sound(param.GetResourceFolder()); //создание объекта класса Sound, который берет метод из класса Params, для получения директории файла
				soundtheme.Play(); //вызов метода
				Sound soundeat = new Sound(param.GetResourceFolder());
				Sound sounddead = new Sound(param.GetResourceFolder());
				Console.SetWindowSize(80, 25); //установка размера окна

				Walls walls = new Walls(80, 25); //установка размера стен

				walls.Draw(); //отрисовка стен
				Console.SetCursorPosition(70, 23); //установка позиции курсора, для вывода текста в определенном месте
				Console.WriteLine($"Счет: 0");

				//точки			
				Point p = new Point(4, 5, '~'); //создание точки для змейки, берет значения: позиция на оси x, y и символ
				Snake snake = new Snake(p, 4, Direction.RIGHT); //создание змейки, берет значения: точка p, позиция на оси y, направление движения
				snake.Draw(); //отрисовка змейки

				FoodCreator foodCreator = new FoodCreator(80, 25, '#'); //создание еды, берет значения: размеры игрового поля и символ
				Point food = foodCreator.CreateFood(); //создания объекта класса Point и использует метод для создания еды в рандомном месте
				food.Draw(); //отрисовка еды

				while (true) //бесконечный цикл
				{
					//конструкция if
					if (walls.IsHit(snake) || snake.IsHitTail()) //если змейка столкнулась со стенкой, или змейка столкнулась сама с собой, то
					{
						sounddead.Deads(); //проигрывается звук смерти
						soundtheme.VolumePlay(); //изменяется громкость фоновой музыки на 0
						break; //конец цикла
					}
					if (snake.Eat(food)) //если змейка съела еду, то
					{
						score.Vivod(); //выводится новое значение счета
						soundeat.PlayEat(); //проигрывается звук поедания
						food = foodCreator.CreateFood(); //создается новая еда
						food.Draw(); //отрисовывается новая еда
					}
					else //в ином случае
					{
						snake.Move(); //метод для движения змейки
					}

					System.Threading.Thread.Sleep(100); //таймер перед изменением направления
					if (Console.KeyAvailable) //если кнопка нажата, то
					{
						ConsoleKeyInfo key = Console.ReadKey(); //задаеися новоное значение для переменной key
						snake.HandleKey(key.Key); //изменение направления змейки на основе переменной key
					}
				}
				GameOver gameOver = new GameOver(); //создание объекта класса GameOver
				gameOver.WriteGameOver(); //использование метода
				Console.ReadLine(); //ожидание нажатия
				Clear(); //очистка
				Console.ForegroundColor = ConsoleColor.White; //изменение цвета
			}
			

		}



	}
}