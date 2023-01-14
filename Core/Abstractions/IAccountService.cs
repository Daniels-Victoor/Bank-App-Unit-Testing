using System.Collections.Generic;

namespace Core.Abstractions
{
    public interface IAccountService
    {
        decimal CheckBalance(string CustomerId, string AccountType);
        string ConfirmAcc(string accountNumber);
        bool CreateNewAccount(string CustomerId, string InitialAmount, string AccountType);
        string GenerateAccountNumber();
        string GeneratesAccountId();
        List<string> GetAccountById(string Id);
        string GetaccountByTypeandId(string Id, string type);
    }
}