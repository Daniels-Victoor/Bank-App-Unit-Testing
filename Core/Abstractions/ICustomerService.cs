using System.Collections.Generic;

namespace Core.Abstractions
{
    public interface ICustomerService
    {
        string addNewCustomer(List<string> CustomerDigits);
        string getCostumerByEmail(string email);
        string GetCustomerDetails(string CustomerId);
    }
}