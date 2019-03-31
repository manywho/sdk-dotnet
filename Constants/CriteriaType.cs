namespace ManyWho.Flow.SDK.Constants
{
    public class CriteriaType
    {
        /// <summary>
        /// {left} is equal to {right}
        /// </summary>
        public const string Equal = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_EQUAL;

        /// <summary>
        /// All values in {left} are equal to {right}
        /// </summary>
        public const string AllEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ALL_EQUAL;

        /// <summary>
        /// Any value in {left} is equal to {right}
        /// </summary>
        public const string AnyEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ANY_EQUAL;

        /// <summary>
        /// {left} is not equal to {right}
        /// </summary>
        public const string NotEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_NOT_EQUAL;

        /// <summary>
        /// {left} is greater than {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string GreaterThan = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN;

        /// <summary>
        /// {left} is greater than or equal to {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string GreaterThanOrEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN_OR_EQUAL;

        /// <summary>
        /// {left} is less than {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string LessThan = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN;

        /// <summary>
        /// {left} is less than or equal to {right}. For ContentString types, this is done alphabetically.
        /// </summary>
        public const string LessThanOrEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN_OR_EQUAL;

        /// <summary>
        /// {left} contains the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string Contains = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS;

        /// <summary>
        /// {left} starts with the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string StartsWith = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH;

        /// <summary>
        /// {left} ends with the characters in {right}. This is only valid for ContentString types and is case insensitive.
        /// </summary>
        public const string EndsWith = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH;

        /// <summary>
        /// {left} is empty or null. When this criteria type is used, it must be compared with a {right} that is a ContentBoolean.
        /// </summary>
        public const string IsEmpty = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_IS_EMPTY;
    }
}