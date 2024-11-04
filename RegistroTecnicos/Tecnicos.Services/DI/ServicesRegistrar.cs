﻿using Microsoft.Extensions.DependencyInjection;
using RegistroTecnicos.Api.Tecnicos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnicos.Abstractions;
using Tecnicos.Domain.DI;

namespace Tecnicos.Services.DI;

public static class ServicesRegistrar
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.RegisterDbContextFactory();
        services.AddScoped<IClientesService, ClientesService>();
        return services;
    }
}
