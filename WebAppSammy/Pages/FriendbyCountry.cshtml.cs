using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppSammy.Pages
{
    public class TestPage1 : PageModel
    {
        private readonly ILogger<TestPage1> _logger;

        public TestPage1(ILogger<TestPage1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}