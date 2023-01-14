using Core.Abstractions;
using Core.Helper;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Implimentations
{
    public class AutheticationServices : IAutheticationServices
    {
        private readonly IFileWriteRead FileRepo;
        private readonly ICustomerService customerservice;


        public AutheticationServices( IFileWriteRead fileRepo, ICustomerService customerservice)
        {
            FileRepo = fileRepo;
            this.customerservice = customerservice;
        }



        /// this method validates for null login credentials
        public string checkEmpty(string email, string passowrd)
        {
            if (!String.IsNullOrEmpty(email))
            {
                if (!String.IsNullOrEmpty(passowrd))
                {
                    return "OK";
                }
                else
                {
                    return "The Password Field Is Empty Check And Try Again";
                }
            }
            else
            {
                return "The Email Field Is Empty Check And Try Again";
            }
        }


        public bool AuthLogInCredentails(string email, string password)
        {
            //removing data from the file
            string path = Files.UserLogin;
            List<string> data = new List<string>();
            data =  FileRepo.ReadFile(path);


            //checking for password in data
            foreach (var item in data)
            {
                if (item.Split(",")[1] == email)
                {
                    string testpass = item.Split(",")[2];
                    if (testpass == password)
                    {
                        return  true;
                    }
                }

            }
            return  false;
        }

        //Autenticate login
        public string LogIn(string email, string password)
        {
            string message = checkEmpty(email, password);

            try
            {
                if (message != "OK")
                {
                    return message;
                }
                if (!Validators.ValidateEmail(email))
                {
                    return "The E-mail is Invalid Please Use A Valid E-mail";
                }
                if (AuthLogInCredentails(email, password))
                {
                    return "OK";
                }
                else
                {
                    return "Incorrect login details";
                }

                return message = "Email does not exist";
            }
            catch (Exception ex)
            {
                return message = $"Error : {ex.Message}";
            }
        }

        //check for existing email

        public bool EmailExist(string email)
        {

            List<string> users = new List<string>();
            string path = Files.UserLogin;
            users = FileRepo.ReadFile(path);
            string EmailTest;

            foreach (var item in users)
            {
                EmailTest = item.Split(",")[0];
                if (EmailTest == email)
                {
                    return true;
                }
            }
            return false;
        }

        /// this method gets login user by id
        public string GetLoginUserById()
        {
            List<string> data = new List<string>();
            string path = Files.LoginSessionPath;
            data = FileRepo.ReadFile(path);
            string line = data[data.Count - 1];
            //getting logged in costumer email
            string id = line.Split(",")[0];

            return id;
        }

        //
        public void SetLog(string loginEmail)
        {
            string path = Files.LoginSessionPath;
            List<string> data = new List<string>();
            string line = customerservice.getCostumerByEmail(loginEmail).Trim();
            data.Add(line);
            FileRepo.WriteToFile(path, data);
        }

    }
}
