using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MisaCake_Store.Model;
using MisaCake_Store.Service.Login;

namespace MisaCake_Store.Pages.Shared
{
    public class loginModel : PageModel
    {
        public string err { get; set; }
        public UserAccount userAcc { get; set; }
        public void OnGet() //chạy khi nó vào login
        {
        }

        public void OnPostLogin(UserAccount user) //chạy khi mình gọi đến nó
        {
            loginService l = new loginService();
            userAcc = l.login(user).Result;
            err = "Error";
        }
    }
}
