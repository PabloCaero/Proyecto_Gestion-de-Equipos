using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LicenciaCartonOffice
    {
        public int IDLicenciaCartonOffice { get; set; } 
        public Cuenta IDCuenta { get; set; }
        public string Descripcion { get; set; }
        public string Numero { get; set; }

    }
}
