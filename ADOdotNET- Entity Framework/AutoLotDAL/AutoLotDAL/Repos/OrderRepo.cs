using AutoLotDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos
{
    public class OrderRepo : BaseRepo<Order>, IRepo<Order>
    {
        public OrderRepo()
        {
            Table = Context.Orders;
        }
        public int Delete(int id, byte[] timestamp)
        {
            Context.Entry(new Order() { OrderId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timestamp)
        {
            Context.Entry(new Order() { OrderId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Task<List<Order>> ExecutQueryAsync(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
