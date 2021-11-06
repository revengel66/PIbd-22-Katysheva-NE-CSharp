using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KatyshevaExcavator
{
    class Excavator
    {
        private float _startPosX; /// Левая координата отрисовки 
        private float _startPosY; /// Верхняя кооридната отрисовки 
        private int _pictureWidth; /// Ширина окна отрисовки
        private int _pictureHeight; /// Высота окна отрисовки
        private readonly int exWidth = 355; /// Ширина отрисовки екскаватора
        private readonly int exHeight = 250;/// Высота отрисовки екскаватора
        public int MaxSpeed { private set; get; }/// Максимальная скорость
        public float Weight { private set; get; }   /// Вес экскаватора
        public Color MainColor { private set; get; } /// Основной цвет
        public Color DopColor { private set; get; } /// Дополнительный цвет
        public bool Bucket { private set; get;} /// Признак наличия ковша
        public bool Handle { private set; get; } /// Признак наличия рукояти
        public bool Arrow { private set; get; } /// Признак наличия стрелы  
        public bool Tracked_vehicle { private set; get; } /// Признак наличия гусеничной тележки
        public bool Сounterweight { private set; get; }/// Признак наличия противовеса
        public void Initialization(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bucket, bool handle, bool arrow, bool tracked_vehicle, bool counterweight) /// Иницифализация свойств
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bucket = bucket;
            Handle = handle;
            Arrow = arrow;
            Tracked_vehicle = tracked_vehicle;
            Сounterweight = counterweight;
        }
        public void SetPosition(int x, int y, int width, int height) /// Установка позиции автомобиля
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;

        }
        public void MoveTransport(Direction direction) /// Изменение направления пермещения
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - exWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - exHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush dopColor = new SolidBrush(DopColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Black);
            if (Bucket) //Ковш
            {
                PointF[] bucket = {
                    new PointF(_startPosX + 350, _startPosY + 170),
                    new PointF(_startPosX +330,  _startPosY + 250),
                    new PointF(_startPosX +250,  _startPosY + 230),

                    new PointF(_startPosX +350,  _startPosY + 170)
                };
                g.FillPolygon(dopColor, bucket);
                g.DrawPolygon(pen, bucket);
            }
            if (Handle) { //Рукоять
                PointF[] handle = {
                    new PointF(_startPosX + 130, _startPosY + 120),
                    new PointF(_startPosX +240,  _startPosY + 0),
                    new PointF(_startPosX +340,  _startPosY + 20),
                    new PointF(_startPosX +320,  _startPosY + 50),
                    new PointF(_startPosX +250,  _startPosY + 60),
                    new PointF(_startPosX +140,  _startPosY + 150),
                    new PointF(_startPosX +130,  _startPosY + 120)
                };
                g.FillPolygon(mainColor, handle);
                g.DrawPolygon(pen, handle);
            }
            if (Arrow) //Стрела
            {
                PointF[] arrow = {
                    new PointF(_startPosX + 340, _startPosY + 20),
                    new PointF(_startPosX +350,  _startPosY + 170),
                    new PointF(_startPosX +340,  _startPosY + 170),
                    new PointF(_startPosX +320,  _startPosY + 50),
                    new PointF(_startPosX +340,  _startPosY + 20)
                };
                g.FillPolygon(mainColor, arrow);
                g.DrawPolygon(pen, arrow);
                g.FillEllipse(dopColor, _startPosX + 335, _startPosY + 160, 20, 20);
                g.DrawEllipse(pen, _startPosX + 335, _startPosY + 160, 20, 20);
            }
            g.FillRectangle(mainColor, _startPosX, _startPosY + 150, 150, 50); //Нижняя часть кузова
            g.DrawRectangle(pen, _startPosX, _startPosY + 150, 150, 50);
            g.FillRectangle(mainColor, _startPosX + 70, _startPosY + 100, 80, 90);//Верхняя часть кузова
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 100, 80, 90);
            g.FillRectangle(brBlue, _startPosX + 85, _startPosY + 110, 60, 60);//Окно
            g.DrawRectangle(pen, _startPosX + 85, _startPosY + 110, 60, 60);
            if (Сounterweight)
            {
                g.FillRectangle(dopColor, _startPosX+10, _startPosY + 130, 30, 20);
                g.DrawRectangle(pen, _startPosX+10, _startPosY + 130, 30, 20); //Противовес
            }
            if (Tracked_vehicle)
            {
                g.FillEllipse(brBlack, _startPosX + 0, _startPosY + 200, 50, 50); //Гусеничная тележка
                g.FillEllipse(brBlack, _startPosX + 160, _startPosY + 200, 50, 50);
                g.FillRectangle(brBlack, _startPosX + 25, _startPosY + 200, 160, 50);
                g.FillEllipse(brGray, _startPosX + 5, _startPosY + 205, 40, 40);
                g.FillRectangle(brGray, _startPosX + 50, _startPosY + 215, 110, 20);
                g.FillEllipse(brGray, _startPosX + 165, _startPosY + 205, 40, 40);
            }
        }
    }
}
