using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MisaCake_Store.Model;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace MisaCake_Store.Pages.Shared
{
    public class loginModel : PageModel
    {
        [BindProperty] public string email { get; set; }
        [BindProperty] public string password { get; set; }

        [BindProperty(SupportsGet = true)]
        public string err { get; set; }
        public void OnGet() //chạy khi nó vào login
        {
        }

        public ActionResult OnPostLogin() //chạy khi mình gọi đến nó
        {
            //TEST
            //return Redirect("Index");
            //
            Cake_SellerContext dao = new Cake_SellerContext();

            if (HttpContext.Session.GetString("user") != null)
            {
                return RedirectToPage("Dashboard", "Home");
            }

            var f_password = GetMD5(password);
            var curUser = dao.UserAccounts.FirstOrDefault(acc => acc.Email.Equals(email) && acc.Password.Equals(f_password));
            var _err = "";
            if (curUser != null)
            {
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(curUser));
                return RedirectToAction("", "Index");
            }
            else
            {
                _err = "Cannot login! Email or Password does not correct!";
            }

            return RedirectToPage($"login", new { err = _err });
        }


        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

    }

}
