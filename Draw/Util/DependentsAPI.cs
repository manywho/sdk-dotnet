using System;
using Newtonsoft.Json;

/*!

Copyright 2016 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Draw.Util
{
    public class DependentsAPI
    {
        public Guid Id
        {
            get;
            set;
        }

        public string DeveloperName
        {
            get;
            set;
        }

        public string DeveloperSummary
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        [JsonIgnore]
        public string FriendlyType
        {
            get;
            set;
        }

        public Guid DependsOnElementId
        {
            get;
            set;
        }

        public string DependsOnElementType
        {
            get;
            set;
        }

        public string DependsOnElementDeveloperName
        {
            get;
            set;
        }

        public string DependsOnElementDeveloperSummary
        {
            get;
            set;
        }
    }
}
