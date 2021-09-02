using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    public abstract class clsAgregadoDecorator : clsBebidaComponent
    {
        protected clsBebidaComponent _bebida;
        public clsAgregadoDecorator(clsBebidaComponent bebida)
        {
            _bebida = bebida;
        }
    }
}
