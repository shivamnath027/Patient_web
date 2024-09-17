using System;
using System.Linq;
using System.Web.Mvc;
using PatientInformationSystem.Models;
using PagedList;
using PagedList.Mvc;

namespace PatientInformationSystem.Controllers
{
    public class HomeController : Controller
    {
        private PatientDBContext db = new PatientDBContext();

        public ActionResult Index()
        {
            ViewBag.MaritalStatusOptions = db.MaritalStatusOptions.ToList();
            ViewBag.GenderOptions = db.GenderOptions.ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Patient patient)
        {
            if (ModelState.IsValid)
            {
                var existingPatient = db.Patients.FirstOrDefault(p => p.EmailAddress == patient.EmailAddress || p.PhoneNumber == patient.PhoneNumber);
                if (existingPatient == null)
                {
                    db.Patients.Add(patient);
                    db.SaveChanges();
                    ViewBag.Message = "Data Saved Successfully";
                    ModelState.Clear();
                    patient = new Patient();
                }
                else
                {
                    ViewBag.Message = "Patient with the same Email or Phone Number already exists.";
                }
            }
            ViewBag.MaritalStatusOptions = db.MaritalStatusOptions.ToList();
            ViewBag.GenderOptions = db.GenderOptions.ToList();
            return View(patient);
        }

        /*
        public ActionResult ViewPatients()
        {
            var patients = db.Patients.ToList();
            if (!patients.Any())
            {
                ViewBag.Message = "No records are present.";
            }
            return View(patients);
        }
        */
        /*
        public ActionResult ViewPatients()
        {
            var patients = db.GetPatients();
            if (!patients.Any())
            {
                ViewBag.Message = "No records are present.";
            }
            return View(patients);
        }
        */
        [HttpPost]
        public ActionResult DeletePatient(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient != null)
            {
                db.Patients.Remove(patient);
                db.SaveChanges();
            }
            return RedirectToAction("ViewPatients");
        }

        public ActionResult ViewPatients(string searchString, DateTime? dateFrom, DateTime? dateTo, int? page)
        {
            var patients = from p in db.Patients
                           select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(s => s.Name.Contains(searchString));
            }

            if (dateFrom.HasValue)
            {
                patients = patients.Where(p => p.Date >= dateFrom.Value);
            }

            if (dateTo.HasValue)
            {
                patients = patients.Where(p => p.Date <= dateTo.Value);
            }

            // Add OrderBy clause to ensure the input is sorted
            patients = patients.OrderBy(p => p.ID);

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentFilter = searchString;
            ViewBag.CurrentDateFrom = dateFrom?.ToString("yyyy-MM-dd");
            ViewBag.CurrentDateTo = dateTo?.ToString("yyyy-MM-dd");

            var pagedPatients = patients.ToPagedList(pageNumber, pageSize);

            if (!pagedPatients.Any())
            {
                ViewBag.Message = "No Records Found";
            }

            return View(pagedPatients);
        }
// Writing this line to check if Push pull is working fine



    }
}
