using MartialBase.FakeData.Extensions;

namespace MartialBase.FakeData
{
    public static class Phone
    {
        public static string Number()
        {
            return Resources.Phone.Formats.Split(Config.Separator)
                .Random()
                .Trim()
                .Numerify();
        }
    }
}