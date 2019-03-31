namespace ManyWho.Flow.SDK.Constants
{
    public class CommandType
    {
        /// <summary>
        /// Removes the external identifier from the root Object so that it will not be "remembered" when updating Lists or saving back to a remote Service
        /// </summary>
        public const string Detach = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_DETACH;

        /// <summary>
        /// Blanks out the complex object or table with empty values
        /// </summary>
        public const string Empty = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_EMPTY;

        /// <summary>
        /// Creates a new instance of the value
        /// </summary>
        public const string New = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_NEW;

        /// <summary>
        /// Adds an Object to a List value. If the Object exists in the List, the Object is updated. If it is not already in the List, it's added.
        /// </summary>
        public const string Add = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_UPDATE;

        /// <summary>
        /// Removes an Object from a List value or subtracts from a value
        /// </summary>
        public const string Remove = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_REMOVE;

        /// <summary>
        /// Gets the first Object from a List value
        /// </summary>
        public const string GetFirst = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_FIRST;

        /// <summary>
        /// Gets the next Object from a List value. List values maintain a "pointer" so that each time the GET_NEXT command is executed in the Flow, the List value remembers which is the next value.
        /// </summary>
        public const string GetNext = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_NEXT;

        /// <summary>
        /// Executes a filter on a List. For the FILTER command to execute correctly, additional properties must be provided.
        /// </summary>
        public const string Filter = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_FILTER;

        /// <summary>
        /// Gets the length of a List, String, Content or Password value
        /// </summary>
        public const string GetLength = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_LENGTH;

        /// <summary>
        /// Gets the content value or object data of a value
        /// </summary>
        public const string ValueOf = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_GET_VALUE;

        /// <summary>
        /// Sets the content value or object data of a value
        /// </summary>
        public const string SetEqual = ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_BASE_COMMAND_SET_EQUAL;
    }
}