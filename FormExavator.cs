using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatyshevaExcavator
{
    public partial class FormExavator : Form
    {
        private ITransport ex;
        public FormExavator()
        {
            InitializeComponent();
        }

        private void Draw() /// Метод отрисовки экскаватора
        {
            Bitmap bmp = new Bitmap(pictureBoxEx.Width, pictureBoxEx.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ex.DrawTransport(gr);
            pictureBoxEx.Image = bmp;
        }

        /// Обработка нажатия кнопки "Создать гусеничную машинаe"
        private void buttonCreateTrackedVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ex = new TrackedVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow);
            ex.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxEx.Width, pictureBoxEx.Height);
            Draw();
        }
        /// Обработка нажатия кнопки "Создать экскаватор"
        private void buttonCreateExcavator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ex = new Excavator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow, Color.Gray, true, true, true, true);
            ex.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxEx.Width,pictureBoxEx.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e) /// Обработка нажатия кнопок управления
        {
            string name = (sender as Button).Name;//получаем имя кнопки
            switch (name)
            {
                case "buttonUp":
                    ex.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ex.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ex.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ex.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
