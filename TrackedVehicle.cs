using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KatyshevaExcavator
{
    public class TrackedVehicle : Vehicle
    {
        protected readonly int trackedVehicleWidth = 210; /// Ширина отрисовки гусеничной машины
        protected readonly int trackedVehicleHeight = 250;/// Высота отрисовки гусеничной машины
        public TrackedVehicle(int maxSpeed, float weight, Color mainColor)//Конструктор
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// Конструкторс изменением размеров машины
        protected TrackedVehicle(int maxSpeed, float weight, Color mainColor, int trackedVehicleWidth, int trackedVehicleHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trackedVehicleWidth = trackedVehicleWidth;
            this.trackedVehicleHeight = trackedVehicleHeight;
        }
        public override void MoveTransport(Direction direction) /// Изменение направления пермещения
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - trackedVehicleWidth)
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
                    if (_startPosY + step < _pictureHeight - trackedVehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(MainColor);
            Brush brBlue = new SolidBrush(Color.Blue);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush brGray = new SolidBrush(Color.Gray);
            Pen pen = new Pen(Color.Black);
            g.FillRectangle(mainColor, _startPosX, _startPosY + 150, 150, 50); //Нижняя часть кузова
            g.DrawRectangle(pen, _startPosX, _startPosY + 150, 150, 50);
            g.FillRectangle(mainColor, _startPosX + 70, _startPosY + 100, 80, 90);//Верхняя часть кузова
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 100, 80, 90);
            g.FillRectangle(brBlue, _startPosX + 85, _startPosY + 110, 60, 60);//Окно
            g.DrawRectangle(pen, _startPosX + 85, _startPosY + 110, 60, 60);
            g.FillEllipse(brBlack, _startPosX + 0, _startPosY + 200, 50, 50); //Гусеничная тележка
            g.FillEllipse(brBlack, _startPosX + 160, _startPosY + 200, 50, 50);
            g.FillRectangle(brBlack, _startPosX + 25, _startPosY + 200, 160, 50);
            g.FillEllipse(brGray, _startPosX + 5, _startPosY + 205, 40, 40);
            g.FillRectangle(brGray, _startPosX + 50, _startPosY + 215, 110, 20);
            g.FillEllipse(brGray, _startPosX + 165, _startPosY + 205, 40, 40);
        }
    }
}