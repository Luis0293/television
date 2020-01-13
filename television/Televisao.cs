using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace television
{
    class Televisao
    {
        public bool enviar = true;
        public bool enviar2 = false;

        private bool envia
        {
            get
            {
                return enviar & enviar2;
            }
        }
    }
}
