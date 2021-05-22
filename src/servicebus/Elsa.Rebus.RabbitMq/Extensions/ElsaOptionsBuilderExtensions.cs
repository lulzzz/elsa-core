﻿using Elsa.Services;
using Rebus.Config;

namespace Elsa.Rebus.RabbitMq.Extensions
{
    public static class ElsaOptionsBuilderExtensions
    {
        public static ElsaOptionsBuilder UseRabbitMq(this ElsaOptionsBuilder elsaOptions, string connectionString) => elsaOptions.UseServiceBus(context => ConfigureRabbitMqEndpoint(context, connectionString));
        private static void ConfigureRabbitMqEndpoint(ServiceBusEndpointConfigurationContext context, string connectionString) => context.Configurer.Transport(t => t.UseRabbitMq(connectionString, context.QueueName));
    }
}