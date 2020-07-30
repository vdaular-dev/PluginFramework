﻿using System;
using Weikio.PluginFramework.Abstractions;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class PluginExtensions
    {
        public static T Create<T>(this Plugin plugin, IServiceProvider serviceProvider) where T : class
        {
            return ActivatorUtilities.CreateInstance(serviceProvider, plugin) as T;
        }
    }
}