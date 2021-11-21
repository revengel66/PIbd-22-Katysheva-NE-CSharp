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
        private readonly ParkingCollection parkingCollection; /// Объект от класса-коллекции парковок
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }
        private void ReloadLevels() /// Заполнение listBoxLevels
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        private void Draw()/// Метод отрисовки парковки
        {
            //если выбран один из пуктов в listBox (при старте программы ни
            //один пункт не будет выбран и может возникнуть ошибка, если мы
            //попытаемся обратиться к элементу listBox)
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonAddPark_Click(object sender, EventArgs e) /// Обработка нажатия кнопки "Добавить парковку"
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDelPark_Click(object sender, EventArgs e) /// Обработка нажатия кнопки "Удалить парковку"
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,  MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void ParkTracVehButton_Click(object sender, EventArgs e)/// Обработка нажатия кнопки "Припарковать гусеничную машину"
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tv = new TrackedVehicle(100, 1000, dialog.Color);
                if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + tv != -1)
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
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + ex != -1)
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
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxPark.Text != "")
            {
                var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPark.Text);
                if (car != null)
                {
                    FormExavator form = new FormExavator();
                    form.SetVehicle(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        /// Метод обработки выбора элемента на listBoxLevels
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить машину"
        /// </summary>
        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormTrackVehConfig();
            formCarConfig.AddEvent(AddTransport);
            formCarConfig.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        private void AddTransport(Vehicle car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + car != -11)
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
}
