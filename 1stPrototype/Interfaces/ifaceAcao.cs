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

        enumResultadoAcao DoAcao(Human _human, List<Object> _params);

        List<EfeitoAcao> ObtemEfeitos();
    }
}
