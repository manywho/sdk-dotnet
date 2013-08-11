using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FilesListAPI
    {
        public FilesListAPI()
        {
            this.files = new List<FileAPI>();
        }

        [DataMember]
        public List<FileAPI> files 
        { 
            get; 
            set; 
        }
    }
}
