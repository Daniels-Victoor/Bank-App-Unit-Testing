using System;

namespace Models
{
    public class TransactionModel
    {

        public string TransactionID { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string DateOfTransaction { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
        public TransactionModel(string accountNumber, decimal amount, string description)
        {

            TransactionID = IdGen(1, 6);
            AccountNumber = accountNumber;
            Amount = amount;
            DateOfTransaction = DateTime.Now.ToString("dd-MM-yyyy");
            Description = description;
        }

        private string IdGen(int strat, int end)
        {
            Random random = new Random();
            string str = "JHs" + random.Next(strat, end).ToString();
            return str;
        }
    }
}
