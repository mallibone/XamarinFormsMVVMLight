using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinFormsMVVMLight.Services.Person
{
    public interface IPeopleService
    {
        Task<IEnumerable<Model.Person>> GetPeople();
    }
}