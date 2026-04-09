using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.ClasesDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class CUAltaTema
    {
        public void EjecutarAlta(Tema nuevo)
        {           
            RepositorioTemas repo = new RepositorioTemas();
            repo.Add(nuevo);
        }
    }
}
