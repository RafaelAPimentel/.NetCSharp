using System.Collections.Generic;
using System.Threading.Tasks;
using AutoLotDAL.Models;
using System;
using System.Data.Entity;

namespace AutoLotDAL.Repos
{
    public class CreditRiskRepo : BaseRepo<CreditRisk>, IRepo<CreditRisk>
    {
        public CreditRiskRepo()
        {
            Table = Context.CreditRisks;
        }
        public int Delete(int id, byte[] timestamp)
        {
            Context.Entry(new CreditRisk() { CustId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timestamp)
        {
            Context.Entry(new CreditRisk() { CustId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Task<List<CreditRisk>> ExecutQueryAsync(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
