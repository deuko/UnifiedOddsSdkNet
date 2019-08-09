﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/

using Sportradar.OddsFeed.SDK.Entities.REST.Enums;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Caching.Exportable
{
    /// <summary>
    /// Class used to export/import pitcher cache item properties
    /// </summary>
    public class ExportablePitcherCI
    {
        /// <summary>
        /// A <see cref="string" /> specifying the id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A <see cref="string" /> specifying the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A <see cref="PlayerHand" /> specifying the hand with which player pitches
        /// </summary>
        public PlayerHand Hand { get; set; }

        /// <summary>
        /// A <see cref="HomeAway" /> indicating if the competitor is Home or Away
        /// </summary>
        public HomeAway Competitor { get; set; }
    }
}
