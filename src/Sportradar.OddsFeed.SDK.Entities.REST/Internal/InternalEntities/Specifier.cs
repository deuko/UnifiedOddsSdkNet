﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using Dawn;
using Sportradar.OddsFeed.SDK.Entities.REST.Internal.MarketNames;
using Sportradar.OddsFeed.SDK.Entities.REST.Market;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Internal.InternalEntities
{
    internal class Specifier : ISpecifier
    {
        /// <summary>
        /// Gets the name of the specifier represented by the current instance
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the type name of the specifier represented by the current instance
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Specifier"/> class.
        /// </summary>
        /// <param name="cacheItem">The cache item.</param>
        internal Specifier(MarketSpecifierCacheItem cacheItem)
        {
            Guard.Argument(cacheItem, nameof(cacheItem)).NotNull();

            Name = cacheItem.Name;
            Type = cacheItem.Type;

        }
    }
}
