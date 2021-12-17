using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KatyshevaExcavator
{
    class Excavator : TrackedVehicle, IEquatable<Excavator>
    {
        public Color DopColor { private set; get; } /// Дополнительный цвет
        public bool Bucket { private set; get; } /// Признак наличия ковша
        public bool Handle { private set; get; } /// Признак наличия рукояти
        public bool Arrow { private set; get; } /// Признак наличия стрелы  
        public bool Сounterweight { private set; get; }/// Признак наличия противовеса

        public Excavator(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bucket, bool handle, bool arrow, bool counterweight) : base(maxSpeed, weight, mainColor, 355, 250)
        {
            DopColor = dopColor;
            Bucket = bucket;
            Handle = handle;
            Arrow = arrow;
            Сounterweight = counterweight;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        public Excavator(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Bucket = Convert.ToBoolean(strs[4]);
                Handle = Convert.ToBoolean(strs[5]);
                Arrow = Convert.ToBoolean(strs[6]);
                Сounterweight = Convert.ToBoolean(strs[7]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(MainColor);
            Brush dopColor = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Black);

            if (Handle)
            { //Рукоять
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
                }
            }
            if (Сounterweight)
            {
                g.FillRectangle(dopColor, _startPosX + 10, _startPosY + 130, 30, 20);
                g.DrawRectangle(pen, _startPosX + 10, _startPosY + 130, 30, 20); //Противовес
            }
            base.DrawTransport(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Bucket}{separator}{Handle}{separator}{Arrow}{ separator}{ Сounterweight}";
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        public bool Equals(Excavator other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Bucket != other.Bucket)
            {
                return false;
            }
            if (Handle != other.Handle)
            {
                return false;
            }
            if (Arrow != other.Arrow)
            {
                return false;
            }
            if (Сounterweight != other.Сounterweight)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Excavator carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

    }
}
