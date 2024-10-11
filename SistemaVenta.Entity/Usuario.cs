using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public int IdRol { get; set; }
        public string Clave { get; set; } = null!;
        public bool EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Rol IdRolNavigation { get; set; } = null!;
    }
}
