using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Score //класс для подсчета очков
    {
        public int a = 0; //поле типа int
        public Score() //пустой конструктор
        {
        }
        public void Vivod() //метод вывода очков
        {
            a++; //прибавление очков
            Console.SetCursorPosition(70, 23); //установка позиции курсора
            Console.WriteLine($"Score: {a}"); //вывод
        }

    }
        
    
}
