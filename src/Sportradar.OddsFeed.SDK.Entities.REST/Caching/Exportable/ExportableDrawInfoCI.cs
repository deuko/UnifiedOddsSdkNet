﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/

using System.Collections.Generic;
using Sportradar.OddsFeed.SDK.Entities.REST.Enums;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Caching.Exportable
{
    /// <summary>
    /// Class used to export/import draw info cache item properties
    /// </summary>
    public class ExportableDrawInfoCI
    {
        /// <summary>
        /// A <see cref="DrawType"/> representing the draw type
        /// </summary>
        public DrawType DrawType { get; }

        /// <summary>
        /// A <see cref="TimeType"/> representing the time type
        /// </summary>
        public TimeType TimeType { get; }

        /// <summary>
        /// A <see cref="string"/> representing the game type
        /// </summary>
        public string GameType { get; }
    }
}
