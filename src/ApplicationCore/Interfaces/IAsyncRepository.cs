﻿using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();
        Task<List<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
