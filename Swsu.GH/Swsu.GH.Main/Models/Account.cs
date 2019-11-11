using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Swsu.GH.Main.Models
{
    /// <summary>
    /// Аккаунт пользователя(не имеет таблицы в БД)
    /// </summary>
    public class Account
    {
        [Display(Name = "Введите имя пользователя")]
        public string UserName { get; set; }
        [Display(Name = "Введите пароль")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}