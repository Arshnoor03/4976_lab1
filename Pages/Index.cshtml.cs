using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab1.Models; // Import the namespace for the Utils class

namespace Lab1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int SelectedYear { get; set; }

        public string ZodiacSign { get; set; }

        public void OnGet()
        {
            // Initialize the page or handle initial GET requests if needed.
        }

        public void OnPost()
        {
            if (SelectedYear >= 1900 && SelectedYear <= (DateTime.Now.Year + 1))
            {
                ZodiacSign = Utils.GetZodiac(SelectedYear);
            }
            else
            {
                // Handle invalid input (year outside the allowed range).
                ZodiacSign = "Invalid input. Please enter a year between 1900 and " + (DateTime.Now.Year + 1) + ".";
            }
        }
    }
}
