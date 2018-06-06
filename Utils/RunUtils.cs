using System;

namespace ManyWho.Flow.SDK.Utils
{
    public class RunUtils
    {
        public static string CompleteJoinUrl(string url, Guid stateId)
        {
            if (url.IndexOf('?') > 0)
            {
                url += "&join=" + stateId;
            }
            else
            {
                url += "?join=" + stateId;
            }

            return url;
        }

        public static string CompleteRunUrl(string url, Guid flowId)
        {
            if (url.IndexOf('?') > 0)
            {
                url += "&flow-id=" + flowId;
            }
            else
            {
                url += "?flow-id=" + flowId;
            }

            return url;
        }
    }
}
