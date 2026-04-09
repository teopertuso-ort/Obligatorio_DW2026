using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.ClasesDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class CUListadoTemas
    {
        public IEnumerable<Tema> ObtenerListado()
        {
            RepositorioTemas repo = new RepositorioTemas();
            return repo.FindAll();
        }
    }
}
