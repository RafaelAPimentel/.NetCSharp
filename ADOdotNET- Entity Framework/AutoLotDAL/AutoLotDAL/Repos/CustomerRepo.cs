using AutoLotDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos
{
    public class CustomerRepo : BaseRepo<Customer>, IRepo<Customer>
    {
        public CustomerRepo()
        {
            Table = Context.Customer;
        }
        public int Delete(int id)
        {
            Context.Entry(new Customer() { CustId = id}).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Customer() { CustId = id }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Task<List<Customer>> ExecutQueryAsync(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
