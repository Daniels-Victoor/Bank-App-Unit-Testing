using System;

namespace Models
{
    public class AccountModel
    {
        public string AccountID { get; set; }
        public string CostumerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public DateTime DateOfOpening { get; set; } = DateTime.Now;

        public AccountModel(string accountID, string costumerId, string firstName, string lastName, string accountType, string accountNumber)
        {
            AccountID = accountID;
            CostumerId = costumerId;
            FirstName = firstName;
            LastName = lastName;
            AccountType = accountType;
            AccountNumber = accountNumber;

        }
    }
}
