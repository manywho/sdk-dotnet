using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Tenant
{
    public enum ReleaseCycle
    {
        [EnumMember(Value = "rolling")]
        Rolling = 0,
        [EnumMember(Value = "monthly")]
        Monthly = 1
    }
}
