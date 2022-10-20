namespace ChannelEngine.Common.Extensions
{
    public static class ChannelEngineExtensions
    {
        public static string EnsureTrailingSlash(this string url)
        {
            if (url.EndsWith("/"))
                return url;
            return url + "/";
        }
    }
}
