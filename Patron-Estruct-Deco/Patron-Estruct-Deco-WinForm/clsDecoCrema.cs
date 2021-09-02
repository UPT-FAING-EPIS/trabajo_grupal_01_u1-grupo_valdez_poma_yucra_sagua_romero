using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    public class clsDecoCrema : clsAgregadoDecorator
    {
        public clsDecoCrema(clsBebidaComponent bebida) : base(bebida) { }

        public override double Costo => _bebida.Costo + 2;
        public override string Descripcion => string.Format($"{_bebida.Descripcion}, Crema");
    }
}
