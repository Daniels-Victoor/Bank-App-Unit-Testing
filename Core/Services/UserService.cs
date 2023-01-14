using Core.Abstractions;
using Core.Helper;
using Models;
using System.Collections.Generic;

namespace Core.Implimentations
{
    public class UserService : IUserService
    {
      
        readonly IAutheticationServices autheticationServices;
        readonly IFileWriteRead FileRepo;

        public UserService(IAutheticationServices autheticationServices, IFileWriteRead fileRepo)
        {
            this.autheticationServices = autheticationServices;
            FileRepo = fileRepo;

        }



        //Generates userId
        public string GenerateUserId()
        {
            return Utilities.GenerateRandomNumber(3, "alx");
        }

        //register a new user
        public string RegisterUser(string email, string password)
        {
            string UserId = "";

            string message = autheticationServices.checkEmpty(email, password);
            if (!Validators.ValidateEmail(email))
            {
                return message = "The email format is Invalid, please enter a valid email";
            }
            if (autheticationServices.EmailExist(email))
            {
                return message = "This email has already been registered please try using a different emial address";
            }
           
            UserId = GenerateUserId();
            string path = Files.UserLogin;
            List<string> data = new();
            UserModel user = new UserModel();
            user.UserId = UserId;
            user.UserEmail = email;
            user.UserPassword = password;
            data.Add($"{user.UserId},{user.UserEmail},{user.UserPassword}");
            FileRepo.WriteToFile(path, data);
            message = "OK";
            return message;
        }
    }
}
