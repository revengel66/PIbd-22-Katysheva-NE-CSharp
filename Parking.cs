using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Collections;
namespace KatyshevaExcavator
{
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Parking<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places; /// Список объектов, которые храним

        private readonly int _maxCount;/// Максимальное количество мест на парковке
        private readonly int pictureWidth;/// Ширина окна отрисовки
        private readonly int pictureHeight;/// Высота окна отрисовки
        private readonly int _placeSizeWidth = 370;/// Размер парковочного места (ширина)
        private readonly int _placeSizeHeight = 260; /// Размер парковочного места (высота)
        /// <summary>
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];
        public Parking(int picWidth, int picHeight) /// Конструктор
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется машина
        /// </summary>
        public static int operator +(Parking<T> p, T car)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.Contains(car))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(car);
            return p._places.Count;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем машину
        /// </summary>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index >= p._places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            var car = p._places[index];
            p._places.RemoveAt(index);
            return car;
        }
        public void Draw(Graphics g) /// Метод отрисовки парковки
        {
            DrawMarking(g);
            int x = 5, y = 5;
            for (int i = 0; i < _places.Count; ++i)
            {
                if (i % (pictureWidth / _placeSizeWidth) == 0 && i != 0)
                {
                    y += 260;
                    x = 5;
                }
                _places[i]?.SetPosition(x, y, 1, 1);
                _places[i]?.DrawTransport(g);
                x += 370;
            }
        }
        private void DrawMarking(Graphics g) /// Метод отрисовки разметки парковочных мест
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        /// <summary>
        /// Функция получения элемента из списка
        /// </summary>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        /// <summary>
        /// Сортировка автомобилей на парковке
        /// </summary>
        public void Sort() => _places.Sort((IComparer<T>)new TrackedVehicleComparer());
        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        public bool MoveNext()
        {
            if (_currentIndex < _places.Count())
            {
                _currentIndex++;
                return true;
            }
            else return false;
        // Реализовать логику
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
