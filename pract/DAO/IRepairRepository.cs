﻿using pract.Models;

namespace pract.DAO
{
    public interface IRepairRepository
    {
        IQueryable<Repair> GetAllRepair();
    }
}