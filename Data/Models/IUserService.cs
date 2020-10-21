using WebApplication.Data.Models;

namespace WebApplication.Data.Models
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}