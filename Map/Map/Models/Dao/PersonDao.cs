using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace DAO
{
    public class PersonDao:IPersonDao
    {
        private ISessionFactory sessionFactory;

        public PersonDao()
        {
            var cfg = new NHibernate.Cfg.Configuration().Configure(System.AppDomain.CurrentDomain.BaseDirectory + "hibernate.cfg.xml");
            sessionFactory = cfg.BuildSessionFactory();
        }

        public object Save(Domain.Person entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                var id = session.Save(entity);
                session.Flush();
                return id;
            }
        }

        public void Update(Domain.Person entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Update(entity);
                session.Flush();
            }
        }

        public void Delete(Domain.Person entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
            }
        }

        public Domain.Person Get(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Get<Domain.Person>(id);
            }
        }

        public Domain.Person Load(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Load<Domain.Person>(id);
            }
        }

        public IList<Domain.Person> LoadAll()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Query<Domain.Person>().ToList();
            }
        }
    }
}
