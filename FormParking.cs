using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace KatyshevaExcavator
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection; /// Объект от класса-коллекции парковок
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDelPark_Click(object sender, EventArgs e) /// Обработка нажатия кнопки "Удалить парковку"
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку { listBoxParkings.SelectedItem.ToString()}");
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        /// Обработка нажатия кнопки "Забрать"
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxPark.Text != "")
            {
                try
                {
                    var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPark.Text);
                    if (car != null)
                    {
                        FormExavator form = new FormExavator();
                        form.SetVehicle(car);
                        form.ShowDialog();
                        logger.Info($"Изъят автомобиль {car} с места { maskedTextBoxPark.Text}");
                    }
                    Draw();
                }
                catch (ParkingNotFoundException ex)
                {
                    logger.Warn("Ошибка при удалении транспорта. Не найдено");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при удалении транспорта с парковки");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// Метод обработки выбора элемента на listBoxLevels
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку { listBoxParkings.SelectedItem.ToString()}");
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
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car != -1)
                    {
                        Draw();
                        logger.Info($"Добавлен автомобиль {car}");
                    }
                    else
                    {
                        MessageBox.Show("Транспорт не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn("Ошибка при добавлении транспорта. Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при добавлении транспорта");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogTransport.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    parkingCollection.SaveData(saveFileDialogTransport.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogTransport.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogTransport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialogTransport.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogTransport.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn("Ошибка при загрузке несуществующуго файла");
                    MessageBox.Show(ex.Message, "Такого файла не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileFormatException ex)
                {
                    logger.Warn("Ошибка при загрузке файла неверного формата");
                    MessageBox.Show(ex.Message, "Файл имеет неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (TypeLoadException ex)
                {
                    logger.Warn("Ошибка при загрузке объектов на стоянку. Неизвестный объект или переполнение");
                    MessageBox.Show(ex.Message, "Неизвестный объект или переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
