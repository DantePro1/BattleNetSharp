﻿// Copyright (C) 2011 by Sherif Elmetainy (Grendiser@Kazzak-EU)
// Copyright (C) 2016 by Craig Trevor
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BattleNetSharp.Community.Wow
{
    /// <summary>
    ///   Represents a guild's profile
    /// </summary>
    [DataContract]
    public class Guild : ApiResponse
    {
        /// <summary>
        ///   Gets or sets the guild's name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; internal set; }

        /// <summary>
        ///   Gets or sets the guild's battlegroup name
        /// </summary>
        [DataMember(Name = "battlegroup", IsRequired = true)]
        public string BattleGroupName { get; internal set; }

        /// <summary>
        ///   Gets or sets the guild's realm
        /// </summary>
        [DataMember(Name = "realm", IsRequired = true)]
        public string Realm { get; internal set; }

        /// <summary>
        ///   Gets or sets the guild's emblem
        /// </summary>
        [DataMember(Name = "emblem", IsRequired = false)]
        public GuildEmblem Emblem { get; internal set; }

        /// <summary>
        ///   Gets or sets the guild's level
        /// </summary>
        [DataMember(Name = "level", IsRequired = true)]
        public int Level { get; internal set; }

        /// <summary>
        ///   gets or sets the guild's faction
        /// </summary>
        [DataMember(Name = "side", IsRequired = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Faction Faction { get; internal set; }

        /// <summary>
        ///   gets or sets the guild's total achievement points
        /// </summary>
        [DataMember(Name = "achievementPoints", IsRequired = true)]
        public int AchievementPoints { get; internal set; }

        /// <summary>
        ///   Gets or sets a list of all guild members
        /// </summary>
        [DataMember(Name = "members", IsRequired = false)]
        public IList<GuildMembership> Members { get; internal set; }

        /// <summary>
        ///   Gets or sets information about guild's achievements
        /// </summary>
        [DataMember(Name = "achievements", IsRequired = false)]
        public Achievements Achievements { get; internal set; }

        /// <summary>
        ///   gets or sets guild news feed
        /// </summary>
        [DataMember(Name = "news", IsRequired = false)]
        public IList<GuildNewsItem> News { get; internal set; }

        /// <summary>
        ///   gets or sets information about challenges completed by the guild
        /// </summary>
        [DataMember(Name = "challenge", IsRequired = false)]
        public IList<Challenge> Challenges { get; internal set; }

        /// <summary>
        ///   Gets string representation (for debugging purposes)
        /// </summary>
        /// <returns> Gets string representation (for debugging purposes) </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}