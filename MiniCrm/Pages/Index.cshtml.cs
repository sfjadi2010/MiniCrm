using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiniCrm.Data;
using MiniCrm.Models;
using MiniCrm.Pages.Shared;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MiniCrm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CustomerDataContext _customerDataContext;

        public IndexModel(ILogger<IndexModel> logger, CustomerDataContext customerDataContext)
        {
            _logger = logger;
            _customerDataContext = customerDataContext;
        }

        public List<Customer> Customers { get; set; }

        [BindProperty]
        public Customer Customer { get; set; }

        public void OnGet()
        {
            Customers = _customerDataContext
                .Customers
                .Include(c => c.Address)
                .ToList();
                
        }

        public async Task<IActionResult?> OnPost()
        {
            _customerDataContext.Customers.Add(Customer);
            await _customerDataContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}