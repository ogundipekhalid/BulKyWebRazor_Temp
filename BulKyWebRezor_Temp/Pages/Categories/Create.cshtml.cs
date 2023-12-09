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
    public class Create : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public Create(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
             _db.Categories.Add(Category);
             _db.SaveChanges();
                TempData["Sucess"] = "Category  Sucesfully Create";
            return RedirectToPage("Index");
        }
    }
}