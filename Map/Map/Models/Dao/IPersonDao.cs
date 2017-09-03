using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAO
{
    public interface IPersonDao
    {
        object Save(Person entity);

        void Update(Person entity);

        void Delete(Person entity);

        Person Get(object id);

        Person Load(object id);

        IList<Person> LoadAll();
    }
}
