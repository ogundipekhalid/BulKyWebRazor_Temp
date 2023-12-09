using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulKyWebRezor_Temp.Data;
using BulKyWebRezor_Temp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BulKyWebRezor_Temp.Pages.Categories
{
    [BindProperties]
    public class Edith : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category? Category { get; set; }
        public Edith(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}