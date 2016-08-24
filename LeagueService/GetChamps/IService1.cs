﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GetChamps
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetChamps/{name}")]
        championList getChamps(long sumId);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class championList
    {
        [DataMember]
        public List<championInfo> champs;
     }
    [DataContract]
    public class championInfo
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int totalDeaths { get; set; }
        [DataMember]
        public int totalDamageTaken { get; set; }
        [DataMember]
        public Int32 shit { get; set; }

    }
}
