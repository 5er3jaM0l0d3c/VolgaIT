using Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IAccount
    {
        public void SignUp(Account account);
        public string SignIn(string username, string password);
        public void SignOut();
        public bool Validate(string accessToken);
        public string Refresh(string refreshToken);
        public Account Me(int id);
        public void Update(Account account);
        public List<Account> Accounts(int from, int count);
        public void Accounts(Account account);
        public void UpdateByAdmin(Account account);
        public void DeleteByAdmin(int id);
        public List<Account> Doctors();
        public Account DoctorId(int id);

        
    }
}
