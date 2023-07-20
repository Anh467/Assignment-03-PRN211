using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
namespace DataAccess.Repository
{
    public interface IOrderrRepository
    {
        public IEnumerable<Orderr> GetAll();
        public Orderr Get(int id);
        public void Delete(int id);
        public void Update(Orderr orderr);
        public void Insert(Orderr orderr);
    }
}
