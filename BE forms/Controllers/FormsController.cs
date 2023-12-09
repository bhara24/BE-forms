using BE_forms.ApplicationDbContext;
using BE_forms.Models;
using BE_forms.Models.Registrationforms;
using BE_forms.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BE_forms.Controllers
{
    public class FormsController : Controller
    {
        private readonly IFormRepository _formRepository;
        private readonly MyDatabaseContext _databaseContext;
        private readonly ILogger<FormsController> _logger;
        private static List<SubmitForm> inMemoryData = new List<SubmitForm>();
        public FormsController(ILogger<FormsController> logger,IFormRepository formRepository, MyDatabaseContext databaseContext)
        {
            _logger = logger;
            _formRepository = formRepository;
            _databaseContext = databaseContext;

        }
        public IActionResult table()
        {
            AddNewForm fm = new AddNewForm();
            try
            {
                fm.Genders = (_formRepository.Gender()).ToList();
                fm.language = (_formRepository.languages()).ToList();
                fm.Country = (_formRepository.countries()).ToList();
                fm.State = new List<State>();
                fm.city = new List<City>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "NewForm");
            }
            return View(fm);
        }

        [HttpPost]
        public IActionResult table(AddNewForm fm)
        {
            try
            {

                SubmitForm sm = new SubmitForm();

                sm.FirstName = fm.FirstName;
                sm.LastName = fm.LastName;
                sm.Genders = fm.Genders;
                sm.Country = fm.Country;
                sm.State = fm.State;
                sm.city = fm.city;
                SaveRecord(sm);
                //_databaseContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError("Submit", ex);
            }
            return View(fm);  
        }




        //public IActionResult NewForm() 
        //{ 
        //    AddNewForm fm = new AddNewForm();
        //    try
        //    {
        //        fm.Genders = ( _formRepository.Gender()).ToList();
        //        fm.language =(_formRepository.languages()).ToList();
        //        fm.Country =(_formRepository.countries()).ToList();
        //        fm.State = new List<State>();
        //        fm.city = new List<City>();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "NewForm");
        //    }
        //    return View(fm);
        //}

        public JsonResult GetStates(int CountryID)
        {
            var states = _formRepository.GetState(CountryID).ToList();
                return Json(states);
        }

        public JsonResult GetCities(int StateID)
        {
            var city = _formRepository.GetCity(StateID).ToList();
            return Json(city);
        }

        public IActionResult SaveRecord(SubmitForm record)
        {
            // Generate a new ID
            record.Id = GetNextId();

            // Save the record in-memory
            inMemoryData.Add(record);

            return RedirectToAction("table"); // Redirect to another action or view
        }

        private int GetNextId()
        {
            return inMemoryData.Count + 1; // This is just a simple example; use appropriate logic for generating IDs
        }

        public IActionResult Index()
        {
            // Use inMemoryData to display records or perform other operations
            var model = inMemoryData;
            return View(model);
        }


    }
}
