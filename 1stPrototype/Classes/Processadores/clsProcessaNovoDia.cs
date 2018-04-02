using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Classes.Objetos;

namespace _1stPrototype.Classes.Processadores
{
    class clsProcessaNovoDia
    {
        public void ProcessaNovoDia(Human human)
        {
            if (!human.IsVivo())
                return;

            human.IncreaseIdade();


        }
    }
}
