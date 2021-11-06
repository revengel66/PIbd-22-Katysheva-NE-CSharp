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
    public partial class FormParking : Form
    {
        private readonly Parking<TrackedVehicle> parking; /// Объект от класса-парковки

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<TrackedVehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()/// Метод отрисовки парковки
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void ParkTracVehButton_Click(object sender, EventArgs e)/// Обработка нажатия кнопки "Припарковать гусеничную машину"
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tv = new TrackedVehicle(100, 1000, dialog.Color);
                if (parking + tv != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// Обработка нажатия кнопки "Припарковать экскаватор"
        private void ParkExButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ex = new Excavator(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    if (parking + ex != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// Обработка нажатия кнопки "Забрать"
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPark.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxPark.Text);
                if (car != null)
                {
                    FormExavator form = new FormExavator();
                    form.SetVehicle(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
