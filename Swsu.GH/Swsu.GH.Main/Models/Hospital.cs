using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swsu.GH.Main.Models
{
    /// <summary>
    /// Модель таблицы "Hospitals"
    /// </summary>
    public class Hospital
    {
        /// <summary>
        /// Идентификатор больницы(Первичный ключ)
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название больницы
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Город расположения больницы
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Улица расположения больницы
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Номер здания больницы
        /// </summary>
        public int HouseNumber { get; set; }
        /// <summary>
        /// Индекс больницы
        /// </summary>
        public string Index { get; set; }
        /// <summary>
        /// Номер телефона больницы
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Время открытия больницы
        /// </summary>
        public DateTime? OpenTime { get; set; }
        /// <summary>
        /// Время закрытия больницы
        /// </summary>
        public DateTime? CloseTime { get; set; }
        /// <summary>
        /// ОГРН больницы
        /// </summary>
        public string OGRN { get; set; }
        /// <summary>
        /// ИНН больницы
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// Ссылка на докторов больницы
        /// </summary>
        public ICollection<Doctor> Doctors { get; set; }
        public Hospital()
        {
            Doctors = new List<Doctor>();
        }
    }
}