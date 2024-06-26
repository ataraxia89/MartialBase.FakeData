﻿using System;
using System.Collections.Generic;
using MartialBase.FakeData.Extensions;

namespace MartialBase.FakeData
{
    public static class Company
    {
        private static readonly IEnumerable<Func<string>> NameFormats = new List<Func<string>>
        {
            () => $"{FakeData.Name.Last()} {Suffix()}",
            () => $"{FakeData.Name.Last()}-{FakeData.Name.Last()}",
            () => $"{FakeData.Name.Last()}, {FakeData.Name.Last()} {Resources.Company.And} {FakeData.Name.Last()}"
        };

        public static string Name()
        {
            return NameFormats.Random();
        }

        public static string Suffix()
        {
            return Resources.Company.Suffix.Split(Config.Separator)
                .Random();
        }

        /// <summary>
        ///     Generate a buzzword-laden catch phrase.
        ///     Wordlist from http://www.1728.com/buzzword.htm
        /// </summary>
        public static string CatchPhrase()
        {
            return string.Join(" ", Resources.Company.Buzzwords1.Split(Config.Separator)
                    .Random(),
                Resources.Company.Buzzwords2.Split(Config.Separator)
                    .Random(),
                Resources.Company.Buzzwords3.Split(Config.Separator)
                    .Random());
        }

        /// <summary>
        ///     When a straight answer won't do, BS to the rescue!
        ///     Wordlist from http://dack.com/web/bullshit.html
        /// </summary>
        public static string BS()
        {
            return string.Join(" ", Resources.Company.BS1.Split(Config.Separator)
                    .Random(),
                Resources.Company.BS2.Split(Config.Separator)
                    .Random(),
                Resources.Company.BS3.Split(Config.Separator)
                    .Random());
        }
    }
}