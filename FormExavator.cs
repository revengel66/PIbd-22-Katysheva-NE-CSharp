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
        private Excavator ex;
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
        private void buttonCreate_Click(object sender, EventArgs e) /// Обработка нажатия кнопки "Создать
        {
            Random rand = new Random();
            ex = new Excavator();
            ex.Initialization(rand.Next(100, 300), rand.Next(1000, 2000), Color.Yellow, Color.Gray, true, true, true, true, true); 
            ex.SetPosition(rand.Next(10, 100), rand.Next(10, 100), pictureBoxEx.Width, pictureBoxEx.Height);
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
