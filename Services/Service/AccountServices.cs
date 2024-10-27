using Entities;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class AccountServices : IAccount
    {
        private AccountDbVolgaItContext context {  get; set; }
        public AccountServices(AccountDbVolgaItContext context)
        {
            this.context = context;
        }
        public List<Account> Accounts(int from, int count)
        {
            var accounts = context.account.ToList();
            return accounts.GetRange(from, count);
        }

        public void Accounts(Account account)
        {
            context.account.Add(account);
            context.SaveChanges();
        }

        public void DeleteByAdmin(int id)
        {
            var account = context.account.FirstOrDefault(x => x.id == id);
            context.account.Remove(account);
        }

        public Account DoctorId(int id)
        {
            return context.account.FirstOrDefault(x => x.id == id);
        }

        public List<Account> Doctors()
        {
            return context.account.Where(x => x.roleid == 3).ToList();
        }

        public Account Me(int id)
        {
            return context.account.FirstOrDefault(x => x.id == id);
        }

        public string Refresh(string refreshToken)
        {
            return refreshToken;
        }

        public string SignIn(string username, string password)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, username), new Claim(ClaimTypes.Name, password) };
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: "Client",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public void SignUp(Account account)
        {
            context.account.Add(account);
            context.SaveChanges();
        }

        public void Update(Account account)
        {
            context.account.Update(account);
            context.SaveChanges();
        }

        public void UpdateByAdmin(Account account)
        {
            context.account.Update(account);
        }

        public bool Validate(string accessToken)
        {
            return true;
        }
    }
}
