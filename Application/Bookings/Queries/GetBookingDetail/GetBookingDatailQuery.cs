﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Bookings.Queries.GetBookingDetail
{
    public class GetBookingDatailQuery : IRequest<BookingDatailVm>
    {
        public int Id { get; set; }
    }
}
