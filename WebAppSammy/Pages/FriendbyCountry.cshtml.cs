using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Models.DTO;
using Services;




namespace WebAppSammy.Pages
{
    public class FriendbyCountry : PageModel
    {
        private readonly ILogger<FriendbyCountry> _logger;

        private readonly IFriendsService _service;

        

        

        public FriendbyCountry(ILogger<FriendbyCountry> logger, IFriendsService service)
        {
            _logger = logger;
            _service = service;
        }

        public string City {get; set;}
        public List<string> Friends {get; set;}
        public int FriendsInSweden {get; set;}

        public async Task<IActionResult> OnGet()
        {
            GstUsrInfoAllDto Dbinfo = await _service.InfoAsync;
            
            FriendsInSweden =  Dbinfo.Friends.Where(f => f.Country == "Sweden").Sum(f => f.NrFriends);

            return Page();
        }
    }
}