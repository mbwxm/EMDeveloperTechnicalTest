using DevelopmentTechnicalTestFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentTechnicalTest.Pages
{
    public class MakeAPaymentModel : PageModel
    {
        private readonly ILogger<MakeAPaymentModel> _logger;

        public MakeAPaymentModel(ILogger<MakeAPaymentModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public IActionResult OnPost()
        {
            var test = "";

            return Page();
        }
    }
}
