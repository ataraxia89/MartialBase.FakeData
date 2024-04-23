using System;
using System.Collections.Generic;
using System.Linq;
using MartialBase.FakeData.Extensions;

namespace MartialBase.FakeData
{
    public enum NameFormats
    {
        Standard,
        StandardWithMiddle,
        StandardWithMiddleWithPrefix,
        StandardWithMiddleWithPrefixWithSuffix,
        StandardWithMiddleWithSuffix,
        WithPrefix,
        WithSuffix,
        WithPrefixWithSuffix
    }

    public static class Name
    {
        private static readonly IEnumerable<NameFormats> Formats = new List<NameFormats>
        {
            NameFormats.WithPrefix, NameFormats.WithSuffix, NameFormats.Standard, NameFormats.Standard,
            NameFormats.WithPrefixWithSuffix,
            NameFormats.Standard, NameFormats.Standard, NameFormats.Standard, NameFormats.Standard,
            NameFormats.Standard, NameFormats.StandardWithMiddleWithPrefix,
            NameFormats.StandardWithMiddleWithPrefixWithSuffix, NameFormats.StandardWithMiddleWithSuffix
        };

        private static IDictionary<NameFormats, Func<string[]>> FormatMap(char sex)
        {
            return new Dictionary<NameFormats, Func<string[]>>
            {
                {NameFormats.Standard, () => new[] {First(sex), Last()}},
                {NameFormats.StandardWithMiddle, () => new[] {First(sex), Middle(sex), Last()}},
                {NameFormats.StandardWithMiddleWithPrefix, () => new[] {Prefix(sex), First(sex), Middle(sex), Last()}},
                {NameFormats.StandardWithMiddleWithSuffix, () => new[] {First(sex), Middle(sex), Last(), Suffix()}},
                {
                    NameFormats.StandardWithMiddleWithPrefixWithSuffix,
                    () => new[] {Prefix(sex), First(sex), Middle(sex), Last(), Suffix()}
                },
                {NameFormats.WithPrefix, () => new[] {Prefix(sex), First(sex), Last()}},
                {NameFormats.WithSuffix, () => new[] {First(sex), Last(), Suffix()}},
                {NameFormats.WithPrefixWithSuffix, () => new[] {Prefix(sex), First(sex), Last(), Suffix()}}
            };
        }

        /// <summary>
        ///     Create a name using a random format.
        /// </summary>
        public static string FullName()
        {
            return FullName(Formats.ElementAt(RandomNumber.Next(Formats.Count() - 1)));
        }

        /// <summary>
        ///     Create a name using a specified format.
        /// </summary>
        public static string FullName(NameFormats format)
        {
            return string.Join(" ", FormatMap('N')[format]
                .Invoke());
        }

        /// <summary>
        ///     Create a name using a random format.
        /// </summary>
        public static string FullNameMale()
        {
            return FullNameMale(Formats.ElementAt(RandomNumber.Next(Formats.Count() - 1)));
        }

        /// <summary>
        ///     Create a name using a specified format.
        /// </summary>
        public static string FullNameMale(NameFormats format)
        {
            return string.Join(" ", FormatMap('M')[format]
                .Invoke());
        }

        /// <summary>
        ///     Create a name using a random format.
        /// </summary>
        public static string FullNameFemale()
        {
            return FullNameFemale(Formats.ElementAt(RandomNumber.Next(Formats.Count() - 1)));
        }

        /// <summary>
        ///     Create a name using a specified format.
        /// </summary>
        public static string FullNameFemale(NameFormats format)
        {
            return string.Join(" ", FormatMap('F')[format]
                .Invoke());
        }

        public static string First(char sex = 'N')
        {
            switch (sex)
            {
                case 'M':
                    return Resources.Name.FirstMale.Split(Config.Separator)
                        .Random()
                        .Trim();
                case 'F':
                    return Resources.Name.FirstFemale.Split(Config.Separator)
                        .Random()
                        .Trim();
                default:
                    return Resources.Name.First.Split(Config.Separator)
                        .Random()
                        .Trim();
            }
        }

        public static string Middle(char sex = 'N')
        {
            switch (sex)
            {
                case 'M':
                    return Resources.Name.FirstMale.Split(Config.Separator)
                        .Random()
                        .Trim();
                case 'F':
                    return Resources.Name.FirstFemale.Split(Config.Separator)
                        .Random()
                        .Trim();
                default:
                    return Resources.Name.First.Split(Config.Separator)
                        .Random()
                        .Trim();
            }
        }

        public static string Last()
        {
            return Resources.Name.Last.Split(Config.Separator)
                .Random()
                .Trim();
        }

        public static string Prefix(char sex = 'N')
        {
            switch (sex)
            {
                case 'M':
                    return Resources.Name.PrefixMale.Split(Config.Separator)
                        .Random()
                        .Trim();
                case 'F':
                    return Resources.Name.PrefixFemale.Split(Config.Separator)
                        .Random()
                        .Trim();
                default:
                    return Resources.Name.Prefix.Split(Config.Separator)
                        .Random()
                        .Trim();
            }
        }

        public static string Suffix()
        {
            return Resources.Name.Suffix.Split(Config.Separator)
                .Random();
        }
    }
}