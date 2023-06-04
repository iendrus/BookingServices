﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection  AddInfrastructure (this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
