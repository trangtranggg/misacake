using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MisaCake_Store.Model;
using Newtonsoft.Json;

namespace MisaCake_Store.Pages.Product
{
    public class ProductModel : PageModel
    {
        [BindProperty] public int ItemId { get; set; }
        [BindProperty] public int Quantity { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }

        [BindProperty(SupportsGet =true)]
        public string ShowAll { get; set; }
        public List<Cake> listOurProduct { get; set; }
        public IActionResult OnGet()
        {
            CartItems = GetCartItemsSession();
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
        public IActionResult OnPostAdd()
        {
            Cake_SellerContext dao = new Cake_SellerContext();
            List<Cake> listCakes = dao.Cakes.ToList();
            Console.WriteLine("cart: ", CartItems.Count);
            CartItems = GetCartItemsSession();
            var cartItem = CartItems.FirstOrDefault(cartItem => cartItem.cake.CakeId == ItemId);
            Console.WriteLine("cartitem: ", cartItem);
            if (cartItem == null)
            {
                var item = listCakes.First(item => item.CakeId == ItemId);
                CartItems.Add(new CartItem(Quantity, item));
            }
            HttpContext.Session.SetString("CartList", JsonConvert.SerializeObject(CartItems));
            return RedirectToPage("/Product/Product");
        }
        
        public List<CartItem> GetCartItemsSession()
        {
            var cartItems = new List<CartItem>();
            if (HttpContext.Session.GetString("CartList") != null)
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(HttpContext.Session.GetString("CartList"));
            }
            return cartItems;
        }
    }
}
