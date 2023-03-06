using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MisaCake_Store.Model;

namespace MisaCake_Store.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Cake> listOurProduct { get; set; }
        public List<Comment> listComment { get; set; }
        public List<UserAccount> listAccount { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Cake_SellerContext dao = new Cake_SellerContext();
            listOurProduct = dao.Cakes.Take(8).ToList();
            listAccount = dao.UserAccounts.ToList();
            listComment = dao.Comments.ToList();
        }
    }
}