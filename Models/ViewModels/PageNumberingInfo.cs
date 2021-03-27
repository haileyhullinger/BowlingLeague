using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumberItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //calculate the number of pages, casting from decimal to intiger to store in intiger. eliminates decimal page numbers
        public int NumPages => (int) (Math.Ceiling((decimal) TotalNumItems / NumberItemsPerPage));
    }
}
