using BE_forms.Models;
using BE_forms.Models.Registrationforms;

namespace BE_forms.Repository
{
    public interface IFormRepository
    {
        List<Language> languages();

        List<Country> countries();
        List<State> states();

        List<City> cities();

        List<Gender> Gender();

        List<State> GetState(int id);

        List<City> GetCity(int id);
    }
}