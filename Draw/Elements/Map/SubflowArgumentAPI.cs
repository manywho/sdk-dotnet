using ManyWho.Flow.SDK.Draw.Elements.Value;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    public class SubflowArgumentAPI
    {
        /// <summary>
        /// The reference to the value used in a subflow to refer to one of the pieces of data provided as input or output to the subflow
        /// The referenced value must be imported into the subflow and must have one of the following access types: INPUT, OUTPUT or INPUT_OUTPUT 
        /// </summary>
        public ValueElementIdAPI valueElementInSubflowId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the value passed from a calling flow to a subflow
        /// The referenced value must be imported into the calling flow and must have the same contentType and type as the valueElementInSubflowId property
        /// </summary>
        public ValueElementIdAPI valueElementToApplyId
        {
            get;
            set;
        }
    }
}