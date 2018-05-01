using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceREST_Preguntas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePreguntar" in both code and config file together.
    [ServiceContract]
    public interface IServicePreguntar
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Preguntar/{texto}", ResponseFormat = WebMessageFormat.Json)]
        string Preguntar(string texto);
    }
}
