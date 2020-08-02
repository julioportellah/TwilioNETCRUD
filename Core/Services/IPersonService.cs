using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllPersons();
        Task<Person> GetPersonById(int id);
        Task<Person> CreatePerson(Person newPerson);
        Task UpdatePerson(Person personToBeUpdated, Person person);
        Task DeletePrerson(Person person);
    }
}
