using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Interfaces
{
    public interface IOmdbClient
    {
        Task<string> GetMovie(string searchFilter, CancellationToken cancellationToken);
    }
}
