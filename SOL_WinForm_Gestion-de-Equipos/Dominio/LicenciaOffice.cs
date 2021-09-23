using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LicenciaOffice
    {
        public int IDLicenciaOffice { get; set; }
        public LicenciaCartonOffice CartonOffice { get; set; }
        public DateTime FechaCarga { get; set; }
        public string Numero { get; set; }

    }
}
