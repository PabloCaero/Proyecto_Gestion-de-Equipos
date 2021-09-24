using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Equipo
    {
        public int IDEquipo { get; set; }
        public int Ticket { get; set; }
        public Tecnico Tecnico { get; set; }
        public Oficina Oficina { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public RAM RAM { get; set; }
        public Disco Disco1 { get; set; }
        public Disco Disco2 { get; set; }
        public LicenciaWindows LicenciaWindows { get; set; }
        public LicenciaOffice LicenciaOffice { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
