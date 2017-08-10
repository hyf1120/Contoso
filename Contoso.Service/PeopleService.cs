using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;


namespace Contoso.Service
{
    public class PeopleService
    {
        PeopleRepository repository;
        public PeopleService()
        {
            repository = new PeopleRepository();
        }
        public List<People> GetAllPersons()
        {
            var people = repository.GetAll();
            return people;

        }
        public void SavePerson(People person)
        {      
            repository.Create(person);
        }
        public People GetById(int id)
        {
            return repository.GetById(id);
        }
        public void DeletePerson(int id)
        {
            repository.DeleteById(id);
        }
        public void UpdateById(People person)
        {
            repository.Update(person);
        }
    }
}
