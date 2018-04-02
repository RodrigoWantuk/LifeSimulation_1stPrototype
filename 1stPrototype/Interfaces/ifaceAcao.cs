using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Enumeradores;
using _1stPrototype.Classes.Objetos;
using _1stPrototype.Classes.Relacionamentos;

namespace _1stPrototype.Interfaces
{
    public interface ifaceAcao
    { // Essa interface deve ser implementada por todas as classes que representam uma ação, como estudar, trabalhar, viajar, roubar, etc.

        // Ações devem ter um tempo fixo, pré-definido. Ao Registrar a ação, o método abaixo deverá indicar até qual "server-tick" a ação estará sendo executada.
        // Ao concluir a ação, será aplicado ao Humano os bonus consultados pelo método ObtemEfeitos.

        enumResultadoAcao RegistraAcao(Human _human, List<Object> _params, ref long ticksFimAcao);

        List<EfeitoAcao> ObtemEfeitos();
    }
}
