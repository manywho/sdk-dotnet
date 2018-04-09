using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    public enum StateStatusAPI
    {
        [EnumMember(Value = "")]
        All = 0,
        [EnumMember(Value = "done")]
        Done = 1,
        [EnumMember(Value = "expired")]
        Expired = 2,
        [EnumMember(Value = "in_progress")]
        InProgress = 3,
        [EnumMember(Value = "errored")]
        Errored = 4
    }
}