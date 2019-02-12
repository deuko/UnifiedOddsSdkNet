﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/

// ReSharper disable InconsistentNaming
namespace Sportradar.OddsFeed.SDK.Entities
{
    /// <summary>
    /// Enumerates possible reasons why the odds-change was generated
    /// </summary>
    public enum OddsChangeReason
    {
        /// <summary>
        /// Indicates the message was generated by normal service execution
        /// </summary>
        NORMAL,

        /// <summary>
        /// Indicates the message was generated due to risk adjustment
        /// </summary>
        RISK_ADJUSTMENT,

        /// <summary>
        /// Indicates the message was generated because the feed system went down
        /// </summary>
        SYSTEM_DOWN
    }
}
