using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_ASP.NET5.Model;

namespace Rest_ASP.NET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindBy(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
