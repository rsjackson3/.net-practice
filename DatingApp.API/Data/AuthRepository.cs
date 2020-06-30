using System;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // this repository will query the db using Entity Framework
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext context;
        public AuthRepository(DataContext context)
        {
            this.context = context;

        }
        public async Task<User> Login(string username, string password)
        {
            var user = await this.context.Users.FirstOrDefaultAsync(x => x.Username == username); 
            // firstordefaultasync will return null if the username is not found 
            if (user == null){
                return null; 
            }

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                // this won't work, need to loop over byte array to compare 
                if (passwordHash == computedHash){
                    return true;
                }

                else {
                    return false; 
                }
            }
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt; 
            CreatePasswordHash(password, out passwordHash, out passwordSalt); // pass salt and hash by reference 

            user.PasswordHash = passwordHash; 
            user.PasswordSalt = passwordSalt; 

            await this.context.Users.AddAsync(user); // want to use await for any DB access 
            await this.context.SaveChangesAsync(); 

            return user; 
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())  // constructor randomly generates key, we will use as a salt
            {
                passwordSalt = hmac.Key; 
                // must convert password to byte array for parameter of ComputeHash function
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); 
                
            }
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}