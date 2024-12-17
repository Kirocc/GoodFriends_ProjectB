using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppSammy.Pages.Shared
{
    public class FriendAndPets : PageModel
    {
        private readonly ILogger<FriendAndPets> _logger;

        public FriendAndPets(ILogger<FriendAndPets> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}