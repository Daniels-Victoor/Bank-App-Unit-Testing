using Core.Abstractions;
using Core.Helper;
using Models;
using System;
using System.Collections.Generic;

namespace Core.Implimentations
{
    public class AccountService : IAccountService

    {
        readonly ICustomerService customerservice;
        readonly IFileWriteRead fileWriteRead;


        public AccountService(ICustomerService customerservice, IFileWriteRead fileWriteRead)
        {
            this.customerservice = customerservice;
            this.fileWriteRead = fileWriteRead;

        }

        // TransactionService transaction = new ();
        //Generates new account Number
        public string GenerateAccountNumber()
        {
          
                return Utilities.GenerateRandomNumber(7, "001");
   
        }

        //Generates account Id
        public string GeneratesAccountId()
        {
           return Utilities.GenerateRandomNumber(3, "ACC");
        }

 
        public bool CreateNewAccount(string CustomerId, string InitialAmount, string AccountType)
        {
           
                //Generates account Ids
                string AccountNumber = GenerateAccountNumber();
                string AccountId = GeneratesAccountId();

                //Gets customers details
                string CustomerData = "";
                CustomerData = customerservice.GetCustomerDetails(CustomerId);
                string FirstName = CustomerData.Split(",")[1];
                string LastName = CustomerData.Split(",")[2];

                //setting data to write to file

                AccountModel AccModel = new AccountModel(AccountId, CustomerId, FirstName, LastName, AccountType, AccountNumber);

                List<string> data = new List<string>();
                data.Add($"{AccModel.AccountID},{CustomerId},{AccModel.FirstName},{AccModel.LastName},{AccountNumber},{AccountType},{AccModel.DateOfOpening},{InitialAmount}");
                string path = Files.accountPath;
                fileWriteRead.WriteToFile(path, data);

                // registering the transaction
                // string description = "Opening Deposit";
                // trasactionService.DepositToAccount(AccountNumber, InitialAmount, description);
                return true;
           
           
        }

        public string ConfirmAcc(string accountNumber)
        {
          List<string> data = new List<string>();
                string ResultData = "";
                string path = Files.accountPath;
                data = fileWriteRead.ReadFile(path);

                foreach (var item in data)
                {
                    if (item.Split(",")[4] == accountNumber)
                    {
                        ResultData = $"{item.Split(",")[2]},{item.Split(",")[3]},{item.Split(",")[4]}";
                        return ResultData;
                    }
                }
                return ResultData;

          

        }
        //get all account of a user by email

        public List<string> GetAccountById(string Id)
        {
           
                string path = Files.accountPath;
                List<string> customerdata = new List<string>();
                customerdata = fileWriteRead.ReadFile(path);
                List<string> accountdetails = new List<string>();
                foreach (var item in customerdata)
                {
                    if (item.Split(",")[1] == Id)
                    {
                        if (item.Split(",")[5] == "Saving Account")
                        {
                            accountdetails.Add(item);
                        }
                        if (item.Split(",")[5] == "Current Account")
                        {
                            accountdetails.Add(item);
                        }
                    }
                }
                return accountdetails;
            
           
          
        }

        public string GetaccountByTypeandId(string Id, string type)
        {
            
                List<string> customerdata = new List<string>();
                string path = Files.accountPath;
                string accountNum = "";
                customerdata = fileWriteRead.ReadFile(path);
                foreach (var item in customerdata)
                {
                    if (item.Split(",")[1] == Id && item.Split(",")[5] == type)
                    {
                        return accountNum = item.Split(",")[4];
                    }
                }
                return accountNum;
            
           
        }


        public decimal CheckBalance(string CustomerId, string AccountType)
        {
           
                decimal balance = 0;
                string accountNumber = "";
                List<string> transactionList = new List<string>();
                accountNumber = GetaccountByTypeandId(CustomerId, AccountType);

                //getting all the transaction down by or on the account
                if (accountNumber == "")
                {
                    return 0;
                }
                else
                {
                    string path = Files.TransactionPath;
                    transactionList = fileWriteRead.ReadFile(path);

                    //calcualting transaction done on the account

                    if (transactionList.Count == 0)
                    {
                        balance = 0;
                    }
                    else
                    {
                        foreach (var item in transactionList)
                        {
                            if (item.Split(",")[1] == accountNumber)
                            {
                                string amount = item.Split(",")[2];
                                decimal addamount = Convert.ToDecimal(amount);
                                balance += addamount;
                            }
                        }
                    }

                }
                return balance;
            
           
        }


    }
}
