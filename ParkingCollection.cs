using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatyshevaExcavator
{
    class ParkingCollection/// Класс-коллекция парковок
    {
        /// Словарь (хранилище) с парковками
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;/// Словарь (хранилище) с парковками
        public List<string> Keys => parkingStages.Keys.ToList(); /// Возвращение списка названий праковок
        private readonly int pictureWidth; /// Ширина окна отрисовки
        private readonly int pictureHeight;/// Высота окна отрисовки
        public ParkingCollection(int pictureWidth, int pictureHeight)///Конструктор
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)/// Добавление парковки
        {
            if (!parkingStages.ContainsKey(name)){
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
            get { 
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

    }
}
