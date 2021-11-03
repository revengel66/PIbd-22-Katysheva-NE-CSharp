using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace KatyshevaExcavator
{
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places; /// Массив объектов, которые храним
        private readonly int pictureWidth;/// Ширина окна отрисовки
        private readonly int pictureHeight;/// Высота окна отрисовки
        private readonly int _placeSizeWidth = 355;/// Размер парковочного места (ширина)
        private readonly int _placeSizeHeight = 250; /// Размер парковочного места (высота)
        public Parking(int picWidth, int picHeight) /// Конструктор
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется машина
        public static int operator +(Parking<T> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = car;
                    return i;
                }
            }
            return -1;
        }
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем машину
         public static T operator -(Parking<T> p, int index)
         {
            if (index < p._places.Length)
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }
        public void Draw(Graphics g) /// Метод отрисовки парковки
        {
            DrawMarking(g);
            int x = 5, y = 5;
            for (int i = 0; i < _places.Length; i++)
            {
                if (i % (pictureWidth / _placeSizeWidth) == 0 && i != 0)
                {
                    y += 250;
                    x = 5;
                }
                _places[i]?.SetPosition(x, y, 1, 1);
                _places[i]?.DrawTransport(g);
                x += 355;
            }
        }
        private void DrawMarking(Graphics g) /// Метод отрисовки разметки парковочных мест
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *_placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,(pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    } 
}
