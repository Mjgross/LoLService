using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Runtime.Serialization;

namespace GetUser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetUser/{name}")]
        UserData getData(string name);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserData
    {
        [DataMember]
        public long id { get; set;}
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int profileIcon { get; set; }
        [DataMember]
        public long revisionDate { get; set; }
        [DataMember]
        public int summonerIcon { get; set; }
        //[DataMember]
        //public List<championInfo> champions { get; set; }
        [DataMember]
        public long modifyDate { get; set; }

    }
}
