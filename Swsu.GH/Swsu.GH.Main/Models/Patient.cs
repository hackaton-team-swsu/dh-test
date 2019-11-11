using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Swsu.GH.Main.Models
{
    public class Patient
    {
        /// <summary>
        /// Идентификатор пациента
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        [Display(Name = "Имя")]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пациента
        /// </summary>
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество пациента
        /// </summary>
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Номер полиса
        /// </summary>
        [Display(Name = "Полис")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// Снилс
        /// </summary>
        [Display(Name = "Снилс")]
        public string SnilsNumber { get; set; }

        /// <summary>
        /// Дата рождения пациента
        /// </summary>
        [Display(Name = "Дата рождения")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Пол пациента
        /// </summary>
        [Display(Name = "Пол")]
        public string Sex { get; set; }

        /// <summary>
        /// Идентификатор лечащего врача пациента
        /// </summary>
        public Guid? DoctorId { get; set; }

        /// <summary>
        /// Время записи на прием
        /// </summary>
        [Display(Name = "Время записи")]
        public DateTime? RecordTime { get; set; }

        /// <summary>
        /// Телефон пациента
        /// </summary>
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}