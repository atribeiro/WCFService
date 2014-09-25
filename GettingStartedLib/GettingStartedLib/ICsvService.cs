using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{

    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
   
    
    public interface ICsvService
    {
        [OperationContract]
        string GetName(string name);
        [OperationContract]
        string GetCountry(string country);
        [OperationContract]
        Details GetPerson(string name);
        [OperationContract]
        List<Details> GetListOfPeople();
    }
}
