﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviders
{
    public class ServiceProvidersVm
    {
        ICollection<ServiceProvidersDto> ServiceProviders { get; set; }
    }
}