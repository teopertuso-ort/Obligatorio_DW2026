using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.ClasesDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class CUBuscarTemaId
    {
        public Tema BuscarTema(int id)
        {
            RepositorioTemas repo = new RepositorioTemas();
            return repo.FindById(id);
        }
    }
}
