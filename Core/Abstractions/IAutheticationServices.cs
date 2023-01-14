namespace Core.Abstractions
{
    public interface IAutheticationServices
    {
        bool AuthLogInCredentails(string email, string password);
        string checkEmpty(string email, string passowrd);
        bool EmailExist(string email);
        string GetLoginUserById();
        string LogIn(string email, string password);
        void SetLog(string loginEmail);
    }
}