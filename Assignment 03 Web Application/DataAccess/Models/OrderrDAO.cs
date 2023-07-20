using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class OrderrDAO
    {
        private static OrderrDAO instance = null;
        public static readonly object instanceLock = new object();
        private OrderrDAO() { }
        public static OrderrDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new OrderrDAO();
                    }
                return instance;
            }
        }
        public IEnumerable<Orderr> GetAll()
        {
            IEnumerable<Orderr> orderrs;
            try
            {
                 SaleManagementContext context = new SaleManagementContext();
                orderrs = context.Orderrs;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderrs;
        }
        public Orderr Get(int id)
        {
            Orderr orderr;
            try
            {
                 SaleManagementContext context = new SaleManagementContext();
                orderr = context.Orderrs.Where(x => x.OrderId == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderr;
        }
        public void Delete(int id)
        {
            try
            {
                 SaleManagementContext context = new SaleManagementContext();
                Orderr orderr= Get(id);
                if (orderr == null) throw new Exception("Orderr id not exist!!!");
                context.Orderrs.Remove(orderr);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Orderr orderr)
        {
            try
            {
                 SaleManagementContext context = new SaleManagementContext();
                context.Orderrs.Update(orderr);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Insert(Orderr orderr)
        {
            try
            {
                 SaleManagementContext context = new SaleManagementContext();
                context.Orderrs.Add(orderr);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

