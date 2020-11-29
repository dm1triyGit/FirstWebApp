using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyOrders.Data;
using MyOrders.Models;

namespace MyOrders.Pages.Orders
{
    public class ListModel : PageModel
    {
        private readonly MyOrders.Data.AppDbContext _context;

        public ListModel(MyOrders.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
