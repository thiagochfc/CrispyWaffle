﻿using CrispyWaffle.Configuration;
using CrispyWaffle.Infrastructure;
using RabbitMQ.Client;
using System;
using IConnection = CrispyWaffle.Configuration.IConnection;

namespace CrispyWaffle.RabbitMQ.Utils.Communications
{
    /// <summary>
    /// Class RabbitMQConnector. This class cannot be inherited.
    /// </summary>
    [ConnectionName("RabbitMq")]
    public sealed class RabbitMQConnector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMQConnector"/> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public RabbitMQConnector(IConnection connection)
        : this(connection, "/", $"{EnvironmentHelper.ApplicationName}.logs")
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMQConnector"/> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="virtualHost">The virtual host.</param>
        /// <param name="defaultExchange">The default exchange.</param>
        /// <exception cref="ArgumentNullException">connection - A valid instance of {typeof(IConnection).FullName} is required to initialize {GetType().FullName}!</exception>
        public RabbitMQConnector(IConnection connection, string virtualHost, string defaultExchange)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            ConnectionFactory = new ConnectionFactory { HostName = connection.Host, Port = connection.Port };

            if (!string.IsNullOrWhiteSpace(connection.Credentials?.UserName))
            {
                ConnectionFactory.UserName = connection.Credentials.UserName;
            }

            if (!string.IsNullOrWhiteSpace(connection.Credentials?.Password))
            {
                ConnectionFactory.Password = connection.Credentials.Password;
            }

            ConnectionFactory.VirtualHost = virtualHost ?? throw new ArgumentNullException(nameof(defaultExchange));

            DefaultExchangeName = defaultExchange;
        }

        /// <summary>
        /// Gets the connection factory.
        /// </summary>
        /// <value>The connection factory.</value>
        public IConnectionFactory ConnectionFactory { get; }

        /// <summary>
        /// Gets the default name of the exchange.
        /// </summary>
        /// <value>The default name of the exchange.</value>
        public string DefaultExchangeName { get; }
    }
}