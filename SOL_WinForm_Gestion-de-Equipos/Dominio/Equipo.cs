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
        public Tecnico IDTecnicoAsignado { get; set; }
        public Oficina IDOficina { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public CPU IDCPU { get; set; }
        public GPU IDGPU { get; set; }
        public RAM IDRAM { get; set; }
        public Disco IDDisco1 { get; set; }
        public Disco IDDisco2 { get; set; }
        public LicenciaWindows IDWindows { get; set; }
        public LicenciaOffice IDOffice { get; set; }

    }
}
