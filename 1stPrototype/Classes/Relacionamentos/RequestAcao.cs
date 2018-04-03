using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Classes.Objetos;
using _1stPrototype.Enumeradores;

namespace _1stPrototype.Classes.Relacionamentos
{
    class RequestAcao
    {
        private Human hmnRequester; // Solicitante
        private Human hmnRequested; // Solicitado
        private enumRequestState ersRequestState; // Status atual do request
        private long lngTimeoutTick; // Indica em qual server-tick ocorrérá o timeout do request.
    }
}
