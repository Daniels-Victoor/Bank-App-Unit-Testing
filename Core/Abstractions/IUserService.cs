namespace Core.Abstractions
{
    public interface IUserService
    {
        string GenerateUserId();
        string RegisterUser(string email, string password);
    }
}