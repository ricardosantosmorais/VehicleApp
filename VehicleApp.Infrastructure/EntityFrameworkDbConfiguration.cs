using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.SqlClient;

namespace VehicleApp.Infrastructure
{
    internal sealed class EntityFrameworkDbConfiguration : DbConfiguration
    {
        /// <summary>
        /// The provider manifest token to use for SQL Server.
        /// </summary>
        private const string SqlServerManifestToken = @"2005";

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkDbConfiguration"/> class.
        /// </summary>
        public EntityFrameworkDbConfiguration()
        {
            this.AddDependencyResolver(new SingletonDependencyResolver<IManifestTokenResolver>(new ManifestTokenService()));
        }

        /// <inheritdoc />
        private sealed class ManifestTokenService : IManifestTokenResolver
        {
            /// <summary>
            /// The default token resolver.
            /// </summary>
            private static readonly IManifestTokenResolver DefaultManifestTokenResolver = new DefaultManifestTokenResolver();

            /// <inheritdoc />
            public string ResolveManifestToken(DbConnection connection)
            {
                if (connection is SqlConnection)
                {
                    return SqlServerManifestToken;
                }

                return DefaultManifestTokenResolver.ResolveManifestToken(connection);
            }
        }
    }
}
