using MartialBase.FakeData.Extensions;

namespace MartialBase.FakeData
{
    public static class Country
    {
        public static string TwoLetterCode()
        {
            return Resources.Country.Iso2LetterCodes.Split(Config.Separator)
                .Random();
        }

        public static string Name()
        {
            return Resources.Country.Names.Split(Config.Separator)
                .Random();
        }
    }
}