using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ClasesDominio
{
    public class AuditoriaPrestamo
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public TipoAccionAuditoria Accion { get; set; }

        public Prestamo Prestamo { get; set; }

        public Usuario Usuario { get; set; }
    }
}
