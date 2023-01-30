using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;
        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        #region Métodos Síncronos

        public bool Insert(Customers customers)
        {
            return _customersRepository.Insert(customers);
        }

        public bool Update(Customers customers)
        {
            return _customersRepository.Update(customers);
        }
        public bool Delete(string customerId)
        {
            return _customersRepository.Delete(customerId);
        }

        public Customers Get(string customerId)
        {
            return _customersRepository.Get(customerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customersRepository.GetAll();
        }
        #endregion

        #region metodos asincronicos
        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customersRepository.InsertAsync(customers);
        }
        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customersRepository.UpdateAsync(customers);
        }

        public async Task<bool> DeleteAsync(string customersId)
        {
            return await _customersRepository.DeleteAsync(customersId);
        }

        public async Task<Customers> GetAsync(string customersId)
        {
            return await _customersRepository.GetAsync(customersId);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion
    }
}
