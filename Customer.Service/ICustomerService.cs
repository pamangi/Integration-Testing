using Customer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Service
{
    public interface ICustomerService
    {
        void CreateNew(CustomerDto customer);
        CustomerDto Update(CustomerDto customer);
        List<CustomerDto> GetAll();
        List<CustomerDto> GetByCityCode(string cityCode);
        CustomerDto GetById(Guid id);
    }
}
