using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Classes.Objetos;

namespace _1stPrototype.Classes.Relacionamentos
{
    class RelacionamentoHumano
    {
        private Human mhmnParceiroA;
        private Human mhmnParceiroB;

        private int mintDiaFirstMeet; // Dia do Primeiro Encontro.
        private int mintDiaStartDating; // Dia do inicio do namoro.
        private int mintDiaStartNoivado; // Dia do inicio do noivado / pedido de casamento.
        private int mintDiaStartCasamento; // Dia do casamento.

        private int mintDiaFimRelacionamento; // Dia do fim do relacionamento.
    }
}
