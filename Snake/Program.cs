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
			while (true) 
			{
				Menu menu = new Menu();
				menu.Main();
				Score score = new Score();
				Params param = new Params();
				Sound soundtheme = new Sound(param.GetResourceFolder());
				soundtheme.Play();
				Sound soundeat = new Sound(param.GetResourceFolder());
				Sound sounddead = new Sound(param.GetResourceFolder());
				Console.SetWindowSize(80, 25);

				Walls walls = new Walls(80, 25);

				walls.Draw();
				Console.SetCursorPosition(70, 23);
				Console.WriteLine($"Счет: 0");

				//точки			
				Point p = new Point(4, 5, '~');
				Snake snake = new Snake(p, 4, Direction.RIGHT);
				snake.Draw();

				FoodCreator foodCreator = new FoodCreator(80, 25, '#');
				Point food = foodCreator.CreateFood();
				food.Draw();

				while (true)
				{
					if (walls.IsHit(snake) || snake.IsHitTail())
					{
						sounddead.Deads();
						soundtheme.VolumePlay();
						break;
					}
					if (snake.Eat(food))
					{
						score.Vivod();
						soundeat.PlayEat();
						food = foodCreator.CreateFood();
						food.Draw();
					}
					else
					{
						snake.Move();
					}

					System.Threading.Thread.Sleep(100);
					if (Console.KeyAvailable)
					{
						ConsoleKeyInfo key = Console.ReadKey();
						snake.HandleKey(key.Key);
					}
				}
				GameOver gameOver = new GameOver();
				gameOver.WriteGameOver();
				Console.ReadLine();
				Clear();
				Console.ForegroundColor = ConsoleColor.White;
			}
			

		}



	}
}