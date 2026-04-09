using LogicaNegocio.ClasesDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.InterfacesDominio
{
    public interface IEvaluadorAstronomico
    {
        ResultadoEvaluacion Evaluar(
            Telescopio telescopio,
            Montura montura,
            Camara camara,
            Ocular ocular,
            ObjetoCeleste objeto
        );
    }
}
