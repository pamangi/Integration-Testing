using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain
{
    public interface ICustomerRepository : IGenericRepository<Domain.Customer>
    {
    }
}
