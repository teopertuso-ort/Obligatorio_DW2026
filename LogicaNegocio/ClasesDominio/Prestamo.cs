using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ClasesDominio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoPrestamo Estado { get; set; }

        public required Usuario Usuario { get; set; }

        public Telescopio Telescopio { get; set; }
        public Montura Montura { get; set; }
        public Camara? Camara { get; set; }
        public Ocular? Ocular { get; set; }

        public bool EstaVigente()
        {
            return Estado == EstadoPrestamo.EN_PRESTAMO &&
                   DateTime.Now >= FechaInicio &&
                   DateTime.Now <= FechaFin;
        }

        public void Validar()
        {
            if (Telescopio == null || Montura == null)
                throw new Exception("Debe seleccionar telescopio y montura");

            if (Camara == null && Ocular == null)
                throw new Exception("Debe seleccionar cámara u ocular");

            if (!Montura.SoportaPeso(Telescopio.PesoKg))
                throw new Exception("La montura no soporta el peso del telescopio");

            if (Camara != null &&
                Montura.TipoMontura == TipoMontura.ALTAZIMUTAL)
                throw new Exception("No se puede usar cámara con montura AltAzimutal");
        }
    }
}
