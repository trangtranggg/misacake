using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MisaCake_Store.Model;

namespace MisaCake_Store.Pages.Product
{
    public class ProductModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string ShowAll { get; set; }
        public List<Cake> listOurProduct { get; set; }
        public IActionResult OnGet()
        {
            Console.WriteLine("showALL: ", ShowAll);
            Cake_SellerContext dao = new Cake_SellerContext();
            if (ShowAll == null)
            {
                listOurProduct = dao.Cakes.Take(8).ToList();
            }
            else
            {
                listOurProduct = dao.Cakes.ToList();
            }
            return Page();
        }
    }
}
