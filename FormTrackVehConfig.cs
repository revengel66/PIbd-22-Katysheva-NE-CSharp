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
    public partial class FormTrackVehConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle car = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddTransport;

        /// <summary>
        /// Добавление события
        /// </summary>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddTransport == null)
            {
                eventAddTransport = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddTransport += ev;
            }
        }

        public FormTrackVehConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelDarkBlue.MouseDown += panelColor_MouseDown;
            panelDarkGreen.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            buttonСancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 5, pictureBoxPreview.Width, pictureBoxPreview.Height);
                car.DrawTransport(gr);
                pictureBoxPreview.Image = bmp;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        private void labelTrackVeh_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrackVeh.DoDragDrop(labelTrackVeh.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        private void labelExcavator_MouseDown(object sender, MouseEventArgs e)
        {
            labelExcavator.DoDragDrop(labelExcavator.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        private void panelPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        private void panelPreview_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelTrackVeh":
                    car = new TrackedVehicle((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelExcavator":
                    car = new Excavator((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxBucket.Checked, checkBoxHandle.Checked, checkBoxArrow.Checked, checkBoxСounterweight.Checked);
                    break;
            }
            DrawCar();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null && car is Excavator)
            {
                (car as Excavator).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTransport?.Invoke(car);
            Close();
        }

    }
}
