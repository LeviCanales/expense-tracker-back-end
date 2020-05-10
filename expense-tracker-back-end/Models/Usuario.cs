using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contra { get; set; }
        public int PersonaID { get; set; }
        public Persona Persona { get; set; }
    }
}
