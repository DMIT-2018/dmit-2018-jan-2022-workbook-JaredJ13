using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.SamplePges
{
    public class BasicsModel : PageModel
    {
        //basically this is an object, treat it as such

        //data fields
        public string MyName;

        //properties

        //constructors

        //behaviours (aka methods)
        public void OnGet()
        {
            //Executes in repsonse to a get request from the browser
            //when the page is "first" accessed, the browser issues a get request
            //When the page is refreshed, WITHOUT a post request, the browser issues a Get request
            //When the page is retrieved in response to a form's post using RedirectToPage()
            //If not redirectToPage() is used on the Post, there is no Get request issued

            //Server-side processing
            //contains no html

            Random rnd = new Random();
            int oddeven = rnd.Next(0, 25);
            if(oddeven % 2 == 0)
            {
                MyName = $"Don is even {oddeven}";
            }
            else
            {
                MyName = null;
            }
        }
    }
}
