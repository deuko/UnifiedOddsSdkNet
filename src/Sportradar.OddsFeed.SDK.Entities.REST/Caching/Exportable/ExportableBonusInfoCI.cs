﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/

using System.Collections.Generic;
using Sportradar.OddsFeed.SDK.Entities.REST.Enums;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Caching.Exportable
{
    /// <summary>
    /// Class used to export/import bonus info cache item properties
    /// </summary>
    public class ExportableBonusInfoCI
    {
        /// <summary>
        /// A <see cref="int"/> representing the bonus balls
        /// </summary>
        public int? BonusBalls { get; }

        /// <summary>
        /// A <see cref="BonusDrumType"/> representing the bonus drum type
        /// </summary>
        public BonusDrumType? BonusDrumType { get; }

        /// <summary>
        /// A <see cref="string"/> representing the bonus range
        /// </summary>
        public string BonusRange { get; }
    }
}
