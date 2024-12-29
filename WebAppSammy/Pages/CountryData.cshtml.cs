using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppSammy.Pages
{
    public class CountryData : PageModel
    {
        private readonly ILogger<CountryData> _logger;

        public CountryData(ILogger<CountryData> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}