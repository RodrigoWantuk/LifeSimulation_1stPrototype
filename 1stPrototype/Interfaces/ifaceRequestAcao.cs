using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Classes.Relacionamentos;

namespace _1stPrototype.Interfaces
{
    interface ifaceRequestAcao
    {
        // Essa interface deve ser implementada por quaisquer ações que precisem da permissão de outro Humano (um ou mais) antes de ser realizada
        // Ex. Pedido de aumento, Pedido de casamento, Pedido de tentativa de ter filho, etc.


        // Retorna a(s) classe(s) que representa(m) o(s) pedido(s), o(s) Request(s).
        List<RequestAcao> GetRequestsAcao();
        
    }
}
