using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerStore.Model;
using ComputerStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComputerStore.Pages
{
    public class IndexModel : PageModel
    {
        private MerchandiseSource _ms;

        public List<Merchandise> Collection { get; set; }
        public IndexModel(MerchandiseSource ms)
        {
            _ms = ms;
            
        }

        public void OnGet()
        {
            Collection = _ms.Offer;
        }

        public IActionResult OnGetBuy(int id)
        {
            
            /*var item = sel.Where(i => i.Id == id).SingleOrDefault();
            if (item == null)
            {
                
            }
            else
            {
                
            }
            */
            return RedirectToPage("Index");
        }
    }
}
