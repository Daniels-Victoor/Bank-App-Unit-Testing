using System.Collections.Generic;

namespace Core.Abstractions
{
    public interface ITransactionService
    {
        bool DepositToAccount(string reciever, string depositamount, string description);
        string GenerateTransactionId();
        List<string> GetAccountStatement(string Id, string AccountType);
   
        bool InitilaDeposit(string CustomerId, string sender, string reciever, string InitialAmount);
        string transfer(string senderid, string recieverAccount, decimal amount, string description, string senderaccountType);
        bool WithdrawFromAcc(string id, decimal amount, string description, string AccountType);
    }
}