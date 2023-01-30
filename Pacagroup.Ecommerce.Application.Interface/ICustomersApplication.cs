using System;
using System.Collections.Generic;
using System.Text;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Metodos Sincronos
        Response<bool> Insert(CustomersDto customersDto);
        Response<bool> Update(CustomersDto customersDto);
        Response<bool> Delete(string customerId);

        Response<CustomersDto> Get(string customerId);
        Response<IEnumerable<CustomersDto>> GetAll();
        #endregion

        #region Metodos Asincronos
        Task<Response<bool>> InsertAsync(CustomersDto customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDto customersDto);
        Task<bool> DeleteAsync(string customerId);
        Task<Response<CustomersDto>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        #endregion
    }
}
