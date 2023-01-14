using Core.Abstractions;
using Core.Helper;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Implimentations
{
    public class CustomerService : ICustomerService
    {
        private IFileWriteRead FileRepo;



        public CustomerService( IFileWriteRead FileRepo)
        {

            this.FileRepo = FileRepo;
        }


        //Getting user id from the customerfile
        public string GetCustomerDetails(string CustomerId)
        {
            string path = Files.CustomerPath;
            List<string> CustomerData = new List<string>();
            CustomerData = FileRepo.ReadFile(path);
            string customer = "";
            foreach (var item in CustomerData)
            {
                if (item.Split(",")[0] == CustomerId)
                {
                    return customer = item;
                }
            }
            return customer;
        }

        //add new bank Customer
        public string addNewCustomer(List<string> CustomerDigits)
        {
            //Remove digits from firstName and change it to Titlecase
            CustomerDigits[0] = Utilities.RemoveDigits(CustomerDigits[0]);
            CustomerDigits[0] = Utilities.ChangeToTitle(CustomerDigits[0]);

            //Remove digits from the LastName and change it to Titlecase
            CustomerDigits[1] = Utilities.RemoveDigits(CustomerDigits[1]);
            CustomerDigits[1] = Utilities.ChangeToTitle(CustomerDigits[1]);

            //Generate Customer id
            string CustomerId = Utilities.GenerateCustomerId();

            //Adding Customer Id to CustomerDigits list
            CustomerDigits.Add(CustomerId);

            //Getting the email of the last added customer
            List<string> Data = new List<string>();
            string path = Files.UserLogin;
            Data = FileRepo.ReadFile(path);
            string item = Data[Data.Count - 1];
            string email = item.Split(",")[1];

            //instance of a customer

            Data.Clear();

            //setting and saving customer details
            path = Files.CustomerPath;

            CustomersModel customersModel = new CustomersModel(CustomerId, CustomerDigits[0], CustomerDigits[1], email, CustomerDigits[2]);
            customersModel.CostumerId = CustomerId;
            Data.Add($"{customersModel.CostumerId},{customersModel.FirstName},{customersModel.LastName},{customersModel.EmailAddress},{customersModel.PhoneNumber}");
            if (FileRepo.WriteToFile(path, Data))
            {
                return CustomerId;
            }
            return "Error";
        }

        public string getCostumerByEmail(string email)
        {
            string path = Files.CustomerPath;
            List<string> costdata = new List<string>();
            costdata =  FileRepo.ReadFile(path);
            
            string cost = "";

            foreach (var line in costdata)
            {
                if (line.Split(",")[3] == email)
                {
                    return cost = line;
                }

            }
            return cost;

        }
    }
}
