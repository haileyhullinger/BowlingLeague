using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public TeamViewComponent(BowlingLeagueContext con)
        {
            context = con;
        }
        public IViewComponentResult Invoke()
        {
            //for dynamic highlighting
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];

            //Select each unique team object to filter by
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
