using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEPermiso
    {
        public int Id { get; set; }

        public string NombrePermiso { get; set; }

        public abstract IList<BEPermiso> SubComponentes { get; }

        public abstract void AgregarSubcomponente(BEPermiso c);
        public abstract void VaciarSubcomponente();


        public override string ToString()
        {
            return NombrePermiso;
        }
    }
}
