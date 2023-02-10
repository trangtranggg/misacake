using Microsoft.EntityFrameworkCore;
using MisaCake_Store.Model;

namespace MisaCake_Store.Service.Login
{
    public class loginService
    {
        public async Task<UserAccount> login(UserAccount u)
        {
            var i = await DBContext.DBContext.Ins.DB.UserAccounts.Where(x => x.UserName.Equals(u.UserName) && x.Password.Equals(u.Password)).FirstOrDefaultAsync();
            return i;
        }
    }
}
