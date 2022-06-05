using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context; 
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio)); 
        }
    }
}