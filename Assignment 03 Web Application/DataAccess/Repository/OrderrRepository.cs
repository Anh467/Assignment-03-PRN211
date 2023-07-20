using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderrRepository : IOrderrRepository
    {
        public void Delete(int id) => OrderrDAO.Instance.Delete(id);

        public Orderr Get(int id) => OrderrDAO.Instance.Get(id);

        public IEnumerable<Orderr> GetAll() => OrderrDAO.Instance.GetAll();

        public void Insert(Orderr orderr) => OrderrDAO.Instance.Insert(orderr);

        public void Update(Orderr orderr) => OrderrDAO.Instance.Update(orderr);
    }
}
