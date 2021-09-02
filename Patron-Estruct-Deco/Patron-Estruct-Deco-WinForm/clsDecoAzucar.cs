using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    public class clsDecoAzucar : clsAgregadoDecorator
    {
        public clsDecoAzucar(clsBebidaComponent bebida) : base(bebida) { }

        public override double Costo => _bebida.Costo + 0.5;
        public override string Descripcion => string.Format($"{_bebida.Descripcion}, Azucar");
    }
}
