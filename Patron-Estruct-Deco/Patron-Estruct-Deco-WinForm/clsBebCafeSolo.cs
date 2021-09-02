using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estruct_Deco_WinForm
{
    public class clsBebCafeSolo : clsBebidaComponent
    {
        // definir costo y descripcion
        public override double Costo => 10;
        public override string Descripcion => "Cafe Solo";
    }
}
