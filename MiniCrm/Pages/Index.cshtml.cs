using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniCrm.Data;
using MiniCrm.Models;
using MiniCrm.Pages.Shared;
using System.ComponentModel.DataAnnotations;

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

        public List<MiniCrm.Models.Customer> Customers { get; set; }

        [BindProperty]
        public Models.Customer NewCustomer { get; set; }

        public void OnGet()
        {
            Customers = _customerDataContext.Customers.ToList();
        }

        public async Task<IActionResult?> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _customerDataContext.Customers.Add(NewCustomer);
            await _customerDataContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}