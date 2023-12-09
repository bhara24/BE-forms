using BE_forms.Models.Registrationforms;

namespace BE_forms.Models
{
    public class SubmitForm
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
                        
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public int? Gender { get; set; }

        public List<Gender>? Genders { get; set; }

        public int CountryID { get; set; }
        public List<Country>? Country { get; set; }

        public int StateID { get; set; }
        public List<State>? State { get; set; }

        public int CityID { get; set; }
        public List<City>? city { get; set; }

        public List<int>? LanguageID { get; set; }
        public List<Language>? language { get; set; }

    }
}
