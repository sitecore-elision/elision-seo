using System;
using Sitecore;
using Sitecore.Configuration;

namespace Elision.Feature.Library.Seo.SC.Integration.Caching
{
    public class ErrorPagesResponseCache : Sitecore.Caching.CustomCache
    {
        public ErrorPagesResponseCache(long maxSize) : base("Elision.Feature.Library.Seo.ErrorPagesResponseCache", maxSize)
        {
        }

        public static readonly ErrorPagesResponseCache Current = new ErrorPagesResponseCache(StringUtil.ParseSizeString(Settings.GetSetting("Elision.Feature.Library.Seo.ErrorPagesResponseCache", "50MB")));

        public string Get(string cacheKey)
        {
            return GetString(cacheKey);
        }

        public void Set(string cacheKey, string value)
        {
            SetString(cacheKey, value, DateTime.Now.AddDays(1));
        }

        public override void Remove(string cacheKey)
        {
            base.Remove(cacheKey);
        }
    }
}
