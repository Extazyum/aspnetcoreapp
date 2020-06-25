using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreapp.Methods;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RandomNumberService _randomNumberServices;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,RandomNumberService randomNumberServices)
        {
            _logger = logger;
          _randomNumberServices= randomNumberServices;
          randomNumberServices.GetNext();
        }

        public void OnGet()
        {
        
        }
    }
}
