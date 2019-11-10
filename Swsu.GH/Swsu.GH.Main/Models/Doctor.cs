using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swsu.GH.Main.Models
{
    public class Doctor
    {
        /// <summary>
        /// Идентификатор врача
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя врача
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия врача
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество врача
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Email врача
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Логин врача
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Пароль врача
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Номер телефона врача
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Время начала работы врача
        /// </summary>
        public DateTime OpenTime { get; set; }

        /// <summary>
        /// Время окончания работы врача
        /// </summary>
        public DateTime CloseTime { get; set; }

        /// <summary>
        /// Идентификатор больницы врача
        /// </summary>
        public Guid HospitalId { get; set; }

        /// <summary>
        /// Специализация врача
        /// </summary>
        public string Type { get; set; }


    }
}