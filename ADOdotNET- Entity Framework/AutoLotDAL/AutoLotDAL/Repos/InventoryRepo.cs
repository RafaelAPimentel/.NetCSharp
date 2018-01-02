﻿using AutoLotDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>, IRepo<Inventory>
    {
        public InventoryRepo()
        {
            Table = Context.Inventory;
        }
        public int Delete(int id, byte[] timestamp)
        {
            Context.Entry(new Inventory() { CarId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timestamp)
        {
            Context.Entry(new Inventory() { CarId = id, TimeStamp = timestamp }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Task<List<Inventory>> ExecutQueryAsync(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
