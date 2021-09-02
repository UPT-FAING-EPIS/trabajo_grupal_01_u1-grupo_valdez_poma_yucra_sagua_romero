using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    class clsDecoEdulcorante : clsAgregadoDecorator
    {
        public clsDecoEdulcorante(clsBebidaComponent bebida) : base(bebida) { }

        public override double Costo => _bebida.Costo + 1;
        public override string Descripcion => string.Format($"{_bebida.Descripcion}, Edulcorante");
    }
}
