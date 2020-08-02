using Core;
using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> CreatePerson(Person newPerson)
        {
            await unitOfWork.Persons
                .AddAsync(newPerson);
            await unitOfWork.CommitAsync();

            return newPerson;
        }

        public async Task DeletePrerson(Person person)
        {
            unitOfWork.Persons.Remove(person);

            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            return await unitOfWork.Persons.GetAllAsync();
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await unitOfWork.Persons.GetByIdAsync(id);
        }

        public async Task UpdatePerson(Person personToBeUpdated, Person person)
        {
            personToBeUpdated.Name = person.Name;

            await unitOfWork.CommitAsync();
        }
    }
}
