using Excepciones;
using LogicaNegocio.Enums;
using LogicaNegocio.InterfacesDominio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaNegocio.ClasesDominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Email Email { get; set; }
        public string Username { get; set; }
        public Password Password { get; set; }
        public Rol Rol { get; set; }

        public void Validar()
        {
            if (NombreCompleto == null) { throw new DatosInvalidosException("El nombre del tema es obligatorio"); }
        }
    }
}
