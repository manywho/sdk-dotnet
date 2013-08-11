using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Group;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowGraphRequestAPI : FlowRequestAPI
    {
        [DataMember]
        public List<MapElementAPI> mapElements
        {
            get;
            set;
        }

        public void RemoveMapElement(String id)
        {
            bool found = false;
            int index = 0;

            // Search the list to see if this map element exists already
            foreach (MapElementAPI mapElementEntry in this.mapElements)
            {
                if (mapElementEntry.id == id)
                {
                    found = true;
                    break;
                }

                index++;
            }

            // If the entry is found, remove it
            if (found == true)
            {
                this.mapElements.RemoveAt(index);
            }
        }

        public void RemoveMapElement(MapElementAPI mapElement)
        {
            RemoveMapElement(mapElement.id);
        }

        public void UpsertMapElement(MapElementAPI mapElement)
        {
            MapElementAPI reducedMapElement = new MapElementAPI();

            if (this.mapElements == null)
            {
                this.mapElements = new List<MapElementAPI>();
            }

            // We convert the map element back to a map element api object to stop WCF from breaking
            reducedMapElement.developerName = mapElement.developerName;
            reducedMapElement.developerSummary = mapElement.developerSummary;
            reducedMapElement.elementType = mapElement.elementType;
            reducedMapElement.id = mapElement.id;
            reducedMapElement.outcomes = mapElement.outcomes;
            reducedMapElement.x = mapElement.x;
            reducedMapElement.y = mapElement.y;
            reducedMapElement.groupElementId = mapElement.groupElementId;

            // Remove the existing entry
            RemoveMapElement(reducedMapElement);

            // Finally, add the map element to the list
            this.mapElements.Add(reducedMapElement);
        }

        [DataMember]
        public List<GroupElementAPI> groupElements
        {
            get;
            set;
        }

        public void RemoveGroupElement(String id)
        {
            bool found = false;
            int index = 0;

            // Search the list to see if this group element exists already
            foreach (GroupElementAPI groupElementEntry in this.groupElements)
            {
                if (groupElementEntry.id == id)
                {
                    found = true;
                    break;
                }

                index++;
            }

            // If the entry is found, remove it
            if (found == true)
            {
                this.groupElements.RemoveAt(index);
            }
        }

        public void RemoveGroupElement(GroupElementAPI groupElement)
        {
            RemoveGroupElement(groupElement.id);
        }

        public void UpsertGroupElement(GroupElementAPI groupElement)
        {
            GroupElementAPI reducedGroupElement = new GroupElementAPI();

            if (this.groupElements == null)
            {
                this.groupElements = new List<GroupElementAPI>();
            }

            // We convert the group element back to a group element api object to stop WCF from breaking
            reducedGroupElement.developerName = groupElement.developerName;
            reducedGroupElement.developerSummary = groupElement.developerSummary;
            reducedGroupElement.elementType = groupElement.elementType;
            reducedGroupElement.id = groupElement.id;
            reducedGroupElement.groupElementId = groupElement.groupElementId;
            reducedGroupElement.x = groupElement.x;
            reducedGroupElement.y = groupElement.y;
            reducedGroupElement.height = groupElement.height;
            reducedGroupElement.width = groupElement.width;

            // Remove the existing entry
            RemoveGroupElement(reducedGroupElement);

            // Finally, add the group element to the list
            this.groupElements.Add(reducedGroupElement);
        }
    }
}