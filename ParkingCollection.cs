using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KatyshevaExcavator
{
    class ParkingCollection/// Класс-коллекция парковок
    {
        /// Словарь (хранилище) с парковками
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;/// Словарь (хранилище) с парковками
        public List<string> Keys => parkingStages.Keys.ToList(); /// Возвращение списка названий праковок
        private readonly int pictureWidth; /// Ширина окна отрисовки
        private readonly int pictureHeight;/// Высота окна отрисовки
        private readonly char separator = ':';/// Разделитель для записи информации в файл
        public ParkingCollection(int pictureWidth, int pictureHeight)///Конструктор
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)/// Добавление парковки
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name) /// Удаление парковки
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<Vehicle> this[string ind] /// Доступ к парковке
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write($"ParkingCollection{Environment.NewLine}", fs);
                    foreach (var level in parkingStages)
                    {
                        //Начинаем парковку
                        sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                        foreach(ITransport car in level.Value)
                        {
                            if (car != null)
                            {
                                //если место не пустое
                                //Записываем тип машины
                                if (car.GetType().Name == "TrackedVehicle")
                                {
                                    sw.Write($"TrackedVehicle{separator}", fs);
                                }
                                if (car.GetType().Name == "Excavator")
                                {
                                    sw.Write($"Excavator{separator}", fs);
                                }
                                //Записываемые параметры
                                sw.Write(car + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string str = sr.ReadLine();
                if (str.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FileFormatException("Неверный формат файла");
                }
                Vehicle car = null;
                string key = string.Empty;

                while ((str = sr.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (str.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = str.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    if (str.Split(separator)[0] == "TrackedVehicle")
                    {
                        car = new TrackedVehicle(str.Split(separator)[1]);
                    }
                    else if (str.Split(separator)[0] == "Excavator")
                    {
                        car = new Excavator(str.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + car;
                    if (result==-1)
                    {
                          throw new TypeLoadException("Не удалось загрузить транспорт на стоянку");
                    }
                }
            }
        }
    }
}
