using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KatyshevaExcavator
{
    public abstract class Vehicle : ITransport
    {
        protected float _startPosX; /// Левая координата отрисовки 
        protected float _startPosY; /// Верхняя кооридната отрисовки 
        protected int _pictureWidth; /// Ширина окна отрисовки
        protected int _pictureHeight; /// Высота окна отрисовки
        public int MaxSpeed { protected set; get; }/// Максимальная скорость
        public float Weight { protected set; get; }   /// Вес транспорта
        public Color MainColor { protected set; get; } /// Основной цвет
        public void SetPosition(int x, int y, int width, int height) /// Установка позиции транспорта
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
        public void Meth(int a)
        {

        }
    }

}
