using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Run.Flow
{
    public class FlowGraphResponse
    {
        /// <summary>
        /// Indicates that the builder of the flow will allow users to jump to any position in the Flow regardless of outcomes and/or navigation.
        /// </summary>
        public bool AllowJumping
        {
            get;
            set;
        }

        public DateTimeOffset DateModified
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the flow. When referencing flows by name, this is the name you should use in your referencing.
        /// </summary>
        /// <remarks>
        /// This is typically a helpful name to remind builders of the purpose of the flow.
        /// </remarks>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the Flow.
        /// </summary>
        public string DeveloperSummary
        {
            get;
            set;
        }

        /// <summary>
        /// An array of group elements that are part of the flow graph.
        /// </summary>
        public IEnumerable<GroupElement> GroupElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete unique identifier for the currently edited version of the flow.
        /// </summary>
        /// <remarks>
        /// This value should not be included when creating new flows.
        /// </remarks>
        public FlowIdAPI Id
        {
            get;
            set;
        }

        /// <summary>
        /// An array of map elements that are part of the flow graph.
        /// </summary>
        public IEnumerable<MapElement> MapElements
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the first element in the flow. This element is always of the `START` map element type.
        /// </summary>
        public Guid StartMapElementId
        {
            get;
            set;
        }

        public Guid TenantId
        {
            get;
            set;
        }

        public class GroupElement
        {
            /// <summary>
            /// The unique identifier for the element. The id should be null for "insert" requests and a valid identifier for "update" requests.
            /// </summary>
            public Guid Id
            {
                get;
                set;
            }

            /// <summary>
            /// The developer name for the element. This is useful for keeping track of the element in the modelling tool and the API.
            /// </summary>
            public string DeveloperName
            {
                get;
                set;
            }

            /// <summary>
            /// The developer summary the author provided to give more information about the element
            /// </summary>
            public string DeveloperSummary
            {
                get;
                set;
            }

            /// <summary>
            /// The type of element this metadata represents.
            /// </summary>
            public string ElementType
            {
                get;
                set;
            }

            /// <summary>
            /// The unique identifier for the group element that holds this group element.
            /// </summary>
            /// <remarks>
            /// The swimlane group element does not support nested groupings.
            /// </remarks>
            public Guid? GroupElementId
            {
                get;
                set;
            }

            /// <summary>
            /// The height of the Group on the Flow diagram.
            /// </summary>
            public int Height
            {
                get;
                set;
            }

            /// <summary>
            /// The width of the Group on the Flow diagram.
            /// </summary>
            public int Width
            {
                get;
                set;
            }

            /// <summary>
            /// The x location of the Group on the Flow diagram.
            /// </summary>
            public int X
            {
                get;
                set;
            }

            /// <summary>
            /// The y location of the Group on the Flow diagram.
            /// </summary>
            public int Y
            {
                get;
                set;
            }
        }

        public class MapElement
        {
            /// <summary>
            /// The unique identifier for the element. The id should be null for "insert" requests and a valid identifier for "update" requests.
            /// </summary>
            public Guid Id
            {
                get;
                set;
            }

            /// <summary>
            /// The developer name for the element. This is useful for keeping track of the element in the modelling tool and the API.
            /// </summary>
            public string DeveloperName
            {
                get;
                set;
            }

            /// <summary>
            /// The developer summary the author provided to give more information about the element
            /// </summary>
            public string DeveloperSummary
            {
                get;
                set;
            }

            /// <summary>
            /// The type of element this metadata represents.
            /// </summary>
            public string ElementType
            {
                get;
                set;
            }

            /// <summary>
            /// The unique identifier for the group element that holds this group element.
            /// </summary>
            /// <remarks>
            /// The swimlane group element does not support nested groupings.
            /// </remarks>
            public Guid? GroupElementId
            {
                get;
                set;
            }

            /// <summary>
            /// The list of outcomes that are available for this Map Element. An Outcome is used to connect the flow of execution from one Map Element in the Flow to another. An Outcome can take the form of a Page button, but also define system steps such as rules.
            /// </summary>
            public IEnumerable<Outcome> Outcomes
            {
                get;
                set;
            }

            /// <summary>
            /// The x location of the Group on the Flow diagram.
            /// </summary>
            public int X
            {
                get;
                set;
            }

            /// <summary>
            /// The y location of the Group on the Flow diagram.
            /// </summary>
            public int Y
            {
                get;
                set;
            }

            public class Outcome
            {
                /// <summary>
                /// The unique identifier for the outcome. This property is created by the service.
                /// </summary>
                /// <remarks>
                /// This value should not be included when creating new outcomes.
                /// </remarks>
                public Guid Id
                {
                    get;
                    set;
                }

                /// <summary>
                /// The array of control points (or “kinks”) in the outcome arrow as it appears in the flow diagram. If there
                /// are no control points, it is assumed the arrow for the outcome points directly from this map element to the
                /// next map element.
                /// </summary>
                public IEnumerable<ControlPointAPI> ControlPoints
                {
                    get;
                    set;
                }

                /// <summary>
                /// The developer name to help identify this outcome in tooling and APIs.
                /// </summary>
                public string DeveloperName
                {
                    get;
                    set;
                }

                /// <summary>
                /// The label that should appear with the outcome. For UI situations, this is typically the text that will
                /// appear on the button.
                /// </summary>
                public string Label
                {
                    get;
                    set;
                }

                /// <summary>
                /// The unique identifier for the next map element in the flow that should be executed if this outcome is
                /// selected.
                /// </summary>
                /// <remarks>
                /// If a <code>flowOut</code> key is configured, this property is not required as the running user(s) will leave
                /// the current flow and be sent into the flow configured in the <code>flowOut</code>.
                /// </remarks>
                public Guid? NextMapElementId
                {
                    get;
                    set;
                }

                /// <summary>
                /// The order in which the outcomes should be rendered relative to its peers. The lowest number is rendered first.
                /// </summary>
                public int Order
                {
                    get;
                    set;
                }

                /// <summary>
                /// An arbitrary string value that indicates the type of button the outcome represents. This indicates to UX
                /// designers how they should render the button to running users.
                /// </summary>
                /// <remarks>
                /// For example, if this key is set to <code>DELETE</code>, the UX designer might decide to give the outcome
                /// button a red background and an "x" icon.
                /// </remarks>
                public string PageActionBindingType
                {
                    get;
                    set;
                }

                /// <summary>
                /// Determines if the data collected in this map element should be saved, and the type of validation that should
                /// be applied when saving.
                /// </summary>
                public string PageActionType
                {
                    get;
                    set;
                }
            }
        }
    }
}