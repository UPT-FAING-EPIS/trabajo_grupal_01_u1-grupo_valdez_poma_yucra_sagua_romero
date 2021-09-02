using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    public class clsBebCafeExpresso : clsBebidaComponent
    {
        public override double Costo => 12;
        public override string Descripcion => "Cafe Expressoo";
    }
}
