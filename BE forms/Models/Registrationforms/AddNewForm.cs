using Microsoft.AspNetCore.Mvc.Razor;

namespace BE_forms.Models.Registrationforms
{
    public class AddNewForm
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Phone { get; set; } = "";

        public int Gender { get; set; } = 0;

        public List<Gender>? Genders { get; set; } = new List<Gender>();

        public int CountryID { get; set; } = 0;
        public List<Country> Country { get; set; } = new List<Country>(); 

        public int StateID { get; set; } = 0;
        public List<State> State { get; set; } = new List<State>();

        public int CityID { get; set; } = 0;
        public List<City> city { get; set; } = new List<City>();

        public List<int>? LanguageID { get; set; }
        public List<Language> language { get; set; } = new List<Language>();

    
    }
}
