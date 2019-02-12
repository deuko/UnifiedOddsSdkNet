﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using System.Diagnostics.Contracts;
using Sportradar.OddsFeed.SDK.Entities.REST.Internal.DTO;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Internal.Caching.CI
{
    /// <summary>
    /// An implementation of Jersey cache item
    /// </summary>
    public class JerseyCI
    {
        public string BaseColor { get; }

        public string Number { get; }

        public string SleeveColor { get; }

        public string Type { get; }

        public bool? HorizontalStripes { get; }

        public bool? Split { get; }

        public bool? Squares { get; }

        public bool? Stripes { get; }

        public JerseyCI(JerseyDTO item)
        {
            Contract.Requires(item != null);

            BaseColor = item.BaseColor;
            Number = item.Number;
            SleeveColor = item.SleeveColor;
            Type = item.Type;
            HorizontalStripes = item.HorizontalStripes;
            Split = item.Split;
            Squares = item.Squares;
            Stripes = item.Stripes;
        }
    }
}
