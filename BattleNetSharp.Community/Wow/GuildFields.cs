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

using System;

namespace BattleNetSharp.Community.Wow
{
    /// <summary>
    ///   An enumeration to control the guild profile fields to retrieve
    /// </summary>
    [Flags]
    public enum GuildFields
    {
        /// <summary>
        ///   None
        /// </summary>
        None = 0,

        /// <summary>
        ///   Members
        /// </summary>
        Members = 0x1,

        /// <summary>
        ///   Achievements
        /// </summary>
        Achievements = 0x2,

        /// <summary>
        ///   Feed
        /// </summary>
        News = 0x4,

        /// <summary>
        ///   Challenge
        /// </summary>
        Challenge = 0x8,

        /// <summary>
        ///   All fields
        /// </summary>
        All = 0xF
    }
}
