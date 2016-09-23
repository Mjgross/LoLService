using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GetChamps
{
    //Service that calls the League API and returns the data in a list format 
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/update/{name}")]
        List<string> update(string username);

    }

    [DataContract]
    public class SummonerData
    {
        [DataMember]
        List<string>summonerData { get; set; }
        

    }

}
