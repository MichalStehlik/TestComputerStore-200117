using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerStore.Model;
using ComputerStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComputerStore
{
    public class CartModel : PageModel
    {
        public List<CartItem> Cart { get; set; } = new List<CartItem>();

        public CartModel()
        {
           
        }

        public void OnGet()
        {
            
        }
    }
}