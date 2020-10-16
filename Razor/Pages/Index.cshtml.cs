using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public double interest;
        
        private double myInterest;
        public double MyInterest{
            get
            {
                return myInterest;
            }
            set
            {
                myInterest=value;
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            double p = Double.Parse(Request.Form["fdamount"]);
            int t = Int32.Parse(Request.Form["period"]);
            double r = Double.Parse(Request.Form["interest"]);
            double si = p * (1 + r * t);
            ViewData["Amount"] = si;  // Returning using View Data
            interest=si;  //Returning using Model and public field
            MyInterest=si; //Returning using Model and property
        }
    }
}
