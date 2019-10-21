using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Entities
{
    public class Horario
    {
        public int HorarioId { get; set; }
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
        public DateTime Hora { get; set; }
    }
}
