﻿using Microsoft.Extensions.DependencyInjection;

using System;

namespace BuildingBlock.Sample.Configurations
{
    public abstract class SampleBuilderBase : ISampleBuilder
    {
        public IServiceCollection Services { get; }

        public SampleBuilderBase(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            Services = services;
        }
    }
}
