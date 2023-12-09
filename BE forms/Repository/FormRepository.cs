using BE_forms.Models;
using BE_forms.Models.Registrationforms;
using Microsoft.AspNetCore.Mvc;

namespace BE_forms.Repository
{
    public class FormRepository:IFormRepository
    {
        public List<State> GetState(int id)
        {
            return states().Where(x=>x.CountryID == id).ToList();
        }

        public List<City> GetCity(int id)
        {
            return cities().Where(x => x.StateId == id).ToList();
        }

        //public List<SubmitForm> GetSubmitForm(SubmitForm submitForm) 
        //{
        //    if(submitForm != null)
        //    {
        //        GetSubmitForm().SaveChanges();
        //    }
        //    return new List<SubmitForm>() 
        //    {
        //        new SubmitForm() {Id =1, FirstName="Apple", Gender=1, CountryID= 1, StateID= 1, CityID=1}
        //    };
        
        //}

        //public SubmitForm Add(SubmitForm submitForm)
        //{

        //}


        public List<Language> languages()
        {
            return new List<Language>()
            {
                new Language() {Id =1, Languages ="Hindi"},
                new Language() {Id =2, Languages ="Telugu"},
                new Language() {Id =3, Languages ="English"}
            };
        }

        public List<Country> countries()
        {
            return new List<Country>()
            {
                new Country() {ID=1, Countries ="India"},
                new Country() {ID=2, Countries ="USA"},
                new Country() {ID=3, Countries ="Canada"}
            };
        }

        public List<State> states()
        {
            return new List<State>()
            {
                new State() {Id =1, CountryID=1, States="Andhra" },
                new State() {Id =2, CountryID =1, States="Telangana"},
                new State() {Id =3,CountryID =1,States ="Karnataka"},
                new State() {Id =4, CountryID =2, States="Texas"},
                new State() {Id =5, CountryID =2, States="Virigina"},
                new State() {Id =6, CountryID =2, States="NewYork"},
                new State() {Id =7, CountryID =3, States="Toronto"},
                new State() {Id =8, CountryID =3, States="Alberta"},
                new State() {Id =9, CountryID =3, States ="BritishColumbia"}
            };
        }

        public List<City> cities()
        {
            return new List<City>()
            {
                new City() { Id = 1, Cities = "Guntur", StateId = 1 },
                new City() { Id = 2, Cities = "Vijayawada", StateId = 1 },
                new City() { Id = 3, Cities = "Vizag", StateId = 1 },
                new City() { Id = 4, Cities = "Hyderabad", StateId = 2 },
                new City() { Id = 5, Cities = "Secunderabad", StateId = 2 },
                new City() { Id = 6, Cities = "Warangal", StateId = 2 },
                new City() { Id = 7, Cities = "Balari", StateId=3},
                new City() { Id = 8, Cities = "Bengaluru", StateId=3},
                new City() { Id = 9, Cities = "Mysore", StateId=3},
                new City() { Id = 10, Cities = "Texas1", StateId=4},
                new City() { Id = 11, Cities = "Texas2", StateId=4},
                new City() { Id = 12, Cities = "Texas3", StateId=4},
                new City() { Id = 13, Cities = "Virigina1", StateId=5},
                new City() { Id = 14, Cities = "Virigina2", StateId=5},
                new City() { Id = 15, Cities = "Virigina3", StateId=5},
                new City() { Id = 16, Cities = "NewYork1", StateId=6},
                new City() { Id = 17, Cities = "NewYork2", StateId=6},
                new City() { Id = 18, Cities = "NewYork3", StateId=6},
                new City() { Id = 19, Cities = "Toronto1", StateId=7},
                new City() { Id = 20, Cities = "Toronto2", StateId=7},
                new City() { Id = 21, Cities = "Toronto3", StateId=7},
                new City() { Id = 22, Cities = "Alberta1", StateId=8},
                new City() { Id = 23, Cities = "Alberta2", StateId=8},
                new City() { Id = 24, Cities = "Alberta3", StateId=8},
                new City() { Id = 25, Cities = "Alberta1", StateId=8},
                new City() { Id = 26, Cities = "BritishColumbia1", StateId=9},
                new City() { Id = 27, Cities = "BritishColumbia2", StateId=9},
                new City() { Id = 28, Cities = "BritishColumbia3", StateId=9}
            };
        }

        public List<Gender> Gender()
        {
            return new List<Gender>()
            {
                new Gender() { Id = 1, Genders ="Male"},
                new Gender() { Id = 2, Genders ="Female"}
            };
        }
    }
}
