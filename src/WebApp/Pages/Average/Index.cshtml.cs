using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Average
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IList<int> Numbers { get; set; } = new List<int>();
        public IActionResult OnPost()
        {
            var average = Numbers.Average();
            TempData["avg"] = average.ToString();
            return RedirectToPage("result");
        }


    }
}
