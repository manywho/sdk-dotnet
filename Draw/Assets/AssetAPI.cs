using System;

namespace ManyWho.Flow.SDK.Draw.Assets
{
    public class AssetAPI
    {
        public string ContentType
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public DateTimeOffset ModifiedAt
        {
            get;
            set;
        }

        public string PublicUrl
        {
            get;
            set;
        }

        public long Size
        {
            get;
            set;
        }
    }
}
