using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Reflection;
using ManyWho.Flow.SDK.Draw.Elements;
using ManyWho.Flow.SDK.Attributes;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Run.Elements.Type;

/*!

Copyright 2014 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/
namespace ManyWho.Flow.SDK.Draw.Log
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    [ObjectAPI("LogEntry")]
    public class LogEntryAPI : ElementAPI
    {
        [DataMember]
        [PropertyAPI("Id")]
        public string Id
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("Timestamp")]
        public DateTime Timestamp
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("Message")]
        public string Message
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("Data")]
        public string Data
        {
            get;
            set;
        }
    }
}
