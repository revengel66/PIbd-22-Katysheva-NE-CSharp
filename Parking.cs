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
        private readonly int _placeSizeWidth = 300;/// Размер парковочного места (ширина)
        private readonly int _placeSizeHeight = 300; /// Размер парковочного места (высота)
        public Parking(int picWidth, int picHeight) /// Конструктор
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        public static bool operator +(Parking<T> p, T car)
        {
            // Прописать логику для сложения
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь 
        объект</param>
 /// <returns></returns>
 public static T operator -(Parking<T> p, int index)
        {
            // Прописать логику для вычитания
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
                68
        {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }


    }
}
