using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentResponseAPI
    {
        [DataMember]
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String componentType
        {
            get;
            set;
        }

        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        [DataMember]
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public List<PageComponentColumnResponseAPI> columns
        {
            get;
            set;
        }

        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        [DataMember]
        public Int32 maxSize
        {
            get;
            set;
        }

        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        [DataMember]
        public String hintValue
        {
            get;
            set;
        }

        [DataMember]
        public String helpInfo
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isMultiSelect
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isSearchable
        {
            get;
            set;
        }

        [DataMember]
        public Boolean hasEvents
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }
    }
}