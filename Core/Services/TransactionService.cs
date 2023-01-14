using Core.Abstractions;
using Core.Helper;
using Models;
using System;
using System.Collections.Generic;

namespace Core.Implimentations
{
    public class TransactionService : ITransactionService
    {
       
        private readonly IFileWriteRead fileWriteRead;
        private readonly IAccountService accountService;
        // private readonly ITransactionModel trans;

        public TransactionService( IFileWriteRead fileWriteRead, IAccountService accountService)
        {
            this.fileWriteRead = fileWriteRead;
            this.accountService = accountService;
            // this.trans = trans;
        }

        public string GenerateTransactionId()
        {
            return Utilities.GenerateRandomNumber(5, "FSN");
        }
        public bool InitilaDeposit(string CustomerId, string sender, string reciever, string InitialAmount)
        {
            //setting up data to write to the file
            string path = Files.TransactionPath;

            try
            {
                decimal depositamount = decimal.Parse(InitialAmount);

                string Transactiontype = "Initial Deposit";
                string description = "Account Opening";
                List<string> data = new List<string>();
                TransactionModel transModel = new TransactionModel(reciever, depositamount, description);
                data.Add($"{transModel.TransactionID},{reciever},{depositamount},{Transactiontype},{description}");
                fileWriteRead.WriteToFile(path, data);
                return true;
            }
            catch (FormatException)
            {

                return false;
            }
        }

        //deposit money to customer account
        public bool DepositToAccount(string reciever, string depositamount, string description)
        {
            try
            {
                decimal amount = decimal.Parse(depositamount);

                List<string> data = new List<string>();
                TransactionModel transModel = new TransactionModel(reciever, amount, description);
                string transactionId = transModel.TransactionID;
                //setting up transaction details

                data.Add($"{transactionId},{reciever},{depositamount},{transModel.DateOfTransaction},{description}");
                //adding a new transaction to the database
                string path = Files.TransactionPath;
                fileWriteRead.WriteToFile(path, data);
                return true;
            }
            catch (FormatException)
            {

              return false;
            }
        }

        /// this method withdraws from giving account
        public bool WithdrawFromAcc(string id, decimal amount, string description, string AccountType)
        {
            try
            {

                List<string> data = new List<string>();
                string AccountNumber = "";
                data = accountService.GetAccountById(id);
                foreach (var item in data)
                {
                    if (item.Split(",")[5] == AccountType)
                    {
                        AccountNumber = item.Split(",")[4];
                        break;
                    }
                }
                data.Clear();
                TransactionModel trans = new TransactionModel(AccountNumber, amount, description);
                data.Add($"{trans.TransactionID},{AccountNumber},{trans.Amount},{trans.DateOfTransaction},{trans.Description}");
                string path = Files.TransactionPath;
                fileWriteRead.WriteToFile(path, data);
                return true;
            }
            catch (FormatException)
            {

                return false;
            }
        }

        //transfers money

        public string transfer(string senderid, string recieverAccount, decimal amount, string description, string senderaccountType)
        {
            string senderAccNumber = accountService.GetaccountByTypeandId(senderid, senderaccountType);
            //setting withdrawal and deposit amount
            try
            {
                string message = "";
                string amountToTransfer = amount.ToString();
                string stringamount = amount.ToString();
                stringamount += "-";
                decimal amountToWithdraw = decimal.Parse(stringamount);
                if (senderAccNumber == recieverAccount)
                {
                    return message = "The sender's and reciever's account are the same you can not transfer to the same account";
                }
                else
                {
                    DepositToAccount(recieverAccount, amountToTransfer, description);
                    WithdrawFromAcc(senderid, amountToWithdraw, description, senderaccountType);
                    message = "OK";

                }
                return message;
            }
            catch (FormatException)
            {

                return "Wrong format";
            }
        }

        public List<string> GetAccountStatement(string Id, string AccountType)
        {
            List<string> data = new List<string>();
            List<string> accountStatement = new List<string>();
            string AccNumber = accountService.GetaccountByTypeandId(Id, AccountType);

            if (AccNumber == "")
            {
                accountStatement.Add($"You do not have a {AccountType} yet");
            }
            else
            {
                string path = Files.TransactionPath;
                data = fileWriteRead.ReadFile(path);
                if (data.Count < 1)
                {
                    return null;
                }
                else
                {
                    foreach (var item in data)
                    {
                        if (item.Split(",")[1] == AccNumber)
                        {
                            accountStatement.Add(item);
                        }
                    }
                }

            }
            return accountStatement;
        }
    }
}
