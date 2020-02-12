using System;
using StackExchange.Redis;

namespace RedisApiSrc
{
    public static class RedisHaFactory
    {
        private static readonly Lazy<ConnectionMultiplexer> Connection;
        /// <summary>
        /// Use EndPoint to connection.
        /// </summary>
        static RedisHaFactory()
        {
            ConfigurationOptions options = new ConfigurationOptions
            {
                EndPoints ={{ "127.0.0.1", 6379 },{ "127.0.0.1", 6380 }},
                DefaultDatabase = 10
            };
            Connection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(options));
        }

        public static ConnectionMultiplexer GetConnection => Connection.Value;
        public static IDatabase RedisDB => GetConnection.GetDatabase();
    }

    public static class RedisFactory6380
    {
        private static readonly Lazy<ConnectionMultiplexer> Connection;
        /// <summary>
        /// Use connectionString to connection.
        /// </summary>
        static RedisFactory6380()
        {
            //var connectionString = "127.0.0.1:6379,127.0.0.1:6380,DefaultDatabase=10";
            var connectionString = "127.0.0.1:6380,DefaultDatabase=10";
            var options = ConfigurationOptions.Parse(connectionString);
            Connection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(options));
        }

        public static ConnectionMultiplexer GetConnection => Connection.Value;
        public static IDatabase RedisDB => GetConnection.GetDatabase();
    }
}