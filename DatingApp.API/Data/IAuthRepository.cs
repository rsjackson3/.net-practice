using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    // repository interface for authorization
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password); // register user, Task that returns User 
        Task<User> Login(string username, string password); 
        Task<bool> UserExists(string username); 

    }
}