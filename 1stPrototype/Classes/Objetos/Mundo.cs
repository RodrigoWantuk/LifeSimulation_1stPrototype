using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stPrototype.Classes.Objetos
{
    public class Mundo
    {
        private static Mundo instance;

        public static Mundo GetInstance()
        {
            if(instance == null)
                instance = new Mundo();

            return instance;
        }

        private Mundo()
        {

        }

        public long GetServerTick()
        {
            return 0;
        }
    }
}
