using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        // объявим поля double a, b.
        double a, b;

        // Конструктор, позволяющий создать экземпляр класса с одним параметром, задающим сторону квадрата.
        public Rectangle(double a)
        {
            this.a = a;
        }

        // Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        // метод вывода длин сторон прямоугольника на экран.
        public void ShowLength()
        {
            Console.WriteLine("Стороны прямоугольника: a = {0}, b = {1}", a, b);
        }

        // метод рассчитывающий периметр прямоугольника.
        public double Perimeter()
        {
            return (a + b) * 2;
        }

        // метод рассчитывающий площадь прямоугольника.
        public double Area()
        {
            return a * b;
        }

        // свойства получить-установить длины сторон прямоугольника (доступное для чтения и записи).
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        // свойства позволяющее установить, является ли данный прямоугольник квадратом (доступное только для чтения).
        public bool Square
        {
            get
            {
                if (a == b)
                    return true;
                return false;
            }
        }

        //Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, при других значениях индекса выдается сообщение об ошибке.
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return a;
                    case 1:
                        return b;
                    default:
                        throw new Exception("Error");
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}