using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Swsu.GH.Main.Models
{
    /// <summary>
    /// Класс контекста базы данных "DigitalHospital"
    /// </summary>
    public class DHContext: DbContext
    {
        public DHContext():base("HospitalContext") { }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
    }
}