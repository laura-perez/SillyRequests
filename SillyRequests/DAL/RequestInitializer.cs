using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SillyRequests.Models;
using WebGrease.Css.Extensions;

namespace SillyRequests.DAL
{
    public class RequestInitializer : DropCreateDatabaseIfModelChanges<RequestContext>
    {
        protected override void Seed(RequestContext context)
        {
            var testRequests = new List<Request>
            {
                new Request{Name = "Tintin", Question = "I don’t have any content. Can you just copy stuff from some of my competitor’s pages?", OccurenceDate = DateTime.Parse("2016-01-12")},
                new Request{Name = "Toto", Question = "Biscuit colour was fine on my monitor and her monitor but on his monitor it was too pink. Therefore please take all pink out of it.", OccurenceDate = DateTime.Parse("2015-09-01")},
                new Request{Name = "Lola", Question = "Can you make it look like it’s barking?", OccurenceDate = DateTime.Parse("2016-02-24")},
                new Request{Name = "Snowy", Question = "Can we use a lighter shade of black?", OccurenceDate = DateTime.Parse("2016-06-24")},
                new Request{Name = "Asterix", Question = "I want a back button on the web site because I don’t like the back button on the browser.", OccurenceDate = DateTime.Parse("2015-12-03")},
                new Request{Name = "Rocky", Question = "Can you make the site bigger? Its looks too small on this piece of paper.", OccurenceDate = DateTime.Parse("2016-04-22")},
            };

            testRequests.ForEach(r => context.Requests.Add(r));
            context.SaveChanges();
        }
    }
}