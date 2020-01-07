﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using System;
using System.Collections.Generic;
using Dawn;
using System.Globalization;
using Sportradar.OddsFeed.SDK.Entities.REST.Internal.DTO;

namespace Sportradar.OddsFeed.SDK.Entities.REST.Internal.Caching.CI
{
    /// <summary>
    /// Defines a cache item for season
    /// </summary>
    /// <seealso cref="SportEntityCI" />
    public class SeasonCI : SportEntityCI
    {
        /// <summary>
        /// A <see cref="IDictionary{CultureInfo, String}"/> containing season names in different languages
        /// </summary>
        private readonly IDictionary<CultureInfo, string> _name;

        /// <summary>
        /// Gets a <see cref="DateTime"/> specifying the start date of the season
        /// </summary>
        internal DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets a <see cref="DateTime"/> specifying the end date of the season
        /// </summary>
        internal DateTime EndDate { get; private set; }

        /// <summary>
        /// Gets the <see cref="string"/> representation the year of the season
        /// </summary>
        internal string Year { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonCI"/> class
        /// </summary>
        /// <param name="dto">The <see cref="SeasonDTO"/> used to create new instance</param>
        /// <param name="culture">A <see cref="CultureInfo"/> specifying the language of the season info</param>
        public SeasonCI(SeasonDTO dto, CultureInfo culture)
            : base(dto)
        {
            Guard.Argument(dto, nameof(dto)).NotNull();
            Guard.Argument(culture, nameof(culture)).NotNull();

            _name = new Dictionary<CultureInfo, string>();
            Merge(dto, culture);
        }

        /// <summary>
        /// Gets the name of the associated season in the specified language
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/> specifying the language in which to get the name</param>
        /// <returns>The name of the associated season in the specified language.</returns>
        public string GetName(CultureInfo culture)
        {
            Guard.Argument(culture, nameof(culture)).NotNull();

            return _name.ContainsKey(culture)
                ? _name[culture]
                : null;
        }

        /// <summary>
        /// Merges the information from the provided <see cref="SeasonDTO"/> to the current instance
        /// </summary>
        /// <param name="season">A <see cref="SeasonDTO"/> containing season info</param>
        /// <param name="culture">A <see cref="CultureInfo"/> specifying the language of the season info</param>
        public void Merge(SeasonDTO season, CultureInfo culture)
        {
            Guard.Argument(season, nameof(season)).NotNull();
            Guard.Argument(culture, nameof(culture)).NotNull();

            StartDate = season.StartDate;
            EndDate = season.EndDate;
            Year = season.Year;
            _name[culture] = season.Name;
        }

        /// <summary>
        /// Merges the information from the provided <see cref="SeasonDTO"/> to the current instance
        /// </summary>
        /// <param name="season">A <see cref="SeasonCI"/> containing season info</param>
        public void Merge(SeasonCI season)
        {
            Guard.Argument(season, nameof(season)).NotNull();

            StartDate = season.StartDate;
            EndDate = season.EndDate;
            Year = season.Year;
            foreach (var cultureName in season._name)
            {
                _name[cultureName.Key] = cultureName.Value;
            }
        }
    }
}
