using Customer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Service
{
    public interface ICustomerAssembler
    {
        Domain.Customer ToCustomer(CustomerDto customerDto);

        CustomerDto ToCustomerDto(Domain.Customer customer);
        List<CustomerDto> ToCustomerDtoList(List<Domain.Customer> customerList);
    }
}
