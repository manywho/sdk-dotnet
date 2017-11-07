using System;
using System.Runtime.Serialization;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Draw.Elements.Value
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueElementIdAPI
    {
        public ValueElementIdAPI()
        {

        }

        public ValueElementIdAPI(Guid id, Guid typeElementPropertyId, String command)
        {
            this.id = id.ToString();

            if (typeElementPropertyId != null &&
                typeElementPropertyId != Guid.Empty)
            {
                this.typeElementPropertyId = typeElementPropertyId.ToString();
            }

            this.command = command;
        }

        public ValueElementIdAPI(String id, String typeElementPropertyId, String command)
        {
            this.id = id;
            this.typeElementPropertyId = typeElementPropertyId;
            this.command = command;
        }

        /// <summary>
        /// The unique identifier for the Value to be referenced with this identifier.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for a property in the Value to be referenced with this identifier. This only applies for Values of type ContentObject.
        /// </summary>
        [DataMember]
        public String typeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The command to execute as part of the Value reference. For certain objects, the command exposes additional properties that can be referenced.
        /// </summary>
        [DataMember]
        public String command
        {
            get;
            set;
        }
    }
}