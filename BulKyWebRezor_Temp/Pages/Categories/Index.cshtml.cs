using BulKyWebRezor_Temp.Data;
using BulKyWebRezor_Temp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulKyWebRezor_Temp.Pages.Categories
{
    public class Index : PageModel
    {
         private readonly ApplicationDbContext _db;
        [BindProperty]
         public List<Category> CategoryList {get ; set;}
        public Index(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}