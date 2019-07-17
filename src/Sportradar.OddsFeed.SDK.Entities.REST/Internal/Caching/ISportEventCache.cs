﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Sportradar.OddsFeed.SDK.Entities.REST.Internal.Caching.Events;
using Sportradar.OddsFeed.SDK.Messages;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Internal.Caching
{
    /// <summary>
    /// Defines a contract implemented by classes used to cache instances
    /// </summary>
    internal interface ISportEventCache : ISdkCache
    {
        /// <summary>
        /// Gets a <see cref="SportEventCI"/> instance representing cached sport event data
        /// </summary>
        /// <param name="id">A <see cref="URN"/> representing the id of the sport event which cached representation to return</param>
        /// <returns>a <see cref="SportEventCI"/> instance representing cached sport event data</returns>
        SportEventCI GetEventCacheItem(URN id);

        /// <summary>
        /// Asynchronous gets a <see cref="IEnumerable{URN}"/> containing id's of sport events, which belong to the specified tournament
        /// </summary>
        /// <param name="tournamentId">A <see cref="URN"/> representing the tournament identifier</param>
        /// <returns>A <see cref="Task{T}"/> representing an asynchronous operation</returns>
        Task<IEnumerable<Tuple<URN, URN>>> GetEventIdsAsync(URN tournamentId);

        /// <summary>
        /// Asynchronous gets a <see cref="IEnumerable{URN}"/> containing id's of sport events, which are scheduled for specified date
        /// </summary>
        /// <param name="date">The date for which to retrieve the schedule, or a null reference to get currently live events</param>
        /// <returns>A <see cref="Task{T}"/> representing an asynchronous operation</returns>
        Task<IEnumerable<Tuple<URN, URN>>> GetEventIdsAsync(DateTime? date);

        /// <summary>
        /// Adds fixture timestamp to cache so that the next fixture calls for the event goes through non-cached fixture provider
        /// </summary>
        /// <param name="id">A <see cref="URN"/> representing the event</param>
        void AddFixtureTimestamp(URN id);

        /// <summary>
        /// Asynchronously gets a list of active <see cref="IEnumerable{TournamentInfoCI}"/>
        /// </summary>
        /// <remarks>Lists all <see cref="TournamentInfoCI"/> that are cached (once schedule is loaded)</remarks>
        /// <param name="culture">A <see cref="CultureInfo"/> specifying the language or a null reference to use the languages specified in the configuration</param>
        /// <returns>A <see cref="Task{T}"/> representing the async operation</returns>
        Task<IEnumerable<TournamentInfoCI>> GetActiveTournamentsAsync(CultureInfo culture = null);
    }
}
