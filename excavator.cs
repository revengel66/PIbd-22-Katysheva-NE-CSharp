using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KatyshevaExcavator
{
    class Excavator : TrackedVehicle { 
        public Color DopColor { private set; get; } /// Дополнительный цвет
        public bool Bucket { private set; get;} /// Признак наличия ковша
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
    }
}
