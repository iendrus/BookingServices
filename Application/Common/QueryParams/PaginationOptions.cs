using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Common.QueryParams
{
    public class PaginationOptions
    {
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public string sortBy { get; set; }
        public bool sortByDesc { get; set; }
    }
}
