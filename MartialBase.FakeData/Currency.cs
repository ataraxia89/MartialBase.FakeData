using MartialBase.FakeData.Extensions;

namespace MartialBase.FakeData
{
    public static class Currency
    {
        public static string ThreeLetterCode()
        {
            return Resources.Currency.Iso3LetterCodes.Split(Config.Separator)
                .Random();
        }

        public static string Name()
        {
            return Resources.Currency.Names.Split(Config.Separator)
                .Random();
        }
    }
}