using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Tip_Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            double amt=Double.Parse(Request.Form["amount"]);
            double percntg=Double.Parse(Request.Form["percentage"]);
            int num=Int32.Parse(Request.Form["number"]);
            double tip=(amt*percntg)/(100*num);
            double total=(amt+tip*num)/num;
            ViewData["individualTip"]=tip;
            ViewData["individualTotal"]=total;
        }
    }
}
