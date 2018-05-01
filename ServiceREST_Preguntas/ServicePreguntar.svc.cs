using ApiAiSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceREST_Preguntas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePreguntar" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePreguntar.svc or ServicePreguntar.svc.cs at the Solution Explorer and start debugging.
    public class ServicePreguntar : IServicePreguntar
    {
        private ApiAi apiAi;
        public string Preguntar(string texto)
        {
            var config = new AIConfiguration("21958005f5f248369e6c263abe7d1572 ", SupportedLanguage.Spanish);
            apiAi = new ApiAi(config);
            var response = apiAi.TextRequest(texto);
            string Respuesta = response.Result.Fulfillment.Speech;
            return Respuesta;
        }
    }
}
