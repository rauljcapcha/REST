using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using IronSharp.Core;
using IronSharp.IronMQ;

namespace ServiceREST_Preguntas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceRespuestas" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceRespuestas.svc or ServiceRespuestas.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRespuestas : IServiceRespuestas
    {
        public void Respuestas(string texto)
        {
            var iromMq = IronSharp.IronMQ.Client.New(new IronClientConfig { ProjectId = "5ae4f7a04f1745000ce9c762", Token = "kI4nEtFhvuEtXOJ9ZqZE", Host = "mq-aws-eu-west-1-1.iron.io", Scheme = "http" });
            var queues = iromMq.Queues();
            QueueClient respuestas = iromMq.Queue("RespuestasREST");
            respuestas.Post(texto);
        }
    }
}
