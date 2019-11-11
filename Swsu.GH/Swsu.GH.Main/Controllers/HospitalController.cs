using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Swsu.GH.Main.Models;

namespace Swsu.GH.Main.Controllers
{
    public class HospitalController : Controller
    {
        DHContext db = new DHContext();

        // GET: Hospital
        [HttpGet]
        public ActionResult GetCity(string city)
        {
            ViewBag.City = city;
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientInfo(Patient patient)
        {
            var newpatient = new Patient
            {
                Id = Guid.NewGuid(),
                Name = patient.Name,
                Surname = patient.Surname,
                Patronymic = patient.Patronymic,
                PhoneNumber = patient.PhoneNumber,
                PolicyNumber = patient.PolicyNumber,
                SnilsNumber = patient.SnilsNumber,
                BirthDate = patient.BirthDate,
                Sex = patient.Sex
            };

            db.Patients.Add(newpatient);
            db.SaveChanges();

            return View();
        }
    }
}